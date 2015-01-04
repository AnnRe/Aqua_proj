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
                    pracownik.imie = GetString(Constants.PracownikImie, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikNazwiskoKol);
                    //pracownik.nazwisko = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.nazwisko = GetString(Constants.PracownikNazwisko, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikMailKol);
                    //pracownik.mail = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.mail = GetString(Constants.PracownikMail, reader);
                    //colIndex = reader.GetOrdinal(Constants.PracownikMiastoKol);
                    //pracownik.miasto = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);

                    //colIndex = reader.GetOrdinal(Constants.PracownikUlicaKol);
                    pracownik.ulica = GetString(Constants.PracownikUlica,reader);
                        //reader.IsDBNull(colIndex) ?
                        //           string.Empty :
                        //           reader.GetString(colIndex);

                    //colIndex = reader.GetOrdinal(Constants.PracownikPeselKol);
                    //pracownik.pesel = reader.IsDBNull(colIndex) ?
                    //               string.Empty :
                    //               reader.GetString(colIndex);
                    pracownik.pesel = GetString(Constants.PracownikPesel, reader);

                    //colIndex = reader.GetOrdinal(Constants.PracownikWaznKPPKol);
                    //pracownik.dataWażnościKPP = reader.IsDBNull(colIndex) ?
                    //               DateTime.Now :
                    //               reader.GetDateTime(colIndex);
                    pracownik.dataWażnościKPP = GetDateTime(Constants.PracownikWaznKPP, reader);

                    //colIndex = reader.GetOrdinal(Constants.PracownikDataBadanKol);
                    //pracownik.dataBadan = reader.IsDBNull(colIndex) ?
                    //               DateTime.Now :
                    //               reader.GetDateTime(colIndex);
                    pracownik.dataBadan = GetDateTime(Constants.PracownikDataBadan, reader);
                    
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
               Constants.PracownikImie + "," +
               Constants.PracownikNazwisko + "," +
               Constants.PracownikMiasto + "," +
               Constants.PracownikUlica + "," +
               Constants.PracownikNrDom + "," +
               Constants.PracownikNrMieszkania + "," +
               Constants.PracownikPesel + "," +
               Constants.PracownikStanowisko + "," +
               Constants.PracownikStopienBadan + "," +
               Constants.PracownikTel + "," +
               Constants.PracownikWaznKPP + "," +
               Constants.PracownikMail + "," +
               Constants.PracownikDataBadan;
            query += ") VALUES (";
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

            Insert(query);
        }
    }
}
