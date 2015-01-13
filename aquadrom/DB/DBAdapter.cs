using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;
using System.Windows.Forms;

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
            try{adapter.Fill(dataTable);}
            catch (Exception)
            {
                return dataTable;
            }
            polaczenie.Close();
            return dataTable;
        }

        public bool Insert(string query)
        {
           
            try {  polaczenie.Insert(query);  }
            catch { return false; }     
            return true;
        }

        public bool Select(string query)
        {

            try { polaczenie.Select(query); }
            catch { return false; }
            return true;
        }


        public bool Delete(string query)
        {
            try { polaczenie.Delete(query); }
            catch { return false; }
            return true;
        }

        public bool Update(string query)
        {
            try { polaczenie.Update(query); }
            catch { return false; }
            return true;
        }

        public bool Insert(Pracownik pracownik)
        {
            try { polaczenie.Insert(pracownik); }
            catch { return false; }
            return true;
        }

        public bool Update(Pracownik pracownik)
        {
            try { polaczenie.UpdatePracownik(pracownik); }
            catch { return false; }
            return true;
        }

        public bool Update(Umowa umowa)
        {
            try { polaczenie.UpdateUmowa(umowa); }
            catch { return false; }         return true;
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

        public DataTable SelectWorkersAtDate(DateTime time)
        {
            DateTime odTime = new DateTime(time.Year, time.Month, time.Day, 8, 0, 0);
            DateTime doTime = new DateTime(time.Year, time.Month, time.Day, 22, 0, 0);
            string query = "Select " + Constants.PracownikImieKol + "," + Constants.PracownikNazwiskoKol + ", "+
                "CONVERT(VARCHAR(5), "+Constants.GodzinyPracyOd+",108) as 'OD', "+
                "CONVERT(VARCHAR(5), " + Constants.GodzinyPracyDo + ",108) as 'DO' " +
               " from pracownik,godziny_pracy where ("
                + Constants.PracownikIDpKol + "=" + Constants.GodzinyPracyIdP +
                " and "
                + Constants.GodzinyPracyOd+ " between '" + odTime.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + doTime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            DataTable toRet = new DataTable();

            try { toRet = GetData(query);  }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
            

            return toRet;
        }

        public void LockButton(ComboBox WhatEmpty, Button WhatLock)
        {
            if (WhatEmpty.Text == "")
                WhatLock.Enabled = false;
            else
                WhatLock.Enabled = true;
        }
    }
}
