using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;
using aquadrom.Objects;
using System.Data;

namespace DB
{
    public class DBConnector
    {
        private SqlConnection polaczenie;
        
        public DBConnector()
        {
            polaczenie = new SqlConnection(aquadrom.Properties.Settings.Default.AquadromConnectionString);
        }

        public void Open()
        {
            polaczenie.Open();
        }

        public void Close()
        {
            polaczenie.Close();
        }
       
        public void Insert(string query)
        {
            Open();
            string queryText = "Insert " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);
            cmdsel.ExecuteNonQuery();
            Close();
        }

        public void Delete(string query)
        {
            Open();
            string queryText = "delete " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);
            cmdsel.ExecuteNonQuery();
            Close();
        }

        public void Update(string query)
        {
            Open();
            string queryText = "update " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);
            cmdsel.ExecuteNonQuery();
            Close();
        }

        public DataTable Select(string query)
        {
            Open();
            string queryText = "SELECT " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);
            DBAdapter adapter = new DBAdapter();
            DataTable dtWorkers = adapter.GetData(queryText);
            Close();
            return dtWorkers;
        }

        public SqlDataAdapter getAdapter(string query)
        {
            return new SqlDataAdapter(query,polaczenie);
        }

        private string GetString(string colName,SqlDataReader reader)
        {
            int colIndex = reader.GetOrdinal(colName);
            return reader.IsDBNull(colIndex) ?
                                   string.Empty :
                                   reader.GetString(colIndex);
        }

        private DateTime GetDateTime(string colName, SqlDataReader reader)
        {
            int colIndex = reader.GetOrdinal(colName);
            return reader.IsDBNull(colIndex) ?
                                   DateTime.Now :
                                   reader.GetDateTime(colIndex); ;
        }

        public void Insert(Pracownik pracownik)
        {
            string KPP, stopien, mieszkania;
            if (pracownik.dataWażnościKPP == DateTime.MinValue)
                KPP = "null";
            else KPP = "'" + pracownik.dataWażnościKPP.ToString("yyyy-MM-dd") + "'";
            if (pracownik.dataWażnościKPP == DateTime.MinValue)
                stopien = "null";
            else stopien = "'" + pracownik.stopien + "'";
            if (pracownik.numerMieszkania == "")
                mieszkania = "null";
            else
                mieszkania = "'" + pracownik.numerMieszkania + "'";



            string query = "Pracownik (" +
               Constants.PracownikImie + "," +
               Constants.PracownikNazwisko + "," +
               Constants.PracownikMiasto + "," +
               Constants.PracownikUlica + "," +
               Constants.PracownikNrDom + "," +
               Constants.PracownikNrMieszkania + "," +
               Constants.PracownikPesel + "," +
               Constants.PracownikStanowisko + "," +
               Constants.PracownikStopien + "," +
               Constants.PracownikTel + "," +
               Constants.PracownikWaznKPP + "," +
               Constants.PracownikMail + "," +
               Constants.PracownikDataBadan + "," +
               Constants.PracownikLogin + "," +
               Constants.PracownikHaslo + "," +
               Constants.PracownikIDUmowy + "," +
               Constants.PracownikTypKonta + "," +
               Constants.PracownikOstrzezenieUmowa + "," +
               Constants.PracownikOstrzezenieBadania + "," +
               Constants.PracownikOstrzezenieKPP;
            query += ") VALUES ('";
            query += pracownik.imie + "','" +
                pracownik.nazwisko + "','" +
                pracownik.miasto + "','" +
                pracownik.ulica + "','" +
                pracownik.numerDomu + "'," +
                mieszkania + ",'" +
                pracownik.pesel + "','" +
                pracownik.stanowisko + "'," +
                stopien + ",'" +
                pracownik.numerTelefonu + "'," +
                KPP + ",'" +
                pracownik.mail + "','" +
                pracownik.dataBadan + "','" +
                pracownik.login + "','" +
                pracownik.haslo + "','" +
                pracownik.idUmowy + "','" +
                pracownik.typKonta + "','" +
                pracownik.oUmowa + "','" +
                pracownik.oBadania + "','" +
                pracownik.oKPP + "')";

            Insert(query);
        }

        public void Insert(Umowa umowa)
        {

            string godziny;
            if (umowa.wymiarGodzin == "0")
                godziny = "null";
            else
                godziny = "'" + umowa.wymiarGodzin + "'";

            string query = "Umowa (" +
               Constants.UmowaTypUmowy + "," +
               Constants.UmowaWymiarGodzin + "," +
               Constants.UmowaPoczatekUmowy + "," +
               Constants.UmowaKoniecUmowy;
            query += ") VALUES ('";
            query += umowa.typUmowy + "'," +
                godziny + ",'" +
                umowa.poczatekUmowy + "','" +
                umowa.koniecUmowy + "')";

            Insert(query);
        }


        public void UpdatePracownik(Pracownik pracownik)
        {
            string KPP, stopien;
            if (pracownik.dataWażnościKPP == DateTime.MinValue)
            {
                KPP = "null";
                stopien = "null";
            }
            else 
            {
                KPP = "'" + pracownik.dataWażnościKPP.ToString("yyyy-MM-dd") + "'";
                stopien = "'" + pracownik.stopien + "'";
            }

            string query = "Pracownik set " +
                Constants.PracownikImie + "='" + pracownik.imie + "', " +
                Constants.PracownikNazwisko + "='" + pracownik.nazwisko + "', " +
                Constants.PracownikMiasto + "='" + pracownik.miasto + "', " +
                Constants.PracownikUlica + "='" + pracownik.ulica + "', " +
                Constants.PracownikNrDom + "='" + pracownik.numerDomu + "', " +
                Constants.PracownikNrMieszkania + "='" + pracownik.numerMieszkania + "', " +
                Constants.PracownikPesel + "='" + pracownik.pesel + "', " +
                Constants.PracownikStanowisko + "='" + pracownik.stanowisko + "', " +
                Constants.PracownikStopien + "=" + stopien + ", " +
                Constants.PracownikTel + "='" + pracownik.numerTelefonu + "', " +
                Constants.PracownikWaznKPP + "=" + KPP + ", " +
                Constants.PracownikMail + "='" + pracownik.mail + "', " +
                Constants.PracownikDataBadan + "='" + pracownik.dataBadan.ToString("yyyy-MM-dd") + "' " +
                "where " + Constants.PracownikID + "='" + pracownik.id_p + "'";
            Update(query);
        }

        public void UpdateUmowa(Umowa umowa)
        {
            string godziny;
            if (umowa.typUmowy == eUmowa.UZ)
                godziny = "null";
            else
                godziny = "'" + umowa.wymiarGodzin + "'";

            string query = "Umowa set " +
                Constants.UmowaTypUmowy + "='" + umowa.typUmowy + "', " +
                Constants.UmowaWymiarGodzin + "="+ godziny +", " +
                Constants.UmowaPoczatekUmowy + "='" + umowa.poczatekUmowy.ToString("yyyy-MM-dd") + "', " +
                Constants.UmowaKoniecUmowy + "='" + umowa.koniecUmowy.ToString("yyyy-MM-dd") + "' " +
                "where " + Constants.UmowaIDu + "='" + umowa.ID_u + "'";
            Update(query);
        }
    }
}
