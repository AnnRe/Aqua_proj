using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
