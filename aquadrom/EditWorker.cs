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
//            Validations pesel = new Validations(); HOWTO
//            pesel.ValidatePesel("t");
//            MessageBox.Show(sql_edituser);

            DataTable dtlista = connector.Select(sql_edituser); // uzupełnienie danych
            IDUmowyTextBox.Text = TakeValue(dtlista, Constants.UmowaIDu);
            TypUmowyComboBox.Text = TakeValue(dtlista,Constants.UmowaTypUmowy);
            foreach (var item in Enum.GetValues(typeof(eUmowa)))    
            {
                TypUmowyComboBox.Items.Add(item);
                if (TypUmowyComboBox.Text == item.ToString())   // przypisanie domyślnego elementu (if brak zmiany to był null)
                    TypUmowyComboBox.SelectedItem = item;
            }
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

            StopienComboBox.Text = TakeValue(dtlista, Constants.PracownikStopien);
            foreach (var item in Enum.GetValues(typeof(eStopien)))
            {
                StopienComboBox.Items.Add(item);
                if (StopienComboBox.Text == item.ToString())
                    StopienComboBox.SelectedItem = item;
            }

            StanowiskoUseraComboBox.Text = TakeValue(dtlista, Constants.PracownikStanowisko);
            foreach (var item in Enum.GetValues(typeof(eStanowisko)))
            {
                StanowiskoUseraComboBox.Items.Add(item);
                if (StanowiskoUseraComboBox.Text == item.ToString())
                    StanowiskoUseraComboBox.SelectedItem = item;
            }

            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())  // jesli jest KZ'tem to data KPP nie obowiązuje, koniecKPP off
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
            if (StanowiskoUseraComboBox.Text == eStanowisko.KZ.ToString())
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
            DialogResult dialogResult = MessageBox.Show("Na pewno chcesz edytować dane użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if ((EditEmployee() == true) && (EditContract() == true))
                {
                    _mainform.AdminPanel_Load(_mainform, e); // odswiezanie tabeli glownej
                    MessageBox.Show("Edycja zakończona!");
                    exist = false;
                    this.Close();
                }
            }
        }

        private bool EditEmployee()
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
            if (KoniecKPPDateTimePicker.Enabled == false) // jeśli KPP nie wymagane to minvalue (NULL to base)
            {
                pracownik.dataWażnościKPP = DateTime.MinValue;
            }

            if (adapter.Update(pracownik) == false)
            {
                MessageBox.Show("Błąd edycji pracownika!.");
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
                MessageBox.Show("Błąd edycji umowy!.");
                return false;
            }
            else return true;
        }

        private void StopienComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WymiarGodzinNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KoniecKPPDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
