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
    public partial class Login : Form
    {
        public static string login, haslo;
        private static bool ZgodaNaLogowanie = false;
        SqlConnection connection;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection();
            connection.ConnectionString = aquadrom.Properties.Settings.Default.AquadromConnectionString;
            connection.Open();

            string sql_testLogin = "SELECT Login, Haslo FROM Pracownik";

            SqlCommand select = new SqlCommand(sql_testLogin, connection);
            SqlDataAdapter da2 = new SqlDataAdapter(select);
            DataTable dtCustomers = new DataTable();
            da2.Fill(dtCustomers);
            foreach (DataRow row in dtCustomers.Rows)
            {
                if (row["Login"].ToString() == this.UserNameBox.Text && row["Haslo"].ToString() == this.UserPasswordBox.Text)
                {
                    ZgodaNaLogowanie = true;
                    if (this.UserNameBox.Text == "admin")
                    {
                        Test TestPanel = new Test();
                        TestPanel.Show();
                    }
                    else
                    {
                        Test TestPanel = new Test();
                        TestPanel.Show();
                    }
                    break;
                }
            }
            if (ZgodaNaLogowanie)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy login lub hasło.");
            }
        }

        private void UserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void UserPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
