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
        private string PoprawnieRozplanowanyDzien(DateTime day)
        {
            string messageStanowiska = stanowiskaObsadzone(day);
            if (pracownicyMajaOdpowiednieGodziny(day))
                if (messageStanowiska.Length == 0)
                    return "";
                else
                    return messageStanowiska;
            else
                return "Pracownicy nie mają odpowiedniej ilości godzin";
                //TODO: sprawdzenie po godzinie, 
                //TODO: sprawdzenie KZ,KSR
        }

        /// <summary>
        /// Sprawdza czy pracownicy mają wypełnioną pulę godzin
        /// </summary>
        /// <returns></returns>
        private bool pracownicyMajaOdpowiednieGodziny(DateTime time)
        {
            DBAdapter polaczenie = new DBAdapter();
          //  string query="SELECT * from pracownik where "+const
            //var pracownicyDataTable=polaczenie.GetData()
            return true;
        }
        public string poprawnieRozplanowanyMiesiac(DateTime time)
        {
            DateTime time_i=new DateTime(time.Year,time.Month,1,0,0,0);
            while (time_i.CompareTo(new DateTime(time.Year, time.Month, DateTime.DaysInMonth(time.Year, time.Month), 0, 0, 0))<=0)
            {
                string message = PoprawnieRozplanowanyDzien(time_i);
                if (message.Length > 0)
                    return message;
            }
            return "";
        }

        /// <summary>
        /// Ilość miejsc na basenie do obsadzenia
        /// </summary>
        /// <returns></returns>
        private int GetNeededWorkersAmount(DateTime time)
        {
            DBAdapter adapter = new DBAdapter();
            int val=adapter.GetPositionNumberAtStates(time);
            return 21;//TODO
        }
        /// <summary>
        /// Sprawdza, czy stanowiska są obsadzone danego dnia
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private string stanowiskaObsadzone(DateTime time)
        {
            DateTime time_i = new DateTime(time.Year, time.Month, time.Day, Constants.PoczatekPracy, 0, 0);
            int neededWorkers = GetNeededWorkersAmount(time_i);
            while (time_i.Hour < 22)
            {
                //for (int row_i = 0; row_i < dataGridView1.RowCount - 1; row_i++)
                int numberOfWorkersAtTime=GetNumberOfWorkersAtTime(time_i);
                    if (numberOfWorkersAtTime < neededWorkers)
                    {
                        int dif=neededWorkers-numberOfWorkersAtTime;
                        return "\n Za mało pracowników (o "+dif+") o godzinie "+ time_i.ToString("HH:mm");
                    }
                    else
                        if (!KZPresentAtTime(time_i))
                            return "Brak KZ";

                        //return false;
                time_i = time_i.AddMinutes(15);
                neededWorkers = GetNeededWorkersAmount(time_i);
            }
            return "";
        }
        private int GetNumberOfWorkersAtTime(DateTime time)
        {
            int numberOfWorkers = 0;
            int col_i=2*Convert.ToInt32( time.Month.ToString())+1;
            for (int row_i = 0; row_i < dataGridView1.RowCount-1; row_i++)
            {
                if (time.CompareTo(GetCellDateTime(col_i, row_i)) >= 0 && time.CompareTo(GetCellDateTime(col_i + 1, row_i)) <= 0)
                    numberOfWorkers++;
            }
            return numberOfWorkers;
        }
        private bool KZPresentAtTime(DateTime time)
        {
            int col_i=2*Convert.ToInt32( time.Month.ToString())+1;
            for (int row_i = 0; row_i < dataGridView1.RowCount-1; row_i++)
            {
                if (time.CompareTo(GetCellDateTime(col_i, row_i)) >= 0 && time.CompareTo(GetCellDateTime(col_i + 1, row_i)) <= 0)
                    if (dataGridView1[2, row_i].Value.ToString() =="KZ" )
                        return true;
            }
            return false;
        }

        public bool CorrectCellFormat(string value)
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

            return GetCellHourAtDate(cellHour, columnIndex);
        }
        /// <summary>
        /// Returns the Date and time using date from selected column and hour from given variable
        /// </summary>
        /// <param name="oldDate">Used to get info about the hour</param>
        /// <param name="columnIndex">Column which from get the date</param>
        /// <returns></returns>
        private DateTime GetCellHourAtDate(DateTime oldDate, int columnIndex)
        {
            string columnName = dataGridView1.Columns[columnIndex + (columnIndex % 2 - 1)].HeaderText;
            DateTime columnDate;
            DateTime.TryParse(columnName, out columnDate);
            DateTime newDate = new DateTime(columnDate.Year, columnDate.Month, columnDate.Day, oldDate.Hour, oldDate.Minute, oldDate.Second);
            return newDate;
        }
        private DateTime GetCellDateTime(int columnIndex, int rowIndex)
        {
            DateTime toReturn = GetColumnDate(columnIndex, rowIndex);
            toReturn = GetCellHourAtDate(toReturn, columnIndex);
            return toReturn;
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

        public string ValidateCell(DataGridViewCellValidatingEventArgs e)
        {
            DateTime dateValue;

            if (DateTime.TryParse(e.FormattedValue.ToString(), out dateValue))
            {
                DateTime godz = new DateTime(dateValue.Year, dateValue.Month, dateValue.Day, 8, 0, 0);
                DateTime godz2 = godz.AddHours(14);

                if (dateValue.CompareTo(godz) >= 0 && dateValue.CompareTo(godz.AddHours(14)) <= 0)
                {
                    if (Convert.ToInt32(dateValue.Minute.ToString()) % 15 != 0)
                        return "Czas podajemy co 15min";
                }
                else
                {
                    return "Błędna godzina - pracujemy 8-22!";
                }
            }
            else
                if (e.FormattedValue.ToString().Length > 0)
                {
                    return "Zły format";
                }
            return "";
        }
        
    }
}
