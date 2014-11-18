using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;

namespace DB
{
    public class DBAdapter
    {
        DBConnector polaczenie;
        SqlDataAdapter adapter;
        public DBAdapter()
        {
            polaczenie = new DBConnector();
        }

        public DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();
            adapter = polaczenie.getAdapter(query); 
            adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Insert(string query)
        {
            try {  polaczenie.Insert(query);  }
            catch { return false; }
            return true;
        }

        public void Insert(Pracownik pracownik)
        {
            string query = "Pracownik ("+
                Constants.PracownikImieKol+","+
                Constants.PracownikNazwiskoKol+","+
                Constants.PracownikMiastoKol+","+
                Constants.PracownikUlicaKol+","+
                Constants.PracownikNrDomKol+","+
                Constants.PracownikNrMieszkaniaKol+","+
                Constants.PracownikPeselKol+","+
                Constants.PracownikStanowiskoKol+","+
                Constants.PracownikStopienBadanKol+","+
                Constants.PracownikTelKol+","+
                Constants.PracownikWaznKPPKol+","+
                Constants.PracownikMailKol+","+
                Constants.PracownikDataBadanKol;
            query+=") VALUES (";
            query += pracownik.imie +
                pracownik.nazwisko +
                pracownik.miasto +
                pracownik.ulica +
                pracownik.numerDomu +
                pracownik.numerMieszkania +
                pracownik.pesel +
                pracownik.stanowisko +
                pracownik.stopien +
                pracownik.numerTelefonu +
                pracownik.dataWażnościKPP +
                pracownik.mail +
                pracownik.dataBadan + ")";
            throw new NotImplementedException();
        }
    }
}
