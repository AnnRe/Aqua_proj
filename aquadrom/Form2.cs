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
                początekUmowy = DateTime.Parse(PoczatekUmowy.Text),
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
            Pracownik pracownik = new Pracownik()
            {

                imie = ResztaZnakowNaMale(PierwszyZnakNaDuzaLitere(ImieUzytkownika.Text)),
                nazwisko = PoMyslnikuLubSpacji(ResztaZnakowNaMale(PierwszyZnakNaDuzaLitere(NazwiskoUzytkownika.Text)), "-", CultureInfo.InvariantCulture),
                miasto =  PoMyslnikuLubSpacji(ResztaZnakowNaMale(PierwszyZnakNaDuzaLitere(MiastoUzytkownika.Text)), "- ", CultureInfo.InvariantCulture),
                ulica = ResztaZnakowNaMale(PierwszyZnakNaDuzaLitere(UlicaUzytkownika.Text)),
                numerDomu = NumerDomu.Text,
                numerMieszkania = NumerMieszkania.Text,
                pesel = PeselUzytkownika.Text,
                stanowisko = (eStanowisko) Enum.Parse(typeof(eStanowisko), StanowiskoUzytkownika.SelectedItem.ToString()),
                stopien = (eStopien)Enum.Parse(typeof(eStopien), Stopień.SelectedItem.ToString()),
                numerTelefonu=NumerTelefonu.Text,
                dataWażnościKPP=DateTime.Parse(KoniecKPP.Text),
                mail = AdresEmail.Text,
                dataBadan = DateTime.Parse(DataBadan.Text),
                login= CaloscNaMale(LoginUzytkownika.Text),
                haslo = HasloUzytkownika.Text,
                idUmowy = NrUmowy.Text,
                typKonta=(eTypKonta) Enum.Parse(typeof(eTypKonta), TypKonta2.SelectedItem.ToString()),
            };
            
            

            if (pracownik.ValidatePesel(PeselUzytkownika.Text) && pracownik.ValidateMail(AdresEmail.Text) && pracownik.ValidateNumber(NumerTelefonu.Text))
            {
                adapter.Insert(pracownik);
                if (adapter.Insert(pracownik) == false)
                {
                    MessageBox.Show("Dane pracownika zostały zapsiane w bazie.");
                }
                else if (adapter.Insert(pracownik) == true)
                {
                    MessageBox.Show("Błąd!");
                }
            }
            else if(pracownik.ValidateMail(AdresEmail.Text)==false)
                MessageBox.Show("Zły format adresu e-mail!");
            else if (pracownik.ValidatePesel(PeselUzytkownika.Text) == false)
                MessageBox.Show("Zły format numeru PESEL!");
            else if (pracownik.ValidateNumber(NumerTelefonu.Text) == false)
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
        void tylkoLitery(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        void tylkoLiteryMyslnik(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-');
        }
        void tylkoLiteryMyslnikSpacja(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == ' ');
        }

        void tylkoCyfryPlus(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '+');
        }

        void tylkoCyfry(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        void tylkoCyfryLitery(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar) );
        }

        public string PierwszyZnakNaDuzaLitere(string nazwa)
        {
            if (String.IsNullOrEmpty(nazwa))
                throw new ArgumentException("Błąd!");
            return nazwa.First().ToString().ToUpper() + nazwa.Substring(1);
        }

        public string CaloscNaMale(string nazwa)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            string lower = nazwa.ToLower(culture);
            return lower;
        }

        public string ResztaZnakowNaMale(string litera)
        {
            bool sawLetter = false;
            StringBuilder sb = new StringBuilder(litera.Length);
            foreach (char c in litera)
            {
                if (!sawLetter && Char.IsLetter(c))
                {
                    sb.Append(Char.ToUpperInvariant(c));
                    sawLetter = true;
                }
                else
                {
                    sb.Append(Char.ToLowerInvariant(c));
                }
            }
            return sb.ToString();
        }
        public string PoMyslnikuLubSpacji(string nazwa, string znaki, CultureInfo culture)
        {
            bool jestZnakiem = true;
            var rezultat = new StringBuilder(nazwa.Length);

            foreach (char c in nazwa)
            {
                if (jestZnakiem)
                {
                    rezultat.Append(char.ToUpper(c, culture));
                    jestZnakiem = false;
                }
                else
                {
                    if (znaki.Contains(c))
                        jestZnakiem = true;

                    rezultat.Append(char.ToLower(c,culture));
                }
            }

            return rezultat.ToString();
        }

        private void ImieUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoLitery(e);
        }

        private void NazwiskoUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoLiteryMyslnik(e);
        }


        private void PeselUzytkownika_TextChanged(object sender, EventArgs e)
        { 
        }

        private void PeselUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoCyfry(e);
        }

        private void MiastoUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoLiteryMyslnikSpacja(e);
        }

        private void UlicaUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoLiteryMyslnikSpacja(e);
        }

        private void NumerDomu_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumerDomu_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoCyfryLitery(e);
        }

        private void NumerTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            tylkoCyfryPlus(e);
        }
 
       
    }
}
