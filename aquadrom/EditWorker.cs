using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aquadrom.Utilities;
using DB;
using Objects;

namespace aquadrom
{
    public partial class EditWorker : Form
    {
        DBConnector connector = new DBConnector();
        DBAdapter adapter = new DBAdapter();

        private AdminPanel _mainform = null;
        public static bool exist = false;
        private string sql_edituser = "* from " + Constants.TabPracownik + " p, " + Constants.TabUmowa + " u where p." + Constants.PracownikIDUmowyKol + "=u." + Constants.UmowaIDu + " and " + Constants.PracownikIDpKol + "=";
        private string id_user = "";
        public EditWorker(Form callingForm, string id_user)
        {
            InitializeComponent();
            exist = true;
            this.id_user = id_user;
            sql_edituser += id_user;
            _mainform = callingForm as AdminPanel;
        }

        public void UZCheck()
        {
            if (TypUmowyComboBox.Text == Convert.ToString(eUmowa.UZ));

        }
        private void EditWorker_Load(object sender, EventArgs e)
        {
//            MessageBox.Show(sql_edituser);
            DataTable dtlista;
            dtlista = connector.Select(sql_edituser);

            IDUmowyTextBox.Text = TakeValue(dtlista, Constants.UmowaIDu);
            TypUmowyComboBox.Text = TakeValue(dtlista,Constants.UmowaTyp);
            foreach (var item in Enum.GetValues(typeof(eUmowa)))    
            {
                TypUmowyComboBox.Items.Add(item);
                if (TypUmowyComboBox.Text == item.ToString())
                    TypUmowyComboBox.SelectedItem = item;
            }

            if (TypUmowyComboBox.Text == eUmowa.UZ.ToString())  // jesli umowa zlecenie to wymiar godzin = 0, ComboBox off
            {
                WymiarGodzinNumericUpDown.ReadOnly = true;
                WymiarGodzinNumericUpDown.Maximum = 0;
                WymiarGodzinNumericUpDown.Value = 0;
            }
            else WymiarGodzinNumericUpDown.Value = Convert.ToDecimal(dtlista.Rows[0][Constants.UmowaWymiarGodzin].ToString());  // else pobierz wartosc

            IDUseraTextBox.Text = id_user;
            PoczatekUmowyDateTimePicker.Text = TakeValue(dtlista, Constants.UmowaPoczatekUmowy);
            KoniecUmowyDateTimePicker.Text = TakeValue(dtlista, Constants.UmowaKoniecUmowy);
            NumerTelefonuTextBox.Text = TakeValue(dtlista, Constants.PracownikTelKol);
            AdresEmailTextBox.Text = TakeValue(dtlista, Constants.PracownikMailKol);
            LoginUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikLoginKol);
            HasloUzytkownikaTextBox.Text = "to delete?";
            ImieUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikImieKol);
            NazwiskoUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikNazwiskoKol);
            PeselUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikPeselKol);;
            MiastoUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikMiastoKol);
            UlicaUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikUlicaKol);
            NumerDomuTextBox.Text = TakeValue(dtlista, Constants.PracownikNrDomKol);

            if(TakeValue(dtlista, Constants.PracownikNrMieszkaniaKol)!="")  // jesli jest numer mieszkania pobierz wartosc
                NumerMieszkaniaNumericUpDown.Value = Convert.ToDecimal(TakeValue(dtlista, Constants.PracownikNrMieszkaniaKol));

            StopienComboBox.Text = TakeValue(dtlista, Constants.PracownikStopienKol);
            foreach (var item in Enum.GetValues(typeof(eStopien)))
            {
                StopienComboBox.Items.Add(item);
                if (StopienComboBox.Text == item.ToString())
                    StopienComboBox.SelectedItem = item;
            }

            StanowiskoUseraComboBox.Text = TakeValue(dtlista, Constants.PracownikStanowiskoKol);
            foreach (var item in Enum.GetValues(typeof(eStanowisko)))
            {
                StanowiskoUseraComboBox.Items.Add(item);
                if (StanowiskoUseraComboBox.Text == item.ToString())
                    StanowiskoUseraComboBox.SelectedItem = item;
            }

            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())  // jesli jest KZ'tem to data KPP nie obowiazuje, koniecKPP off
            {
                KoniecKPPDateTimePicker.Enabled = false;
            }
            else if (TakeValue(dtlista, Constants.PracownikWaznKPPKol) != "")   // else jesli nie jest pusta wartosc w bazie to pobierz
                KoniecKPPDateTimePicker.Text = TakeValue(dtlista, Constants.PracownikWaznKPPKol);

            DataBadanDateTimePicker.Text = TakeValue(dtlista, Constants.PracownikDataBadanKol);
        }

        private void EditWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void AnulujButton_Click(object sender, EventArgs e)
        {
            this.Close();
            exist = false;
        }

        private void TypUmowyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypUmowyComboBox.Text == eUmowa.UZ.ToString())  // gdy zmiana typu umowy na zlecenie zeruj liczbe godzin, NumericUpDown off
            {
                WymiarGodzinNumericUpDown.ReadOnly = true;
                WymiarGodzinNumericUpDown.Maximum = 0;
                WymiarGodzinNumericUpDown.Value = 0;
            }
            else
            {       // else wlacz, max godzin 160
                WymiarGodzinNumericUpDown.ReadOnly = false;
                WymiarGodzinNumericUpDown.Maximum = 160;
            }
        }

        private void KoniecKPPDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StanowiskoUseraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())
                KoniecKPPDateTimePicker.Enabled = false;
            else
                KoniecKPPDateTimePicker.Enabled = true;
        }

        private string TakeValue(DataTable dtlist, string what)
        {
            return dtlist.Rows[0][what].ToString();
        }

        private void EditWorker_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void EdytujUseraButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Na pewno chcesz edytować dane użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EditEmployee();
                EditContract();
                _mainform.AdminPanel_Load(_mainform, e); // odswiezanie tabeli glownej
                MessageBox.Show("Edycja zakończona!");

                exist = false;
                this.Close();
            }
            
        }

        private void EditEmployee()
        {
            Pracownik pracownik = new Pracownik(
                Convert.ToInt32(IDUseraTextBox.Text),
                ImieUseraTextBox.Text,
                NazwiskoUseraTextBox.Text,
                PeselUseraTextBox.Text,
                MiastoUseraTextBox.Text,
                UlicaUseraTextBox.Text,
                NumerDomuTextBox.Text,
                NumerMieszkaniaNumericUpDown.Text,
                NumerTelefonuTextBox.Text,
                AdresEmailTextBox.Text,
                ((eStopien)Enum.Parse(typeof(eStopien), StopienComboBox.SelectedItem.ToString())),
                (eStanowisko)Enum.Parse(typeof(eStanowisko), StanowiskoUseraComboBox.SelectedItem.ToString()),
                DateTime.Parse(KoniecKPPDateTimePicker.Text),
                DateTime.Parse(DataBadanDateTimePicker.Text)
                );

            adapter.Update(pracownik);
            if (adapter.Update(pracownik) == false)
                MessageBox.Show("Błąd edycji pracownika!.");
        }

        private void EditContract()
        {
            Umowa umowa = new Umowa(
                Convert.ToInt32(IDUmowyTextBox.Text),
                (eUmowa)Enum.Parse(typeof(eUmowa), TypUmowyComboBox.Text),
                WymiarGodzinNumericUpDown.Text,
                DateTime.Parse(PoczatekUmowyDateTimePicker.Text),
                DateTime.Parse(KoniecUmowyDateTimePicker.Text)
                );

            adapter.Update(umowa);
            if (adapter.Update(umowa) == false)
                MessageBox.Show("Błąd edycji umowy!.");
        }

        private void StopienComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
