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
            FillFromDB();

                // TODO: This line of code loads data into the 'aquadromDataSet.Godziny_pracy' table. You can move, or remove it, as needed.
                this.godziny_pracyTableAdapter.Fill(this.aquadromDataSet.Godziny_pracy);

        }

        private void FillFromDB()
        {
            //Select od do from godziny pracy where id_p =...
            throw new NotImplementedException();
        }

        private void AddDayColumns()
        {
            int iloscDni = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            DateTime day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            for (int i = 0; i < 2 * iloscDni; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView1.Columns.Add(i.ToString(), day.ToShortDateString());

                    day = day.AddDays(1);
                }
                else
                    dataGridView1.Columns.Add(i.ToString(), "");
            }
        }
    }
}
