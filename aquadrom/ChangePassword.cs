using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using System.Net;
using System.Net.Mail;
using Objects;
using aquadrom.Utilities;
using aquadrom.Objects;


namespace aquadrom
{
    public partial class ChangePassword : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector getID = new DBConnector();
        DBConnector polaczenie = new DBConnector();
        Validations walidacja = new Validations();
        Form2 internet = new Form2();
        public static bool exist = false;
        public string getPass = Constants.PracownikHaslo + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string query = "'" + " WHERE " + Constants.PracownikLogin + "='";
        public string getName = Constants.PracownikImie + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getMail = Constants.PracownikMail + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string getSurname = Constants.PracownikNazwisko + " from Pracownik WHERE " + Constants.PracownikLogin + "='";
        public string loginek = "";
        public ChangePassword(string login)
        {
            getPass += login;
            getPass += "'";
            query += login;
            query += "'";
            getName += login;
            getName += "'";
            getMail += login;
            getMail += "'";
            getSurname += login;
            getSurname += "'";
            loginek += login;
            InitializeComponent();
        }

        private void StareHaslo2_TextChanged(object sender, EventArgs e)
        {

        }
        public void changePassword()
        {
            //MessageBox.Show(getPass);
            string query2 = getPass;
            DataTable ids = polaczenie.Select(query2);
            string Pass = ids.Rows[0][0].ToString();//hash hasła w bazie
            if (Pass != Login.sha256_hash(StareHaslo2.Text))
            { 
                MessageBox.Show("Podano złe hasło!");
            }
            else if(Pass == Login.sha256_hash(StareHaslo2.Text))
            {
                string query3 = " Pracownik set " + Constants.PracownikHaslo + "='" +Login.sha256_hash(NoweHaslo2.Text);
                query3 += query;
                DataTable ids2 = polaczenie.Select(getName);
                string name = ids2.Rows[0][0].ToString();
                DataTable ids3 = polaczenie.Select(getSurname);
                string surname = ids3.Rows[0][0].ToString();
                DataTable ids4 = polaczenie.Select(getMail);
                string mail = ids4.Rows[0][0].ToString();
                    if (adapter.Update(query3))
                    {
                        Form2 maile = new Form2();
                        maile.sendMail(loginek, NoweHaslo2.Text, mail, name, surname);
                        MessageBox.Show("Hasło zostało zmienione, sprawdź swoją pocztę!");
                        exist = false;
                        this.Close();
                    }
                    else if (adapter.Update(query3)==false)
                    {
                        MessageBox.Show("Bład!");
                    }
               
            }
        }
        private void ZmianaHasla_Click(object sender, EventArgs e)
        {

            if (NoweHaslo2.Text != PowtorzHaslo2.Text)
            {
                MessageBox.Show("Podane hasła są różne!");
            }
            else if (walidacja.isNullOrNot(StareHaslo2, "Stare hasło") || walidacja.isNullOrNot(NoweHaslo2, "Nowe hasło") ||
                walidacja.isNullOrNot(PowtorzHaslo2, "Powtórz hasło"))
            {
            }
            else if(( internet.CheckInternetConnection()==false))
            {
                MessageBox.Show("Błąd połączenia internetowego!");
            }
            else {
                changePassword();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exist = false;
            this.Close();
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
       
    }
}
