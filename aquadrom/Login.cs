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
using aquadrom.Objects;

namespace aquadrom
{
    public partial class Login : Form
    {
        //public static string login, haslo;
        private static bool AllowToLog = false;
        DBAdapter adapter = new DBAdapter();
        
        public Login()
        {
            InitializeComponent();
        }

        public static String sha256_hash(String value)  //funkcja hashujaca haslo
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

        private bool CheckBase()    // sprawdzenie połączenia z bazą
        {
            DBConnector con = new DBConnector();
            try{ con.Open(); }
            catch{ return false;}
            con.Close();
            return true;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CheckBase() == false)   // if brak bazy, pokaż info i zamknij
            {
                MyMessageBox.ShowBox("Baza danych nie została odnaleziona. \nSkontaktuj się z administratorem.");
                this.Close();

            }
            else
            {
                string sql_testLogin = "SELECT " + Constants.PracownikLogin + "," + Constants.PracownikHaslo + "," + Constants.PracownikTypKonta + " FROM " + Constants.TabPracownik;
                DataTable dtUserLogin = adapter.GetData(sql_testLogin);
                foreach (DataRow row in dtUserLogin.Rows)
                {
                    if (true) /*row[Constants.PracownikLogin].ToString() == this.UserNameBox.Text )&& row[Constants.PracownikHaslo].ToString() ==/* sha256_hash(this.UserPasswordBox.Text))*/
                    {
                        AllowToLog = true;
                        if (row[Constants.PracownikTypKonta].ToString().ToUpper() == "A") // if znaleziono login i poprawne hasło to otwórz odpowiednie okno
                        {
                            //UserPanel UserPanel = new UserPanel();
                            //UserPanel.Show();
                            AdminPanel AdminPanel = new AdminPanel(UserNameBox.Text);
                            AdminPanel.Show();

                        }
                        if (row[Constants.PracownikTypKonta].ToString().ToUpper() == "U")
                        {
                           //UserPanel UserPanel = new UserPanel();
                           //UserPanel.Show();
                            AdminPanel AdminPanel = new AdminPanel(UserNameBox.Text);
                           AdminPanel.Show();
                        }
                        break;
                    }
                }
            }
            if (AllowToLog)
            {
                this.Hide();
            }
            else
            {
                MyMessageBox.ShowBox("Nieprawidłowy login lub hasło.");
            }
        }

        private void UserNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    // obsługa entera
            {
                LoginButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void UserPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)     // obsługa entera
            {
                LoginButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
