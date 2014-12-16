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
            FillFromDB(DateTime.Now);//Todo: czas w zależności od aktualnie wyśqietlanego harmonogramu

                // TODO: This line of code loads data into the 'aquadromDataSet.Godziny_pracy' table. You can move, or remove it, as needed.
                this.godziny_pracyTableAdapter.Fill(this.aquadromDataSet.Godziny_pracy);

        }

        private void FillFromDB(DateTime date)
        {
            //Select od do from godziny pracy where id_p =...
            DBAdapter adapter = new DBAdapter();
            DateTime iDate = new DateTime(date.Year, date.Month, 1);

            for (int i = 1; i <= DateTime.DaysInMonth(date.Year,date.Month); i++)
            {
                DataTable godziny = adapter.SelectWorkersAtDate(iDate);

                for (int j = 0; j < godziny.Rows.Count; j++)
                {
                    for (int k = 0; k < dataGridView1.RowCount; k++)
                    {
                        if (godziny.Rows[j][1] == dataGridView1.Rows[k].Cells[1] && godziny.Rows[j][2] == dataGridView1.Rows[k].Cells[2])
                        {
                            string odText = godziny.Rows[j][3].ToString() +godziny.Rows[j][4].ToString();
                            dataGridView1.Rows[k].Cells[j.ToString() + "od"].Value =odText;

                            string doText = godziny.Rows[j][5].ToString() + godziny.Rows[j][6].ToString();
                            dataGridView1.Rows[k].Cells[j.ToString() + "do"].Value =doText;
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

            for (int i = 0; i < 2 * iloscDni; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Columns.Add(i.ToString()+"od", day.ToShortDateString());

                    day = day.AddDays(1);
                }
                else
                    dataGridView1.Columns.Add(i.ToString()+"do", "");
            }
        }
    }
}
