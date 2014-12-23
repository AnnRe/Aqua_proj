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
        public HarmonogramForm()
        {
            InitializeComponent();
        }

        private void HarmonogramForm_Load(object sender, EventArgs e)
        {
            this.pracownikTableAdapter.Fill(this.aquadromDataSet.Pracownik);

            AddDayColumns();
            FillFromDB(DateTime.Now);

                // TODO: This line of code loads data into the 'aquadromDataSet.Godziny_pracy' table. You can move, or remove it, as needed.
                this.godziny_pracyTableAdapter.Fill(this.aquadromDataSet.Godziny_pracy);
           
            comboBoxMiesiace.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void FillFromDB(DateTime date)
        {
            //Select od do from godziny pracy where id_p =...
            DBAdapter adapter = new DBAdapter();
            DateTime iDate = new DateTime(date.Year, date.Month, 1);
            ClearHours();
            for (int nrDnia = 1; nrDnia <= DateTime.DaysInMonth(date.Year,date.Month); nrDnia++)
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
                                   
        }

        private void ClearHours()
        {
            for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                for (int i = 2; i < dataGridView1.ColumnCount; i++)
                    dataGridView1.Rows[j].Cells[i].Value = "";
                
        }
        private void AddDayColumns()
        {
            int iloscDni = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            DateTime day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            for (int i = 1; i <=  iloscDni; i++)
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
            for (int i = 0; i < 3; i++)
            {
                DataGridViewColumn column = dataGridView1.Columns[i];
                column.DividerWidth = 1;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxMiesiace_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillFromDB(new DateTime(DateTime.Now.Year, comboBoxMiesiace.SelectedIndex + 1, 1));
        }



    }
}
