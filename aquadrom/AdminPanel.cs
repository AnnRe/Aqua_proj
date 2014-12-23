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
        DBConnector connector = new DBConnector();
        DBAdapter adapter = new DBAdapter();
        public AdminPanel()
        {
            InitializeComponent();
        }

        public void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aquadromDataSet.Pracownik' table. You can move, or remove it, as needed.
            this.pracownikTableAdapter.Fill(this.aquadromDataSet.Pracownik);
//            dataGridView1.Columns.Add[]
/*            string sql_workers = "SELECT * FROM Pracownik";
            DataTable dtlista = adapter.GetData(sql_workers);
            dataGridView1.DataSource = dtlista.DefaultView; */
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
            if( (DeleteWorker.exist==false) && (EditWorkerWhich.exist==false) )  // jeśli okno DeleteWorker,WhichWorker zamknięte to je otwórz else nic
            {
                DeleteWorker DelWor = new DeleteWorker(this);
                DelWor.Show();
            }
        }

        private void DodajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrzeglądajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test_Load(this, e);
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( (DeleteWorker.exist==false) && (EditWorkerWhich.exist==false) )
            {
                EditWorkerWhich EdWor = new EditWorkerWhich(this);
                EdWor.Show();
            }
        }


    }
}
