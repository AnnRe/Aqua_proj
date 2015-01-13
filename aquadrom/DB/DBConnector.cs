using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;
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

        public List<Pracownik> SelectPracownicy(string query)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();
            string queryText = "Select " + query;
            using (SqlCommand cmdsel = new SqlCommand(queryText, polaczenie))
            {
                SqlDataReader reader = cmdsel.ExecuteReader();
                while (reader.Read())
                {
                    Pracownik pracownik = new Pracownik();
                    
                    //int colIndex = reader.GetOrdinal(Constants.PracownikImieKol);
                    //pracownik.imie = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.imie = GetString(Constants.PracownikImieKol, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikNazwiskoKol);
                    //pracownik.nazwisko = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.nazwisko = GetString(Constants.PracownikNazwiskoKol, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikMailKol);
                    //pracownik.mail = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.mail = GetString(Constants.PracownikMailKol, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikMiastoKol);
                    //pracownik.miasto = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);

                    //colIndex = reader.GetOrdinal(Constants.PracownikUlicaKol);
                    pracownik.ulica = GetString(Constants.PracownikUlicaKol,reader);
                        //reader.IsDBNull(colIndex) ?
                        //           string.Empty :
                        //           reader.GetString(colIndex);

                    //colIndex = reader.GetOrdinal(Constants.PracownikPeselKol);
                    //pracownik.pesel = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.pesel = GetString(Constants.PracownikPeselKol, reader);

                    //colIndex = reader.GetOrdinal(Constants.PracownikWaznKPPKol);
                    //pracownik.dataWażnościKPP = reader.IsDBNull(colIndex) ?
                    //               DateTime.Now :
                    //               reader.GetDateTime(colIndex);
                    pracownik.dataWażnościKPP = GetDateTime(Constants.PracownikWaznKPPKol, reader);

                    //colIndex = reader.GetOrdinal(Constants.PracownikDataBadanKol);
                    //pracownik.dataBadan = reader.IsDBNull(colIndex) ?
                    //               DateTime.Now :
                    //               reader.GetDateTime(colIndex);
                    pracownik.dataBadan = GetDateTime(Constants.PracownikDataBadanKol, reader);
                    
                   // colIndex=reader.GetOrdinal(Constants.)
                    //TODO: dokończyć wczytywanie kolumn
                    pracownicy.Add(pracownik);

                }
                var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
                reader.Close();
            }
            return pracownicy;
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
            string query = "Pracownik (" +
               Constants.PracownikImieKol + "," +
               Constants.PracownikNazwiskoKol + "," +
               Constants.PracownikMiastoKol + "," +
               Constants.PracownikUlicaKol + "," +
               Constants.PracownikNrDomKol + "," +
               Constants.PracownikNrMieszkaniaKol + "," +
               Constants.PracownikPeselKol + "," +
               Constants.PracownikStanowiskoKol + "," +
               Constants.PracownikStopienKol + "," +
               Constants.PracownikTelKol + "," +
               Constants.PracownikWaznKPPKol + "," +
               Constants.PracownikMailKol + "," +
               Constants.PracownikDataBadanKol + "," +
               Constants.PracownikLoginKol + "," +
               Constants.PracownikHasloKol ;
 //              Constants.PracownikIDUmowyKol + "," +
 //              Constants.PracownikTypKontaKol;
            query += ") VALUES ('";
            query += pracownik.imie + "','" +
                pracownik.nazwisko + "','" +
                pracownik.miasto + "','" +
                pracownik.ulica + "','" +
                pracownik.numerDomu + "','" +
                pracownik.numerMieszkania + "','" +
                pracownik.pesel + "','" +
                pracownik.stanowisko + "','" +
                pracownik.stopien + "','" +
                pracownik.numerTelefonu + "','" +
                pracownik.dataWażnościKPP + "','" +
                pracownik.mail + "','" +
                pracownik.dataBadan + "','" +
                pracownik.login + "','" +
                pracownik.haslo + "',')";
 //               pracownik.idUmowy + "','" +
 //               pracownik.typKonta + "')";

            Insert(query);
        }

        public void UpdatePracownik(Pracownik pracownik)
        {
            string query = "Pracownik set " +
                Constants.PracownikImieKol + "='" + pracownik.imie + "', "+
                Constants.PracownikNazwiskoKol + "='" + pracownik.nazwisko + "', " +
                Constants.PracownikMiastoKol + "='" + pracownik.miasto + "', " +
                Constants.PracownikUlicaKol + "='" + pracownik.ulica + "', " +
                Constants.PracownikNrDomKol + "='" + pracownik.numerDomu + "', " +
                Constants.PracownikNrMieszkaniaKol + "='" + pracownik.numerMieszkania + "', " +
                Constants.PracownikPeselKol + "='" + pracownik.pesel + "', " +
                Constants.PracownikStanowiskoKol + "='" + pracownik.stanowisko + "', " +
                Constants.PracownikStopienKol + "='" + pracownik.stopien + "', " +
                Constants.PracownikTelKol + "='" + pracownik.numerTelefonu + "', " +
                Constants.PracownikWaznKPPKol + "='" + pracownik.dataWażnościKPP.ToString("yyyy-MM-dd") + "', " +
                Constants.PracownikMailKol + "='" + pracownik.mail + "', " +
                Constants.PracownikDataBadanKol + "='" + pracownik.dataBadan.ToString("yyyy-MM-dd") + "' " +
                "where " + Constants.PracownikIDpKol + "='" + pracownik.id_p + "'";
              System.Windows.Forms.MessageBox.Show(query);
                Update(query);
        }

        public void UpdateUmowa(Umowa umowa)
        {
            string query = "Umowa set " +
                Constants.UmowaTyp + "='" + umowa.Typ + "', " +
                Constants.UmowaWymiarGodzin + "='" + umowa.Wymiar_godzin + "', " +
                Constants.UmowaPoczatekUmowy + "='" + umowa.Poczatek_umowy.ToString("yyyy-MM-dd") + "', " +
                Constants.UmowaKoniecUmowy + "='" + umowa.Koniec_umowy.ToString("yyyy-MM-dd") + "' " +
                "where " + Constants.UmowaIDu + "='" + umowa.ID_u + "'";
                          System.Windows.Forms.MessageBox.Show(query);
            //Update(query);
        }
    }
}
