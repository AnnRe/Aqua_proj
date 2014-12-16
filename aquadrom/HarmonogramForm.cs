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
            listBoxMiesiace.SetSelected(DateTime.Now.Month-1,true);
            FillFromDB(DateTime.Now);

                // TODO: This line of code loads data into the 'aquadromDataSet.Godziny_pracy' table. You can move, or remove it, as needed.
                this.godziny_pracyTableAdapter.Fill(this.aquadromDataSet.Godziny_pracy);

        }

        private void FillFromDB(DateTime date)
        {
            //Select od do from godziny pracy where id_p =...
            DBAdapter adapter = new DBAdapter();
            DateTime iDate = new DateTime(date.Year, date.Month, 1);

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
                    
            }
        }

        private void listBoxMiesiace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
