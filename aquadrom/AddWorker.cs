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

            exist = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_Employer()
        {
            Pracownik pracownik = new Pracownik()
            {

                imie = ImieUzytkownika.Text,
                nazwisko = NazwiskoUzytkownika.Text,
                miasto = MiastoUzytkownika.Text,
                ulica = UlicaUzytkownika.Text,
                numerDomu = NumerDomu.Text,
                numerMieszkania = NumerMieszkania.Text,
                pesel = PeselUzytkownika.Text,
                stanowisko = (eStanowisko)Enum.Parse(typeof(eStanowisko), StanowiskoUzytkownika.SelectedItem.ToString()),
                stopien = (eStopien)Enum.Parse(typeof(eStopien), Stopień.SelectedItem.ToString()),
                numerTelefonu = NumerTelefonu.Text,
                dataWażnościKPP = DateTime.Parse(KoniecKPP.Text),
                mail = AdresEmail.Text,
                dataBadan = DateTime.Parse(DataBadan.Text),
                login = LoginUzytkownika.Text,
                haslo = HasloUzytkownika.Text
            };
            adapter.Insert(pracownik);
            if (adapter.Insert(pracownik) == true)
            {
                MessageBox.Show("Dane pracownika zostały zapsiane w bazie.");
            }
            else if (adapter.Insert(pracownik) == false)
            {
                MessageBox.Show("Błąd!.");
            }
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
    }
}
