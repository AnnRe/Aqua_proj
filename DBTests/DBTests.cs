using System;
using aquadrom.Utilities;
using DB;
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
            Assert.Pass();
        }
        [Test]
        public void ShouldOpenConnection()
        {
            //given
            DBConnector connector = new DBConnector();
            //when
            connector.Open();
            //then
            Assert.Pass();
        }

        [Test]
        public void ShouldGetDataFromBase()
        {
            //given
            DBConnector connector = new DBConnector();
            
            //when
            var pracownicy=connector.SelectPracownicy("* from Pracownicy");
            //then
            Assert.NotNull(pracownicy);
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
            
        }
       
    }
}
