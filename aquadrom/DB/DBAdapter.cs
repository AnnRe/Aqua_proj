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
        ~DBAdapter()
        {
            polaczenie.Close();
        }
        public void Open()
        {
            polaczenie.Open();
        }

        public void Close()
        {
            polaczenie.Close();
        }

        public DataTable GetData(string query)
        {
            polaczenie.Open();
            DataTable dataTable = new DataTable();
            adapter = polaczenie.getAdapter(query); 
            adapter.Fill(dataTable);
            polaczenie.Close();
            return dataTable;
        }

        public bool Insert(string query)
        {
            
            try {  polaczenie.Insert(query);  }
            catch { return false; }
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
            catch {
                return false; 
            }
            return true;
        }

        public DataTable SelectWorkersAtTime(DateTime time)
        {
            polaczenie.Open();
            string query = "Select " + Constants.PracownikImieKol + "," + Constants.PracownikNazwiskoKol + " from pracownik,godziny_pracy where ("
                + Constants.PracownikIDpKol + "=" + Constants.GodzinyPracyIdP +
                " and "
                + time.Date.ToString("yyyy-MM-dd HH:mm:ss") + " between " + Constants.GodzinyPracyOd + " and " + Constants.GodzinyPracyDo+")";
            DataTable toRet = new DataTable();
            try { toRet = GetData(query); }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            polaczenie.Close();

            return toRet;
        }
    }
}
