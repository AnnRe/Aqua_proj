using System;
using aquadrom.Utilities;
using DB;
using System.Data;
using System.Data.SqlClient;
using NUnit.Framework;
using Objects;

namespace DBTests
{
    
    public class DBTests
    {
        [Test]
        public void ShouldConnectToDB()
        {
            //given
            DBConnector connector; 
            //when
            connector = new DBConnector();
            //then
            Assert.That(connector,Is.TypeOf<DBConnector>());
        }
        [Test]
        public void ShouldOpenConnection()
        {
            //given
            DBConnector connector = new DBConnector();
            //when
            connector.Open();
            connector.Close();
            //then
            Assert.Pass();
        }

        [Test]
        public void ShouldGetDataFromBase()
        {
            //given
            DBConnector connector = new DBConnector();
            //when
            connector.Open();
            var pracownicy=connector.SelectPracownicy("* from Pracownicy");
            //then
            //Assert.NotNull(pracownicy);
            Assert.Pass();
        }

        [Test]
        public void ShouldInsertToDatabase()
        {
            //given
            DBAdapter adapter = new DBAdapter();
            Pracownik pracownik = new Pracownik()
            {imie="Piotr",nazwisko="Adamczyk",mail="mail@o2.pl",miasto="Warszawa",pesel="78080212345",numerDomu="12",
                stopien=eStopien.I,stanowisko=eStanowisko.KSR,numerTelefonu="123456456",dataBadan=DateTime.Now,
                dataWażnościKPP=DateTime.Now,ulica="Kopernika"};
            //when
            adapter.Insert(pracownik);
            //then
            string query="Select * from pracownik where nazwisko="+pracownik.nazwisko+"and imie="+pracownik.imie;
            DataTable data = adapter.GetData(query);
            Assert.Pass();
            Assert.NotNull(data);
        }
       
    }
}
