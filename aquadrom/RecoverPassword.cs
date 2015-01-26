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
using Objects;
using aquadrom.Utilities;
using aquadrom.Objects;


namespace aquadrom
{
    public partial class RecoverPassword : Form
    {
        public static bool exist = false;
        DBAdapter adapter = new DBAdapter();
        DBConnector getID = new DBConnector();
        DBConnector polaczenie = new DBConnector();
        Validations walidacja = new Validations();
        Validations blokady = new Validations();
        Form2 internet = new Form2();

        public RecoverPassword()
        {
            InitializeComponent();
        }

        public void newPassword()
        {
            Form2 newPass = new Form2();
            string Password = newPass.createPassword(10);
            string updatePass = " Pracownik set " + Constants.PracownikHaslo + "='" + Password+"'"+" WHERE ";
            string updatePass2 = Constants.PracownikLogin + "='" +loginZapomniany.Text+ "'";
            string updatePass3 = updatePass + updatePass2;


            string getMail = Constants.PracownikMail + " from Pracownik WHERE " + Constants.PracownikLogin + "='" + loginZapomniany.Text + "'";
            string getName = Constants.PracownikImie + " from Pracownik WHERE " + Constants.PracownikLogin + "='" + loginZapomniany.Text + "'";
            string getSurname = Constants.PracownikNazwisko + " from Pracownik WHERE " + Constants.PracownikLogin + "='" + loginZapomniany.Text + "'";
            DataTable ids = polaczenie.Select(getMail);
            string mejl = ids.Rows[0][0].ToString();
            DataTable ids2 = polaczenie.Select(getName);
            string name = ids2.Rows[0][0].ToString();
            DataTable ids3 = polaczenie.Select(getSurname);
            string surname = ids3.Rows[0][0].ToString();


            if (mejl == mailZapomniany.Text)
            {
                if (adapter.Update(updatePass3))
                {
                    Form2 maile = new Form2();
                    maile.sendMail(loginZapomniany.Text, Password, mailZapomniany.Text, name, surname);
                    MessageBox.Show("Nowe hasło zostało wygenerowane, sprawdź swoją pocztę!");
                }
                else if (adapter.Update(updatePass3) == false)
                {
                    MessageBox.Show("Błąd!");
                }
            }
            

        }

        private void RecoverPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); ;
        }

        private void Anulujprzy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getMail = Constants.PracownikMail + " from Pracownik WHERE " + Constants.PracownikLogin + "='" + loginZapomniany.Text + "'";
            DataTable ids = polaczenie.Select(getMail);
            string mejl = ids.Rows[0][0].ToString();

            if (walidacja.isNullOrNot(loginZapomniany, "Login") || walidacja.isNullOrNot(mailZapomniany, "E-mail"))
            {
            }
            else if (walidacja.ValidateMail(mailZapomniany.Text) == false)
            {
                MessageBox.Show("Zły format adresu e-mail!");
            }
            else if (mejl != mailZapomniany.Text)
            {
                MessageBox.Show("Zły adres e-mail!");
            }
            else if ((internet.CheckInternetConnection() == false))
            {
                MessageBox.Show("Błąd połączenia internetowego!");
            }
            else
            {
                newPassword();
            }
        }

        private void loginZapomniany_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginZapomniany_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLitery(e);
        }
    }
}
