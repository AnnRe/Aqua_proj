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
        SqlConnection polaczenie;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = aquadrom.Properties.Settings.Default.AquadromConnectionString;
            polaczenie.Open();
            string sql = "SELECT * FROM Pracownik";
            DataTable dt3 = new DataTable();
            dt3.Clear();

            try
            {
                SqlCommand cmdsel = new SqlCommand(sql, polaczenie);
                SqlDataAdapter da = new SqlDataAdapter(sql, polaczenie);
                da.Fill(dt3);
                dataGridView1.DataSource = dt3.DefaultView;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Błąd :" + ex.Message);
            }
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
        }

        private void DodajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
