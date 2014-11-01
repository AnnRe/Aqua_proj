using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;

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
                    
                    int colIndex = reader.GetOrdinal(Constants.PracownikImieKol);
                    pracownik.imie = reader.IsDBNull(colIndex) ?
                                   string.Empty :
                                   reader.GetString(colIndex);

                    colIndex = reader.GetOrdinal(Constants.PracownikNazwiskoKol);
                    pracownik.nazwisko = reader.IsDBNull(colIndex) ?
                                   string.Empty :
                                   reader.GetString(colIndex);

                    colIndex = reader.GetOrdinal(Constants.PracownikWaznKPPKol);
                    pracownik.dataWażnościKPP = reader.IsDBNull(colIndex) ?
                                   DateTime.Now :
                                   reader.GetDateTime(colIndex);

                    colIndex = reader.GetOrdinal(Constants.PracownikDataBadanKol);
                    pracownik.dataBadan = reader.IsDBNull(colIndex) ?
                                   DateTime.Now :
                                   reader.GetDateTime(colIndex);
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
            string queryText = "Insert " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);
        }

        public SqlDataAdapter getAdapter(string query)
        {
            return new SqlDataAdapter(query,polaczenie);
        }
    }
}
