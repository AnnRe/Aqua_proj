using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using aquadrom.Utilities;

namespace aquadrom
{
    public partial class UserPanel : Form
    {
        string login = "";
        DBConnector connector = new DBConnector();
        public UserPanel(string sql)
        {
            InitializeComponent();
            login += sql;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            DataTable dtlist = connector.Select("* from " + Constants.TabPracownik + " p," + Constants.TabUmowa + " u where p." + Constants.PracownikIDUmowy + "=u." + Constants.UmowaIDu + " and p." + Constants.PracownikLogin +"='"+ login+"'");

            ImieUzytkownika.Text = TakeValue(dtlist, Constants.PracownikImie);
            NazwiskoUzytkownika.Text = TakeValue(dtlist, Constants.PracownikNazwisko);
            PeselUzytkownika.Text = TakeValue(dtlist, Constants.PracownikPesel);
            PoczatekUmowyTextBox.Text = TakeDateValue(dtlist, Constants.UmowaPoczatekUmowy).ToString("yyyy-MM-dd");
            KoniecUmowyTextBox.Text = TakeDateValue(dtlist, Constants.UmowaKoniecUmowy).ToString("yyyy-MM-dd");
            if (TakeValue(dtlist, Constants.PracownikWaznKPP).Length <= 1)
                WaznoscKPPTextBox.Text = "";
            else
                WaznoscKPPTextBox.Text = TakeValue(dtlist, Constants.PracownikWaznKPP);
            DataBadanTextBox.Text = TakeDateValue(dtlist, Constants.PracownikDataBadan).ToString("yyyy-MM-dd");
            if (CheckInternetConnection() == false)     // sprawdzanie połączenia internetowego
                PolaczenieStripUser.Text = "Brak połączenia internetowego";
            else
                PolaczenieStripUser.Text = "Połączenie internetowe aktywne";
        }

        private void harmonogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanOpen() == false)
            {
                HarmonogramForm harmonogramF = new HarmonogramForm(false);
                harmonogramF.Show();
            }
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private string TakeValue(DataTable dtlist, string what)
        {
            return dtlist.Rows[0][what].ToString();
        }

        private DateTime TakeDateValue(DataTable dtlist, string what)
        {
            return Convert.ToDateTime(dtlist.Rows[0][what]);
        }

        private void daneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CanOpen() == false)
            {
                ChangePassword change = new ChangePassword(login);
                change.Show();
            }
            
        }

        private bool CheckInternetConnection()
        {
            try{
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                { return true; } }
            catch{ return false;}
        }

        private bool CanOpen()
        {
            if ((HarmonogramForm.exists==false) &&
            (GeneratorNotatek.exist==false) &&
            (ChangePassword.exist==false)
                )
                return false;
            else return true;
        }

        private void notatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CanOpen()==false)
            {
                GeneratorNotatek change = new GeneratorNotatek(login);
                change.Show();
            }
        }

        private void UserPanel_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
