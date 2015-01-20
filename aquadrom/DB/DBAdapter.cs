using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using Objects;
using aquadrom.Objects;
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
       
        public bool Select(string query)
        {
            try { polaczenie.Select(query); }
            catch { return false; }
            return true;
        }
        public DataTable SelectWorkersAtTime(DateTime time)
        {
            polaczenie.Open();
            string query = "Select " + Constants.PracownikImie + "," + Constants.PracownikNazwisko + " from pracownik,godziny_pracy where ("
                + Constants.PracownikID + "=" + Constants.GodzinyPracyIdP +
                " and "
                + time.Date.ToString("yyyy-MM-dd HH:mm:ss") + " between " + Constants.GodzinyPracyOd + " and " + Constants.GodzinyPracyDo + ")";
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
            string query = "Select " + Constants.PracownikImie + "," + Constants.PracownikNazwisko + ", " +
                "CONVERT(VARCHAR(5), " + Constants.GodzinyPracyOd + ",108) as 'OD', " +
                "CONVERT(VARCHAR(5), " + Constants.GodzinyPracyDo + ",108) as 'DO' " +
               " from pracownik,godziny_pracy where ("
                + Constants.PracownikID + "=" + Constants.GodzinyPracyIdP +
                " and "
                + Constants.GodzinyPracyOd + " between '" + odTime.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + doTime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            DataTable toRet = new DataTable();

            try { toRet = GetData(query); }
            catch (Exception e)
            { Console.WriteLine(e.Message); }


            return toRet;
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
        public bool Insert(string query)
        {
            try { polaczenie.Insert(query); }
            catch { return false; }
            return true;
        }

        public bool Update(string query)
        {
            try { polaczenie.Update(query); }
            catch
            {
                return false;
            }
            return true;
        }
        public bool Update(Pracownik pracownik)
        {
            try { polaczenie.UpdatePracownik(pracownik); }
            catch { return false; }
            return true;
        }
        public bool Insert(Umowa umowa)
        {
            try { polaczenie.Insert(umowa); }
            catch { return false; }
            return true;
        }

        public bool Update(Umowa umowa)
        {
            try { polaczenie.UpdateUmowa(umowa); }
            catch { return false; } return true;
        }
        public bool UpdateHour(string imie, string nazwisko, DateTime startTimeToSave, DateTime stopTimeToSave)
        {
            int iD = GetUserId(imie, nazwisko);
            if (hourExistsForWorkerInDB(imie, nazwisko, startTimeToSave))
            {
                string query = Constants.TabGodzinyPracy + " SET " + Constants.GodzinyPracyOd + "= '" + startTimeToSave.ToString("yyyy-MM-dd HH:mm:ss") + "'," + Constants.GodzinyPracyDo +
                   "= '" + stopTimeToSave.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE " + Constants.GodzinyPracyIdP + " = " + iD;
                try { polaczenie.Update(query); }
                catch (Exception) { return false; }

            }
            else
            {

                string query = Constants.TabGodzinyPracy + "(" + Constants.GodzinyPracyOd + "," + Constants.GodzinyPracyDo + "," + Constants.GodzinyPracyIdP + ")"
                    + " VALUES ('" + startTimeToSave.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + stopTimeToSave.ToString("yyyy-MM-dd HH:mm:ss") + "'," + iD + ")";

                try { polaczenie.Insert(query); }
                catch (Exception) { return false; }
            }

            return true;

        }

        private bool hourExistsForWorkerInDB(string imie, string nazwisko, DateTime time)
        {
            string query = "* from " + Constants.TabGodzinyPracy + "," + Constants.TabPracownik + " WHERE " +
                Constants.GodzinyPracyIdP + "=" + Constants.PracownikID + " AND " + "CONVERT(VARCHAR(10)," +
                Constants.GodzinyPracyOd + " ,105) = '" + time.ToString("dd-MM-yyyy") + "'" + " AND " + Constants.PracownikImie + " = '" + imie +
                "' AND " + Constants.PracownikNazwisko + "= '" + nazwisko + "'";

            DataTable tab = polaczenie.Select(query);

            return tab.Rows.Count > 0;
        }

        private int GetUserId(string imie, string nazwisko)
        {
            string query = Constants.PracownikID + " from " + Constants.TabPracownik + " where (" + Constants.PracownikImie + "= '" + imie + "' AND " + Constants.PracownikNazwisko + " = '" + nazwisko +"')";
            DataTable ids = polaczenie.Select(query);
            if(ids.Rows.Count>0)
            {
                string ID=ids.Rows[0][0].ToString();
                return Convert.ToInt32(ID);
            }
            else
                return 0;
        }

        public int GetPositionNumberAtStates(DateTime time)
        {
            string query = " sum(" + Constants.StanowiskoLiczbaPracownikow + ") FROM " + Constants.TabStanowisko + ", " + Constants.TabOtwarcieStanowiska +
                
                " WHERE " + Constants.StanowiskoID + "=" + Constants.OtwarcieStanowiskaIDStanowiska + " AND ('" + time.ToString("HH:mm:ss") + "' BETWEEN " + Constants.OtwarcieStanowiskaOd + " AND " +
                Constants.OtwarcieStanowiskaDo + ")";
            DataTable result = polaczenie.Select(query);
            //TODO: porównanie tylko godzin (nie dat)
            
            string il=result.Rows[0].ItemArray[0].ToString();
            return il==""?0:Convert.ToInt32(il);
        }
        public string GetUserContractType(string imie, string nazwisko)
        {
            int Id = GetUserId(imie, nazwisko);
            string query = "select "+Constants.UmowaTyp+" from "+Constants.TabPracownik+", "+Constants.TabUmowa+" where ("+Constants.PracownikID+" = "+Id+" AND "+Constants.PracownikIDUmowy
                +"="+Constants.UmowaIDu+")";
            DataTable tab = GetData(query);
            if (tab.Rows.Count > 0)
                return tab.Rows[0].ItemArray[0].ToString();
            return "";
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
