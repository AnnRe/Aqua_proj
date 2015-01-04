using aquadrom.Objects;
using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquadrom
{
    public partial class HarmonogramForm : Form
    {

        private bool loadingFromDB;
        private bool valueChanged;
        private bool validated;
        private Harmonogram harmonogram;

        public HarmonogramForm()
        {
            InitializeComponent();
        }

        private void HarmonogramForm_Load(object sender, EventArgs e)
        {
            loadingFromDB = true;
            valueChanged = true;
            validated = false;
            harmonogram = new Harmonogram();

            this.pracownikTableAdapter.Fill(this.aquadromDataSet.Pracownik);
            CreateDayColumns();

            comboBoxMonths.SelectedIndex = DateTime.Now.Month - 1;
            comboBoxYear.SelectedItem = DateTime.Now.Year.ToString();

            loadingFromDB = false;

        }

        private void FillFromDB()
        {
            loadingFromDB = true;
            DBAdapter adapter = new DBAdapter();
            DateTime iDate = new DateTime(GetYearFromCombo(),GetMonthFromCombo() , 1);
            ClearHours();

            for (int nrDnia = 1; nrDnia <= DateTime.DaysInMonth(GetYearFromCombo(),GetMonthFromCombo()); nrDnia++)
            {
                DataTable godziny = adapter.SelectWorkersAtDate(iDate);

                for (int j = 0; j < godziny.Rows.Count; j++)
                {
                    for (int nrWierszaGrid = 0; nrWierszaGrid < dataGridView1.RowCount-1; nrWierszaGrid++)
                    {
                        string[] val = new string[4];
                        val[0] = godziny.Rows[j][0].ToString();
                        val[1] = godziny.Rows[j][1].ToString();
                        val[2] = dataGridView1.Rows[nrWierszaGrid].Cells[0].Value.ToString();
                        val[3] = dataGridView1.Rows[nrWierszaGrid].Cells[1].Value.ToString();
                        if (godziny.Rows[j][0].ToString() == dataGridView1.Rows[nrWierszaGrid].Cells[0].Value.ToString() 
                            && godziny.Rows[j][1].ToString() == dataGridView1.Rows[nrWierszaGrid].Cells[1].Value.ToString())
                        {
                            dataGridView1.Rows[nrWierszaGrid].Cells[nrDnia.ToString() + "od"].Value = godziny.Rows[j][2].ToString();
                            dataGridView1.Rows[nrWierszaGrid].Cells[nrDnia.ToString() + "do"].Value = godziny.Rows[j][3].ToString();
                        }
                    }
                }

                iDate = iDate.AddDays(1);
            }
            loadingFromDB = false;
                                   
        }

        private int GetYearFromCombo()
        {
            return (Convert.ToInt32(comboBoxYear.SelectedIndex.ToString()) >= 0) ? Convert.ToInt32(comboBoxYear.SelectedItem.ToString()) : DateTime.Now.Year;
        }

        private int GetMonthFromCombo()
        {
            return comboBoxMonths.SelectedIndex + 1 > 0 ? comboBoxMonths.SelectedIndex + 1 : DateTime.Now.Month;
        }

        private void ClearHours()
        {
            for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                for (int i = 3; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Rows[j].Cells[i].Value = "";
                
        }
        private void CreateDayColumns()
        {
            //int iloscDni = DateTime.DaysInMonth(DateTime.Now.Year,month);
            DateTime day = new DateTime(DateTime.Now.Year, GetMonthFromCombo(), 1);

            for (int i = 1; i <=  31; i++)
            {
                string xyz = i.ToString() + "od" + "  ,  " + i.ToString() + "do";
                dataGridView1.Columns.Add(i.ToString()+"od", day.ToShortDateString());
                dataGridView1.Columns.Add(i.ToString()+"do", "");
                day = day.AddDays(1);
                DataGridViewColumn column1 = dataGridView1.Columns[i.ToString() + "od"];
                DataGridViewColumn column2 = dataGridView1.Columns[i.ToString() + "do"];
                column1.Width = 70;
                column2.Width = 70;
                column2.DividerWidth = 1;
                dataGridView1.Columns[i.ToString() + "od"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i.ToString() + "do"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 
                
            }

            UpdateColumnsToDate();

            for (int i = 0; i < 3; i++)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.DividerWidth = 1;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void UpdateColumnsToDate()
        {
            int i = 3;
            int DaysToHide;
            MessageBox.Show("months: "+comboBoxMonths.SelectedIndex.ToString()+" year: "+comboBoxYear.SelectedIndex.ToString());
            if (comboBoxMonths.SelectedIndex >= 0)
            {
                DaysToHide = 31 - DateTime.DaysInMonth(DateTime.Now.Year, GetMonthFromCombo());
                for (; i < 65 - DaysToHide * 2; i += 2)
                {
                    dataGridView1.Columns[i].Visible = true;
                    dataGridView1.Columns[i + 1].Visible = true;

                    DateTime oldColumnDate = DateTime.Parse(dataGridView1.Columns[i].HeaderText);
                    DateTime currentDate;
                    if (comboBoxYear.SelectedIndex > 0)
                    {
                        currentDate = new DateTime(GetYearFromCombo(), GetMonthFromCombo(), oldColumnDate.Day);
                    }
                    else
                    {
                        currentDate = new DateTime(oldColumnDate.Year, GetMonthFromCombo(), oldColumnDate.Day);
                    }

                    dataGridView1.Columns[i].HeaderText = currentDate.ToShortDateString();
                }

                for (; i < 65; i++)
                    dataGridView1.Columns[i].Visible = false;
            }
            else if (comboBoxYear.SelectedIndex > 0)
            {
                DaysToHide = 31 - DateTime.DaysInMonth(GetYearFromCombo(), GetMonthFromCombo());
                for (; i < 65 - DaysToHide * 2; i += 2)
                {
                    dataGridView1.Columns[i].Visible = true;
                    dataGridView1.Columns[i + 1].Visible = true;

                    DateTime oldColumnDate = DateTime.Parse(dataGridView1.Columns[i].HeaderText);
                    DateTime currentDate = new DateTime(oldColumnDate.Year, comboBoxMonths.SelectedIndex + 1, oldColumnDate.Day);

                    dataGridView1.Columns[i].HeaderText = currentDate.ToShortDateString();
                }

                for (; i < 65; i++)
                    dataGridView1.Columns[i].Visible = false;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(validated)
                validated = false;
            else
                valueChanged = true;
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!loadingFromDB)
                if (e.ColumnIndex > 2)
                {
                    if (valueChanged)
                    {
                        validated = true;
                        DateTime dateValue;
                        dataGridView1[0, e.RowIndex].Tag = "";

                        if (DateTime.TryParse(e.FormattedValue.ToString(), out dateValue))
                        {
                            DateTime godz = new DateTime(dateValue.Year, dateValue.Month, dateValue.Day, 8, 0, 0);
                            DateTime godz2 = godz.AddHours(14);
                            
                            if (dateValue.CompareTo(godz) >= 0 && dateValue.CompareTo(godz.AddHours(14)) <= 0)
                            {
                                if (secoundTimeIsReady(e.ColumnIndex, e.RowIndex))
                                {
                                    e.Cancel = hoursAreCorrect(e.ColumnIndex, e.RowIndex, e.FormattedValue.ToString());
                                    if (e.Cancel)
                                    {
                                        dataGridView1[e.ColumnIndex, e.RowIndex].ErrorText = "Błędna godzina!";//TODO: wyświetlić błąd
                                        MessageBox.Show("Błędna godzina - Konflikt między godziną początku i końca pracy!");
                                    }
                                    else
                                    {
                                        dataGridView1[e.ColumnIndex, e.RowIndex].ErrorText = "";
                                        dataGridView1[0, e.RowIndex].Tag = "Gotowe";
                                    }
                                }
                                dateValue = GetColumnDate(dateValue, e);
                            }
                            else
                            {
                                e.Cancel=true;
                                dataGridView1[e.ColumnIndex,e.RowIndex].ErrorText="Błędna godzina";//TODO
                                MessageBox.Show("Błędna godzina - pracujemy 8-22!");
                            }
                        }
                        else
                            if (e.FormattedValue.ToString().Length > 0)
                            {
                                dataGridView1[ e.ColumnIndex,e.RowIndex].ErrorText = "Zły format!";
                                e.Cancel = true;
                            }
                        valueChanged = true;
                    }

                }
        }
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 2 && !loadingFromDB)
            {
                if (dayCompleted(e.ColumnIndex, e.RowIndex))
                    MessageBox.Show("ok");
            }

        }

        private bool hoursAreCorrect(int columnIndex, int rowIndex, string currentHour)
        {
             DateTime startTime, stopTime;
             if (columnIndex % 2 == 1)//od
             {
                 startTime = DateTime.Parse(currentHour);
                 stopTime = DateTime.Parse(dataGridView1[columnIndex + 1, rowIndex].Value.ToString());
             }
             else//do
             {
                 startTime = DateTime.Parse(dataGridView1[columnIndex - 1, rowIndex].Value.ToString());
                 stopTime = DateTime.Parse(currentHour);
             }

             MessageBox.Show("od: " + startTime.ToShortTimeString() + " do: " + stopTime.ToShortTimeString());
             return (stopTime < startTime);
        }
        private bool dayCompleted(int columnIndex, int rowIndex)
        {
            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;
            MessageBox.Show(dataGridView1[start, rowIndex].Value.ToString() + "  " + dataGridView1[start + 1, rowIndex].Value.ToString());
            if (dataGridView1[start, rowIndex].Value.ToString().Length > 2 && dataGridView1[start + 1, rowIndex].Value.ToString().Length > 2)
                return true;
            else
                return false;
        }
        private bool secoundTimeIsReady(int columnIndex, int rowIndex)
        {
            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;
            if (columnIndex == start)
                return dataGridView1[columnIndex + 1, rowIndex].Value.ToString().Length > 2;
            else
                return dataGridView1[start, rowIndex].Value.ToString().Length > 2;
        }

        private DateTime GetColumnDate(DateTime dateValue, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex + (e.ColumnIndex % 2 - 1)].HeaderText;

            DateTime columnDate;
            DateTime.TryParse(columnName, out columnDate);
            //MessageBox.Show("col: " + columnName + "  " + columnDate.ToString());

            DateTime newDate = new DateTime(columnDate.Year, columnDate.Month, columnDate.Day, dateValue.Hour, dateValue.Minute, dateValue.Second);
            //MessageBox.Show(newDate.ToString());
            return newDate;

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("year changed, loading:"+loadingFromDB.ToString());
            UpdateColumnsToDate();
            FillFromDB();
        }
        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateColumnsToDate();
            FillFromDB();
        }

    }
}
