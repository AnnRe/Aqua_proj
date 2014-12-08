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
            // TODO: This line of code loads data into the 'aquadromDataSet.Pracownik' table. You can move, or remove it, as needed.
            this.pracownikTableAdapter.Fill(this.aquadromDataSet.Pracownik);
            int iloscDni = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            DateTime day = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            for (int i = 0; i < iloscDni; i++)
            {
                dataGridView1.Columns.Add(i.ToString(),day.Date.ToString("yyyy-mm-dd"));
                day.AddDays(1);
            }

                // TODO: This line of code loads data into the 'aquadromDataSet.Godziny_pracy' table. You can move, or remove it, as needed.
                this.godziny_pracyTableAdapter.Fill(this.aquadromDataSet.Godziny_pracy);

        }
    }
}
