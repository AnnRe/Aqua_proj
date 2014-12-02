using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DB;


namespace aquadrom
{
    public partial class AdminPanel : Form
    {
        DBAdapter adapter = new DBAdapter();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            string sql_workers = "SELECT * FROM Pracownik";
            DataTable dtlista = adapter.GetData(sql_workers);
            dataGridView1.DataSource = dtlista.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DeleteWorker.exist==false)
            {
                DeleteWorker DelWor = new DeleteWorker();
                DelWor.Show();
            }
            Test_Load(this,e);
        }

        private void DodajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrzeglądajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
