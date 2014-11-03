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
    public partial class Test : Form
    {
        SqlConnection polaczenie;
       public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            MessageBox.Show("TEST");
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = aquadrom.Properties.Settings.Default.AquadromConnectionString;
            polaczenie.Open();
            string sql = "SELECT * FROM Pracownik";
            DataTable dt3 = new DataTable();

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
            //DBAdapter adapter = new DBAdapter();
            //DataTable table = adapter.GetData(sql);
            //dataGridView1.DataSource = table.DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
