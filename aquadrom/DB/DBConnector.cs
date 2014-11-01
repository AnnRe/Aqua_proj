using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Select(string query)
        {
            string queryText = "Select " + query;
            SqlCommand cmdsel = new SqlCommand(queryText, polaczenie);

        }
    }
}
