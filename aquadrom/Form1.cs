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
    public partial class Form1 : Form
    {
        SqlConnection polaczenie;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = aquadrom.Properties.Settings.Default.AquadromConnectionString;
            polaczenie.Open();
           
            string sql = "SELECT * FROM Pracownik";
            SqlCommand cmdsel = new SqlCommand(sql, polaczenie);
            //DataTable dt3 = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(sql, polaczenie);
            DBAdapter adapter = new DBAdapter();
            DataTable table = adapter.GetData(sql);
            //da.Fill(dt3);

            //dataGridView1.DataSource = dt3.DefaultView;
            dataGridView1.DataSource = table.DefaultView;
          
        }
    }
}
