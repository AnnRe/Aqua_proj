using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;
using DB;
using aquadrom.Utilities;
using System.Windows.Forms;

namespace aquadrom.Objects
{
    public class Harmonogram
    {
        private DataGridView dataGridView1;

        public Harmonogram(DataGridView dataGridView)
        {
            dataGridView1 = dataGridView;
        }

        public void Add(Pracownik pracownik, DateTime pocz, DateTime koniec)
        {
            DBAdapter polaczenie = new DBAdapter();
            string query = "into " + Constants.TabGodzinyPracy + "(" + Constants.GodzinyPracyOd + "," + Constants.GodzinyPracyDo + "," +
                Constants.GodzinyPracyIdP+") values ("+
                pocz.Date.ToString("yyyy-MM-dd HH:mm:ss")+","+koniec.Date.ToString("yyyy-MM-dd HH:mm:ss")+","+pracownik.id_p+")";
            polaczenie.Insert(query);
           
        }

        /// <summary>
        /// Sprawdza, czy w każdym momencie jest wystarczająca ilość pracowników oraz czy są KZ/KSR
        /// </summary>
        /// <returns></returns>
        private bool PoprawnieRozplanowanyDzien(DateTime day)
        {
            DateTime t = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            DateTime endOfDay = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59);
            for (; t < endOfDay; t.AddMinutes(15))
            {
                if (!StanowiskaObsadzone(t) || !PracownicyMajaOdpowiednieGodziny(t))
                    return false;
            
            }
                //TODO: sprawdzenie po godzinie, 
                //TODO: sprawdzenie KZ,KSR
                return true;
        }

        /// <summary>
        /// Sprawdza czy pracownicy mają wypełnioną pulę godzin
        /// </summary>
        /// <returns></returns>
        private bool PracownicyMajaOdpowiednieGodziny(DateTime time)
        {
            DBAdapter polaczenie = new DBAdapter();
          //  string query="SELECT * from pracownik where "+const
            //var pracownicyDataTable=polaczenie.GetData()
            return true;
        }

        private bool StanowiskaObsadzone(DateTime time)
        {

            return true;
 
        }

        public bool CorrectFormat(string value)
        {
            DateTime dateValue;
            if (DateTime.TryParse(value, out dateValue))
            {
                return true;
            }
            else
                return false;
        }

        private void SetCurrentCellTags(int columnIndex, int rowIndex)
        {
            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;
            if (dataGridView1[start, rowIndex].Value == null || dataGridView1[start, rowIndex].Value.ToString() == "")
            {//pierwszy pusty
                if (dataGridView1[start + 1, rowIndex].Value == null || dataGridView1[start + 1, rowIndex].Value.ToString() == "")
                {//oba puste
                    dataGridView1[2, rowIndex].Tag = "";
                    dataGridView1[start + 1, rowIndex].Value = "";
                    dataGridView1[start, rowIndex].Value = "";
                }
                else
                {
                    dataGridView1[2, rowIndex].Tag = "Prawie";
                    dataGridView1[start, rowIndex].Value = "";
                }
            }
            else if (dataGridView1[start + 1, rowIndex].Value == null || dataGridView1[start + 1, rowIndex].Value.ToString() == "")
            { //drugi pusty, pierwszy nie
                dataGridView1[2, rowIndex].Tag = "Prawie";
                dataGridView1[start + 1, rowIndex].Value = "";
            }
            else
            { //wypełnione
                dataGridView1[2, rowIndex].Tag = "Gotowe";
            }
        }

        public string Save()
        {
            SetAllTags();
            bool saveSucceed = true;
            bool partialDataAppear = false;
            for (int row_i = 0; row_i < dataGridView1.RowCount-1; row_i++)
            {
                if (dataGridView1[2, row_i].Tag.ToString() != "")
                {
                    string imie = dataGridView1[0, row_i].Value.ToString();
                    string nazwisko = dataGridView1[1, row_i].Value.ToString();

                    for (int col_i = 3; col_i < dataGridView1.ColumnCount; col_i += 2)
                    {
                        if (dataGridView1[col_i, row_i].Visible)
                        {
                            if (bothTimesAreReady(col_i,row_i))
                            {
                                DateTime StartTimeToSave = GetColumnDate(col_i, row_i);
                                DateTime StopTimeToSave = GetColumnDate(col_i + 1, row_i);

                                DBAdapter adapter = new DBAdapter();
                                if (!adapter.UpdateHour(imie, nazwisko, StartTimeToSave, StopTimeToSave))
                                    saveSucceed = false;
                            }
                            else if (onlyOneTimesAreReady(col_i,row_i))
                            {
                                partialDataAppear = true;
                            }
                        }
                    }
                }
            }
            if (saveSucceed && !partialDataAppear)
                return "Zapisano pomyślnie";
            else if (partialDataAppear)
                return "Godziny pracy, które nie posiadają rozpoczęcia lub zakończenia nie zostaną zapisane";
            else
                return "Błąd podczas zapisywania";
    
        }

        private DateTime GetColumnDate(int columnIndex, int rowIndex)
        {
            string columnName = dataGridView1.Columns[columnIndex + (columnIndex % 2 - 1)].HeaderText;
            DateTime cellHour;
            DateTime.TryParse(dataGridView1[columnIndex, rowIndex].Value.ToString(), out cellHour);

            return GetColumnDate(cellHour, columnIndex);
        }
        /// <summary>
        /// Returns the Date and time using date from selected column and hour from given variable
        /// </summary>
        /// <param name="oldDate">Used to get info about the hour</param>
        /// <param name="columnIndex">Column which from get the date</param>
        /// <returns></returns>
        private DateTime GetColumnDate(DateTime oldDate, int columnIndex)
        {
            string columnName = dataGridView1.Columns[columnIndex + (columnIndex % 2 - 1)].HeaderText;
            DateTime columnDate;
            DateTime.TryParse(columnName, out columnDate);
            DateTime newDate = new DateTime(columnDate.Year, columnDate.Month, columnDate.Day, oldDate.Hour, oldDate.Minute, oldDate.Second);
            return newDate;
        }
        

        public bool bothTimesAreReady(int columnIndex,int rowIndex)
        {
            
            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;

            if (dataGridView1[start, rowIndex].Value == null || dataGridView1[start, rowIndex].Value.ToString() == "")
            {//pierwsza pusta
                if(dataGridView1[start + 1, rowIndex].Value != null && dataGridView1[start + 1, rowIndex].Value.ToString() != "")
                {//druga niepusta
                    dataGridView1[2, rowIndex].Tag = "Prawie";
                    return false;
                }
                else
                {//i druga też pusta
                    dataGridView1[2, rowIndex].Tag = "";
                    return false;
                }
            }
            else if (dataGridView1[start + 1, rowIndex].Value == null || dataGridView1[start + 1, rowIndex].Value.ToString() == "")
            {//druga pusta, ale pierwsza nie
                dataGridView1[2, rowIndex].Tag = "Prawie";
                return false;
            }
            dataGridView1[2, rowIndex].Tag = "Gotowe";
            return true;
        }

        public bool onlyOneTimesAreReady(int columnIndex, int rowIndex)
        {
            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;

            if (dataGridView1[start, rowIndex].Value == null || dataGridView1[start, rowIndex].Value.ToString() == "")
                return (dataGridView1[start + 1, rowIndex].Value != null && dataGridView1[start + 1, rowIndex].Value.ToString() != "");
            else
                return (dataGridView1[start + 1, rowIndex].Value == null || dataGridView1[start + 1, rowIndex].Value.ToString() == "");
        }

        private void SetAllTags()
        {
            for (int row_i = 0; row_i < dataGridView1.RowCount; row_i++)
                for (int col_i = 3; col_i < dataGridView1.ColumnCount; col_i+=2)
                {
                    if (dataGridView1[col_i, row_i].Value == null || dataGridView1[col_i, row_i].Value.ToString() == "")
                    {//pierwsza pusta
                        if (dataGridView1[col_i + 1, row_i].Value != null && dataGridView1[col_i + 1, row_i].Value.ToString() != "")
                        {//druga niepusta
                            dataGridView1[2, row_i].Tag = "Prawie";
                        }
                        else
                        {//i druga też pusta
                            dataGridView1[2, row_i].Tag = "";
                        }
                    }
                    else if (dataGridView1[col_i + 1, row_i].Value == null || dataGridView1[col_i + 1, row_i].Value.ToString() == "")
                    {//druga pusta, ale pierwsza nie
                        dataGridView1[2, row_i].Tag = "Prawie";
                    }
                    dataGridView1[2, row_i].Tag = "Gotowe";
                }
            
        }
    }
}
