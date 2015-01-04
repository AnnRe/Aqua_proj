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
using aquadrom.Utilities;


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

        public void AdminPanel_Load(object sender, EventArgs e)
        {
            DataTable dtlista = connector.Select("* from "+Constants.TabPracownik+" p,"+Constants.TabUmowa+" u where p."+Constants.PracownikIDUmowy+"=u."+Constants.UmowaIDu);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtlista.Columns.Remove(Constants.UmowaIDu);
            dtlista.Columns.Remove(Constants.PracownikIDUmowy);
            dtlista.Columns.Remove(Constants.PracownikHaslo);
            dataGridView1.DataSource = dtlista.DefaultView;

 /*           foreach (DataGridView row in dataGridView1.Rows)
            {
                MessageBox.Show();
            }*/
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PrzeglądajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel_Load(this, e);
        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( (DeleteWorker.exist==false) && (EditWorkerWhich.exist==false) )
            {
                EditWorkerWhich EdWor = new EditWorkerWhich(this);
                EdWor.Show();
            }
        }

        private void CheckUserAccount()
        {
            
        }
    }
}
