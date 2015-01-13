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
using System.Security.Cryptography;

namespace aquadrom
{
    public partial class Login : Form
    {
        //public static string login, haslo;
        private static bool ZgodaNaLogowanie = false;
        private static bool FindBase = false;
       // SqlConnection connection;
        AdminPanel AdminPanel = new AdminPanel();
        DBAdapter adapter = new DBAdapter();
        
        public Login()
        {
            InitializeComponent();


        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }
            return Sb.ToString();
        }

        private bool CheckBase()
        {
            DBConnector con = new DBConnector();
            try{ con.Open(); }
            catch{ return false;}
            con.Close();
            return true;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckBase() == false)
            {
                MessageBox.Show("Baza danych nie odnaleziona. \nSkontaktuj się z administratorem.");
                this.Close();
            }
            string sql_testLogin = "SELECT Login, Haslo, Typ_konta FROM Pracownik";            
            DataTable dtUserLogin = adapter.GetData(sql_testLogin);
            foreach (DataRow row in dtUserLogin.Rows)
            {
                if (true) /*row[Constants.PracownikLogin].ToString() == this.UserNameBox.Text )&& row[Constants.PracownikHaslo].ToString() ==/* sha256_hash(this.UserPasswordBox.Text))*/
                {
                    ZgodaNaLogowanie = true;
                    if (row[Constants.PracownikTypKonta].ToString().ToUpper()=="A")
                    {
                        AdminPanel AdminPanel = new AdminPanel();
                        AdminPanel.Show();

                    }
                    if (row[Constants.PracownikTypKonta].ToString().ToUpper()=="U")
                    {
                        UserPanel UserPanel = new UserPanel();
                        UserPanel.Show();
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
                MessageBox.Show(sha256_hash(this.UserPasswordBox.Text));
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

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
