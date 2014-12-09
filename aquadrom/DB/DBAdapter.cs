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
            catch { return false; }     //?flagi
            return true;
        }

        public bool Delete(string query)
        {
            try { polaczenie.Delete(query); }
            catch { return false; }
            return true;
        }

        public bool Insert(Pracownik pracownik)
        {
            try { polaczenie.Insert(pracownik); }
            catch { return false; }
            return true;
        }
    }
}
