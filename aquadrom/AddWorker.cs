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
using System.Net;
using System.Net.Mail;


namespace aquadrom
{
    //created by ogi
    public partial class Form2 : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector polaczenie = new DBConnector();
        Validations blokady = new Validations();
        Validations walidacja = new Validations();
        public static bool exist = false;

        public Form2()
        {
            InitializeComponent();
            NrUmowy.Enabled = false;
            LoginUzytkownika.Enabled = false;
            HasloUzytkownika.Enabled = false;
            PowtorzHasloUżytkownika.Enabled = false;

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

            //MyMessageBox.ShowBox("pass: " + CreatePassword(10));
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
            if (adapter.Insert(umowa) == true)
            {
                MyMessageBox.ShowBox("Umowa została zapisana w bazie.");
            }
            else if (adapter.Insert(umowa) == false)
            {
                MyMessageBox.ShowBox("Błąd!");
            }
        }
        private void Add_Employer()
        {
             LoginUzytkownika.Text = walidacja.CaloscNaMale(ImieUzytkownika.Text + "." + NazwiskoUzytkownika.Text);
             HasloUzytkownika.Text = createPassword(10);
             PowtorzHasloUżytkownika.Text = HasloUzytkownika.Text;

             Pracownik pracownik = new Pracownik()
             {

                imie = walidacja.ResztaZnakowNaMale(ImieUzytkownika.Text),
                nazwisko = walidacja.PoMyslnikuLubSpacji(NazwiskoUzytkownika.Text,"-", CultureInfo.InvariantCulture),
                miasto = walidacja.PoMyslnikuLubSpacji(MiastoUzytkownika.Text, "- ", CultureInfo.InvariantCulture),
                ulica = walidacja.PoMyslnikuLubSpacji(UlicaUzytkownika.Text, "- ", CultureInfo.InvariantCulture),
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
                haslo = HasloUzytkownika.Text,
                idUmowy = NrUmowy.Text,
                typKonta = (eTypKonta)Enum.Parse(typeof(eTypKonta), TypKonta2.SelectedItem.ToString()),
            };

            if (KoniecKPP.Enabled == false)   // jeśli KPP nie wymagane to minvalue (NULL to base)
                pracownik.dataWażnościKPP = DateTime.MinValue;
                 //DateTime? MyNullDateValue = null;
                // (pracownik.stopien(DBNull.Value);


            if (walidacja.ValidatePesel(PeselUzytkownika.Text) && walidacja.ValidateMail(AdresEmail.Text) && walidacja.ValidateNumber(NumerTelefonu.Text))
            {
                //adapter.Insert(pracownik); 
                if (adapter.Insert(pracownik) == true)
                {
                    sendMail(LoginUzytkownika.Text, HasloUzytkownika.Text, AdresEmail.Text, ImieUzytkownika.Text, NazwiskoUzytkownika.Text);
                    MyMessageBox.ShowBox("Dane pracownika zostały zapsiane w bazie.");
                    this.Close();
                    exist = false;
                }
                else if (adapter.Insert(pracownik) == false)
                {
                    MyMessageBox.ShowBox("Błąd!");
                }
            }
            else if (walidacja.ValidateMail(AdresEmail.Text) == false)
                MyMessageBox.ShowBox("Zły format adresu e-mail!");
            else if (walidacja.ValidatePesel(PeselUzytkownika.Text) == false)
                MyMessageBox.ShowBox("Zły format numeru PESEL!");
            else if (walidacja.ValidateNumber(NumerTelefonu.Text) == false)
                MyMessageBox.ShowBox("Zły format numeru telefonu!");


            // MyMessageBox.ShowBox(pracownik.imie.ToString());
        }

        private void AddEmployer_Click(object sender, EventArgs e)
        {
            
            walidacja.deleteNumbers(ImieUzytkownika);
            walidacja.deleteNumbers(NazwiskoUzytkownika);
            walidacja.deleteNumbers(MiastoUzytkownika);
            walidacja.deleteNumbers(UlicaUzytkownika);

            if (walidacja.isNullOrNot(ImieUzytkownika, "Imię") || walidacja.isNullOrNot(NazwiskoUzytkownika, "Nazwisko")
                || walidacja.isNullOrNot(PeselUzytkownika, "Pesel") || walidacja.isNullOrNot(MiastoUzytkownika, "Miasto")
                || walidacja.isNullOrNot(UlicaUzytkownika, "Ulica") || walidacja.isNullOrNot(NumerDomu, "Nr domu")
                || walidacja.isNullOrNot(NumerTelefonu, "Numer telefonu") || walidacja.isNullOrNot(AdresEmail, "E-mail")
                || walidacja.isNullOrNot(LoginUzytkownika, "Login"))
                
            {
            }
            else if (NrUmowy.Text == "brak")
            {
                MyMessageBox.ShowBox("Przed dodaniem pracownika do bazy, należy stworzyć jego umowę!");
            }
            else if (HasloUzytkownika.Text != PowtorzHasloUżytkownika.Text)
            {
                MyMessageBox.ShowBox("Podane hasła są różne!");
            }
            else if ( CheckInternetConnection()==false)
            {
                MyMessageBox.ShowBox("Błąd połączenia internetowego!");
            }
            else
            {
                Add_Employer();
            }


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
            if (walidacja.isNullOrNot(WymiarGodzin, "Wymiar godzin"))
            {
            }
            else if(( CheckInternetConnection()==false))
            {
                MyMessageBox.ShowBox("Błąd połączenia internetowego!");
            }
            else
            {
                Add_Contract();
                string query = " MAX(" + Constants.UmowaIDu + ")" + " from " + Constants.TabUmowa;
                DataTable ids = polaczenie.Select(query);
                string ID = ids.Rows[0][0].ToString();
                MyMessageBox.ShowBox("Numer umowy to: " +ID + ".");
                NrUmowy.Text = ID;
                TypUmowy.Enabled = false;
                WymiarGodzin.Enabled = false;
                PoczatekUmowy.Enabled = false;
                KoniecUmowy.Enabled = false;
                StwórzUmowe.Enabled = false;
            }
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
                    TypKonta2.SelectedIndex = 1;
            }
            else if (StanowiskoUzytkownika.Text == eStanowisko.KSR.ToString())
            {
                    KoniecKPP.Enabled = true;
                    Stopień.Enabled = true;
                    TypKonta2.SelectedIndex = 1;
                    Stopień.SelectedIndex = 1;
            }

            else if (StanowiskoUzytkownika.Text == eStanowisko.RW.ToString())
            {
                KoniecKPP.Enabled = true;
                Stopień.Enabled = true;
                TypKonta2.SelectedIndex = 0;
                Stopień.SelectedIndex = 1;
            }
            else
            {
                KoniecKPP.Enabled = true;
                Stopień.Enabled = true;
                Stopień.SelectedIndex = 1;
            }


        }

        private void TypUmowy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (TypUmowy.Text == eUmowa.UZ.ToString())
            {
                WymiarGodzin.Enabled = false;
                WymiarGodzin.Maximum = 0;
                WymiarGodzin.Value = 0;
            }

            else
            {
                WymiarGodzin.Enabled = true;
                WymiarGodzin.Maximum = 320;
                WymiarGodzin.Minimum = 1;
            }
        }

        private void LoginUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumerMieszkania_ValueChanged(object sender, EventArgs e)
        {

        }

        public string createPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public void sendMail(string login, string haslo, string mail, string imie, string nazwisko)
        {
                var fromAdress = new MailAddress("aquadromautomat@gmail.com", "System automatycznej informacji");
                var toAdress = new MailAddress(mail, imie + " " + nazwisko);
                const string fromPassword = "aquadrom123";
                string subject = "Dane dostępowe";
                string body = "Witaj " + imie+ " " + nazwisko + " !" + "\n" + "Login: " + login + "\n" +"Hasło: " + haslo;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAdress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAdress, toAdress)
                {
                    Subject = subject,
                    Body = body
 
                })
                {
                    smtp.Send(message);
                }
        }
        public bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void TypUmowy_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(TypUmowy.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void TypKonta2_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Red;
            e.DrawBackground();
            e.Graphics.DrawString(TypKonta2.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void Stopień_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Red;
            e.DrawBackground();
            e.Graphics.DrawString(Stopień.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void StanowiskoUzytkownika_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Red;
            e.DrawBackground();
            e.Graphics.DrawString(StanowiskoUzytkownika.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }




        private void Imie_Click(object sender, EventArgs e)
        {

        }

        private void WymiarGodzin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PowtórzHasło_Click(object sender, EventArgs e)
        {

        }

        private void Pracownik_Enter(object sender, EventArgs e)
        {

        }

        private void Poczatek_umowy_Click(object sender, EventArgs e)
        {

        }

        private void Konto_Enter(object sender, EventArgs e)
        {

        }

        private void TypKonta2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dane_osobowe_Enter(object sender, EventArgs e)
        {

        }

        private void Dane_umowy_Enter(object sender, EventArgs e)
        {

        }

        private void TypKonta_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Nr_domu_Click(object sender, EventArgs e)
        {

        }

        private void NumerUmowy_Click(object sender, EventArgs e)
        {

        }

        private void NazwiskoUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stanowisko_Click(object sender, EventArgs e)
        {

        }

        private void Haslo_Click(object sender, EventArgs e)
        {

        }

        private void Ulica_Click(object sender, EventArgs e)
        {

        }

        private void Wymiar_godzin_Click(object sender, EventArgs e)
        {

        }

        private void Nazwisko_Click(object sender, EventArgs e)
        {

        }

        private void Koniec_umowy_Click(object sender, EventArgs e)
        {

        }

        private void HasloUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Pesel_Click(object sender, EventArgs e)
        {

        }

        private void Dane_kontaktowe_Enter(object sender, EventArgs e)
        {

        }

        private void KoniecUmowy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Data_badan_Click(object sender, EventArgs e)
        {

        }

        private void PowtorzHasloUżytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numer_mieszkania_Click(object sender, EventArgs e)
        {

        }

        private void Stopien_Click(object sender, EventArgs e)
        {

        }

        private void Data_KPP_Click(object sender, EventArgs e)
        {

        }

        private void Numer_telefonu_Click(object sender, EventArgs e)
        {

        }

        private void NumerTelefonu_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void KoniecKPP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Typ_umowy_Click(object sender, EventArgs e)
        {

        }

        private void NrUmowy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Badania_Enter(object sender, EventArgs e)
        {

        }

        private void UlicaUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

        private void Miasto_Click(object sender, EventArgs e)
        {

        }

        private void DataBadan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MiastoUzytkownika_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
