using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using aquadrom.Utilities;
using DB;
using Objects;
using aquadrom.Objects;

namespace aquadrom
{
    public partial class EditWorker : Form
    {
        DBConnector connector = new DBConnector();
        DBAdapter adapter = new DBAdapter();
        Validations valid = new Validations();

        private AdminPanel _mainform = null;
        public static bool exist = false;
        private string sql_edituser = "* from " + Constants.TabPracownik + " p, " + Constants.TabUmowa + " u where p." + Constants.PracownikIDUmowy + "=u." + Constants.UmowaIDu + " and " + Constants.PracownikID + "=";
        private string id_user = "";
        public EditWorker(Form callingForm, string id_user)
        {
            InitializeComponent();
            exist = true;
            this.id_user = id_user;
            sql_edituser += id_user;
            _mainform = callingForm as AdminPanel;
        }

        private void EditWorker_Load(object sender, EventArgs e)
        {
            DataTable dtlista = connector.Select(sql_edituser); // uzupełnienie danych
            IDUmowyTextBox.Text = TakeValue(dtlista, Constants.UmowaIDu);
            
            foreach (var item in Enum.GetValues(typeof(eUmowa)))
            {
                TypUmowyComboBox.Items.Add(item);
                if (TypUmowyComboBox.Text == item.ToString())   // przypisanie domyślnego elementu (if brak zmiany to był null)
                    TypUmowyComboBox.SelectedItem = item;
            }
            TypUmowyComboBox.Text = TakeValue(dtlista,Constants.UmowaTypUmowy);

            if (TypUmowyComboBox.Text == eUmowa.UZ.ToString())  // jesli umowa zlecenie to wymiar godzin = 0, ComboBox off
            {
                WymiarGodzinNumericUpDown.ReadOnly = true;
                WymiarGodzinNumericUpDown.Maximum = 0;
                WymiarGodzinNumericUpDown.Value = 0;
            }
            else WymiarGodzinNumericUpDown.Value = Convert.ToDecimal(TakeValue(dtlista,Constants.UmowaWymiarGodzin));  // else pobierz wartosc

            IDUseraTextBox.Text = id_user;
            PoczatekUmowyDateTimePicker.Text = TakeValue(dtlista, Constants.UmowaPoczatekUmowy);
            KoniecUmowyDateTimePicker.Text = TakeValue(dtlista, Constants.UmowaKoniecUmowy);
            NumerTelefonuTextBox.Text = TakeValue(dtlista, Constants.PracownikTel);
            AdresEmailTextBox.Text = TakeValue(dtlista, Constants.PracownikMail);
            LoginUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikLogin);
            ImieUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikImie);
            NazwiskoUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikNazwisko);
            PeselUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikPesel);;
            MiastoUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikMiasto);
            UlicaUseraTextBox.Text = TakeValue(dtlista, Constants.PracownikUlica);
            NumerDomuTextBox.Text = TakeValue(dtlista, Constants.PracownikNrDom);

            if(TakeValue(dtlista, Constants.PracownikNrMieszkania).Length > 0)  // jesli jest numer mieszkania pobierz wartosc
                NumerMieszkaniaNumericUpDown.Value = Convert.ToDecimal(TakeValue(dtlista, Constants.PracownikNrMieszkania));

            foreach (var item in Enum.GetValues(typeof(eStopien)))
            {
                StopienComboBox.Items.Add(item);
                if (StopienComboBox.Text == item.ToString())
                    StopienComboBox.SelectedItem = item;
            }

            StopienComboBox.Text = TakeValue(dtlista, Constants.PracownikStopien);

            if (StopienComboBox.Text == "")
            {
                StopienComboBox.Text = eStopien.RW.ToString();
            }


            foreach (var item in Enum.GetValues(typeof(eStanowisko)))
            {
                StanowiskoUseraComboBox.Items.Add(item);
                if (StanowiskoUseraComboBox.Text == item.ToString())
                    StanowiskoUseraComboBox.SelectedItem = item;
            }

            StanowiskoUseraComboBox.Text = TakeValue(dtlista, Constants.PracownikStanowisko);

            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())  // jesli jest KZ'tem to data KPP i stopień nie obowiązuje - OFF
            {
                KoniecKPPDateTimePicker.Enabled = false;
                StopienComboBox.Enabled = false;
            }
            else if (TakeValue(dtlista, Constants.PracownikWaznKPP) != "")   // else jeśli nie jest pusta wartość w bazie to pobierz
                KoniecKPPDateTimePicker.Text = TakeValue(dtlista, Constants.PracownikWaznKPP);

            DataBadanDateTimePicker.Text = TakeValue(dtlista, Constants.PracownikDataBadan);
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
            if (TypUmowyComboBox.Text == eUmowa.UZ.ToString())  // gdy zmiana typu umowy na zlecenie zeruj liczbę godzin, NumericUpDown off
            {
                WymiarGodzinNumericUpDown.ReadOnly = true;
                WymiarGodzinNumericUpDown.Maximum = 0;
                WymiarGodzinNumericUpDown.Value = 0;
            }
            else
            {       // else włącz, max godzin 160
                WymiarGodzinNumericUpDown.ReadOnly = false;
                WymiarGodzinNumericUpDown.Maximum = 160;
                WymiarGodzinNumericUpDown.Minimum = 1;
            }
        }

        private void StanowiskoUseraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())  // wyłączenie obowiązywania KPP i Stopnia gdy KZ
            {
                KoniecKPPDateTimePicker.Enabled = false;
                StopienComboBox.Enabled = false;
            }
            else
            {
                KoniecKPPDateTimePicker.Enabled = true;
                StopienComboBox.Enabled = true;
            }
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
            DialogResult dialogResult = MyMessageBox.ShowBox("Na pewno chcesz edytować dane użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes && // jeśli wybrano tak oraz jest poprawny pesel, mail i numer
                valid.ValidatePesel(PeselUseraTextBox.Text) && 
                valid.ValidateMail(AdresEmailTextBox.Text) && 
                valid.ValidateNumber(NumerTelefonuTextBox.Text))
            {
                if ((EditEmployee() == true) && (EditContract() == true))   // edytuj użytkownika i jego umowę
                {
                    _mainform.AdminPanel_Load(_mainform, e); // odswiezanie tabeli glownej
                    MyMessageBox.ShowBox("Edycja zakończona!");
                    exist = false;
                    this.Close();
                }
            }
            else if (valid.ValidateMail(AdresEmailTextBox.Text) == false)
                MyMessageBox.ShowBox("Zły format adresu e-mail!");
            else if (valid.ValidatePesel(PeselUseraTextBox.Text) == false)
                MyMessageBox.ShowBox("Zły format numeru PESEL!");
            else if (valid.ValidateNumber(NumerTelefonuTextBox.Text) == false)
                MyMessageBox.ShowBox("Zły format numeru telefonu!");
        }

        private bool EditEmployee()
        {
            Pracownik pracownik = new Pracownik(
                Convert.ToInt32(IDUseraTextBox.Text),
                valid.ResztaZnakowNaMale(ImieUseraTextBox.Text),
                valid.PoMyslnikuLubSpacji(NazwiskoUseraTextBox.Text,"-", CultureInfo.InvariantCulture),
                PeselUseraTextBox.Text,
                valid.PoMyslnikuLubSpacji(MiastoUseraTextBox.Text, "- ", CultureInfo.InvariantCulture),
                valid.PoMyslnikuLubSpacji(UlicaUseraTextBox.Text, "- ", CultureInfo.InvariantCulture),
                NumerDomuTextBox.Text,
                NumerMieszkaniaNumericUpDown.Text,
                NumerTelefonuTextBox.Text,
                AdresEmailTextBox.Text,
                ((eStopien)Enum.Parse(typeof(eStopien), StopienComboBox.SelectedItem.ToString())),
                (eStanowisko)Enum.Parse(typeof(eStanowisko), StanowiskoUseraComboBox.SelectedItem.ToString()),
                DateTime.Parse(KoniecKPPDateTimePicker.Text),
                DateTime.Parse(DataBadanDateTimePicker.Text)
                );

            if (KoniecKPPDateTimePicker.Enabled == false) // jeśli KPP nie wymagane to minvalue (NULL to base)
            {
                pracownik.dataWażnościKPP = DateTime.MinValue;
            }

            if (adapter.Update(pracownik) == false)
            {
                MyMessageBox.ShowBox("Błąd edycji pracownika!.");
                return false;
            }
            else return true;
        }

        private bool EditContract()
        {
            Umowa umowa = new Umowa(
                Convert.ToInt32(IDUmowyTextBox.Text),
                (eUmowa)Enum.Parse(typeof(eUmowa), TypUmowyComboBox.Text),
                WymiarGodzinNumericUpDown.Text,
                DateTime.Parse(PoczatekUmowyDateTimePicker.Text),
                DateTime.Parse(KoniecUmowyDateTimePicker.Text)
                );

            if (adapter.Update(umowa) == false)
            {
                MyMessageBox.ShowBox("Błąd edycji umowy!.");
                return false;
            }
            else return true;
        }

        private void ImieUseraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoLitery(e);
        }

        private void NazwiskoUseraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoLiteryMyslnik(e);
        }

        private void PeselUseraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoCyfry(e);
        }

        private void MiastoUseraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoLiteryMyslnikSpacja(e);
        }

        private void UlicaUseraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoLiteryMyslnikSpacja(e);
        }

        private void NumerDomuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoCyfryLitery(e);
        }

        private void NumerTelefonuTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.tylkoCyfryPlus(e);
        }

        private void AdresEmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void NumerDomuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PoczatekUmowyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (PoczatekUmowyDateTimePicker.Value>KoniecUmowyDateTimePicker.Value)
                KoniecUmowyDateTimePicker.Value =PoczatekUmowyDateTimePicker.Value;
        }

        private void KoniecUmowyDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (PoczatekUmowyDateTimePicker.Value > KoniecUmowyDateTimePicker.Value)
                KoniecUmowyDateTimePicker.Value = PoczatekUmowyDateTimePicker.Value;
        }
    }
}
