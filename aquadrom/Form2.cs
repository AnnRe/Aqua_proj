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
        private string sql_add_employer = "INSERT into Pracownik VALUES";
        private string sql_add_agreement = "INSERT into Umowa VALUES";

        public static bool exist = false;

        public Form2()
        {
            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(eStanowisko)))
            {
                Stanowisko2.Items.Add(item);
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
        private bool Add_Employer()
        {
            Pracownik pracownik = new Pracownik()
            {
                imie = Imie2.Text,
                nazwisko = Nazwisko2.Text,
                miasto = Miasto2.Text,
                ulica = Ulica2.Text,
                numerDomu = NumerDomu.Text,
                numerMieszkania = numericUpDown1.Text,
                pesel = Pesel2.Text,
                stanowisko = (eStanowisko) Enum.Parse(typeof(eStanowisko), Stanowisko2.SelectedItem.ToString()),
                stopien = (eStopien)Enum.Parse(typeof(eStopien), Stopień.SelectedItem.ToString()),
                numerTelefonu=NumerTelefonu.Text,
                dataWażnościKPP=DateTime.Parse(DataKPP.Text),
                mail=Email2.Text,
                dataBadan = DateTime.Parse(DataMedycynyPRacy.Text),
                login= Login2.Text,
                haslo=Haslo2.Text
            };
            adapter.Insert(pracownik);
            MessageBox.Show("Dane pracownika zostały zapsiane w bazie danych.");
            return true;
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
    }
}
