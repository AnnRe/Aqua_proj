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
using System.Text.RegularExpressions;
using System.Globalization;


namespace aquadrom
{
    public partial class Form2 : Form
    {
        DBAdapter adapter = new DBAdapter();
        public static bool exist = false;
        Validations blokady = new Validations();

        public Form2()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(eStanowisko)))
            {
                StanowiskoUzytkownika.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(eStopien)))
            {
                Stopień.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(eUmowa)))
            {
                TypUmowy.Items.Add(item);

            }

            foreach (var item in Enum.GetValues(typeof(eTypKonta)))
            {
                TypKonta2.Items.Add(item);

            }

            StanowiskoUzytkownika.SelectedIndex = 0;
            Stopień.SelectedIndex = 1;
            TypUmowy.SelectedIndex = 1;
            TypKonta2.SelectedIndex = 0;

            exist = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_Contract()
        {
            Umowa umowa = new Umowa()
            {
                typUmowy = (eUmowa)Enum.Parse(typeof(eUmowa), TypUmowy.SelectedItem.ToString()),
                wymiarGodzin = WymiarGodzin.Text,
                poczatekUmowy = DateTime.Parse(PoczatekUmowy.Text),
                koniecUmowy = DateTime.Parse(KoniecUmowy.Text)

            };
            adapter.Insert(umowa);
            if (adapter.Insert(umowa) == false)
            {
                MessageBox.Show("Umowa została zapisana w bazie.");
            }
            else if (adapter.Insert(umowa) == true)
            {
                MessageBox.Show("Błąd!");
            }
        }
        private void Add_Employer()
        {
            Validations walidacja = new Validations();

            Pracownik pracownik = new Pracownik()
            {

                imie = walidacja.ResztaZnakowNaMale(ImieUzytkownika.Text),
                nazwisko = walidacja.PoMyslnikuLubSpacji(NazwiskoUzytkownika.Text,"-", CultureInfo.InvariantCulture),
                miasto = walidacja.PoMyslnikuLubSpacji(MiastoUzytkownika.Text, "- ", CultureInfo.InvariantCulture),
                ulica = walidacja.ResztaZnakowNaMale(UlicaUzytkownika.Text),
                numerDomu = NumerDomu.Text,
                numerMieszkania = NumerMieszkania.Text,
                pesel = PeselUzytkownika.Text,
                stanowisko = (eStanowisko)Enum.Parse(typeof(eStanowisko), StanowiskoUzytkownika.SelectedItem.ToString()),
                stopien = (eStopien)Enum.Parse(typeof(eStopien), Stopień.SelectedItem.ToString()),
                numerTelefonu = NumerTelefonu.Text,
                dataWażnościKPP = DateTime.Parse(KoniecKPP.Text),
                mail = AdresEmail.Text,
                dataBadan = DateTime.Parse(DataBadan.Text),
                login = walidacja.CaloscNaMale(LoginUzytkownika.Text),
                haslo = HasloUzytkownika.Text,
                idUmowy = NrUmowy.Text,
                typKonta = (eTypKonta)Enum.Parse(typeof(eTypKonta), TypKonta2.SelectedItem.ToString()),
            }; 

            if (walidacja.ValidatePesel(PeselUzytkownika.Text) && walidacja.ValidateMail(AdresEmail.Text) && walidacja.ValidateNumber(NumerTelefonu.Text))
            {
                //adapter.Insert(pracownik);
                if (adapter.Insert(pracownik) == true)
                {
                    MessageBox.Show("Dane pracownika zostały zapsiane w bazie.");
                }
                else if (adapter.Insert(pracownik) == false)
                {
                    MessageBox.Show("Błąd!");
                }
            }
            else if (walidacja.ValidateMail(AdresEmail.Text) == false)
                MessageBox.Show("Zły format adresu e-mail!");
            else if (walidacja.ValidatePesel(PeselUzytkownika.Text) == false)
                MessageBox.Show("Zły format numeru PESEL!");
            else if (walidacja.ValidateNumber(NumerTelefonu.Text) == false)
                MessageBox.Show("Zły format numeru telefonu!");


            // MessageBox.Show(pracownik.imie.ToString());
        }
        private void AddEmployer_Click(object sender, EventArgs e)
        {
            Add_Employer();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Stopień_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stanowisko2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumerTelefonu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypUmowy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PoczatekUmowy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Stopień_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void StwórzUmowe_Click(object sender, EventArgs e)
        {
            Add_Contract();
        }

        private void NrUmowy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdresEmail_TextChanged(object sender, EventArgs e)
        {


        }

        private void ImieUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImieUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLitery(e);
        }

        private void NazwiskoUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnik(e);
        }


        private void PeselUzytkownika_TextChanged(object sender, EventArgs e)
        {
        }

        private void PeselUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoCyfry(e);
        }

        private void MiastoUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnikSpacja(e);
        }

        private void UlicaUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoLiteryMyslnikSpacja(e);
        }

        private void NumerDomu_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumerDomu_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoCyfryLitery(e);
        }

        private void NumerTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            blokady.tylkoCyfryPlus(e);
        }
     
        private void StanowiskoUzytkownika_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            if (StanowiskoUzytkownika.Text == eStanowisko.KZ.ToString())
            {
                    KoniecKPP.Enabled = false;
                    Stopień.Enabled = false;
            }
                    
            else
            {
                    KoniecKPP.Enabled = true;
                    Stopień.Enabled = true;
            }
        }


    }
}
