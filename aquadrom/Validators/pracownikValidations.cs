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

namespace Objects
{
    //created by ogi
    class Validations
    {

        private static readonly int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        bool dobryEmail = false;

        public bool ValidatePesel(string pesel)
        {
            bool dobryPesel = false;
            try
            {
                if (pesel.Length == 11)
                {
                    dobryPesel = ObliczSumeKontrolna(pesel).Equals(pesel[10].ToString());
                }
            }
            catch (Exception)
            {
                dobryPesel = false;
            }
            return dobryPesel;
        }

        private static string ObliczSumeKontrolna(string pesel)
        {
            int sum = 0;
            for (int i = 0; i < mnozniki.Length; i++)
            {
                sum += mnozniki[i] * int.Parse(pesel[i].ToString());
            }

            int reszta = sum % 10;
            return reszta == 0 ? reszta.ToString() : (10 - reszta).ToString();
        }

        public bool ValidateNumber(string numer)
        {
            string poprawnyFormat = @"^(\+48)?[0-9]\d{8}$";
            if (numer != null)
                return Regex.IsMatch(numer, poprawnyFormat);
            else
                return false;
        }

        public bool ValidateMail(string mail)
        {
            dobryEmail = false;
            if (String.IsNullOrEmpty(mail))
                return false;
            try
            {
                mail = Regex.Replace(mail, @"(@)(.+)$", this.OdwzorujDomene,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (dobryEmail)
                return false;
            try
            {
                return Regex.IsMatch(mail,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private string OdwzorujDomene(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string nazwaDomeny = match.Groups[2].Value;
            try
            {
                nazwaDomeny = idn.GetAscii(nazwaDomeny);
            }
            catch (ArgumentException)
            {
                dobryEmail = true;
            }
            return match.Groups[1].Value + nazwaDomeny;
        }

        public string CaloscNaMale(string nazwa)
        {
            CultureInfo cult = CultureInfo.CurrentCulture;
            string mniejszy = nazwa.ToLower(cult);
            return mniejszy;
            //wywołaj dla login
        }
        public string PierwszyZnakNaDuzaLitere(string nazwa)
        {
           if (String.IsNullOrEmpty(nazwa))
                throw new ArgumentException("Błąd!");
            return nazwa.First().ToString().ToUpper() + nazwa.Substring(1);
        }

        public string ResztaZnakowNaMale(string litera)
        {
            PierwszyZnakNaDuzaLitere(litera);
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
            // wywołaj dla kolumn: imie, ulica
        }

        public string PoMyslnikuLubSpacji(string nazwa, string znaki, CultureInfo culture)
        {
            ResztaZnakowNaMale(nazwa);
            PierwszyZnakNaDuzaLitere(nazwa);
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

                    rezultat.Append(char.ToLower(c, culture));
                }
            }

            return rezultat.ToString();
            // wywołać dla : nazwisko z argumentem znaki= "-", miasto z argumentem znaki= "- "
            // argument culture =  CultureInfo.InvariantCulture
        }

        public bool isNullOrNot(TextBox tekst, string nazwaPola)
        {
            if (String.IsNullOrEmpty(tekst.Text))
            {
                MyMessageBox.ShowBox("Wypełnij pole: " + nazwaPola + "!");
                return true;
            }
            else
            {
                return false;
            } // wywołać na textboxach
        }
        public bool isNullOrNot(RichTextBox tekst, string nazwaPola)
        {
            if (String.IsNullOrEmpty(tekst.Text))
            {
                MyMessageBox.ShowBox("Wypełnij pole: " + nazwaPola + "!");
                return true;
            }
            else
            {
                return false;
            } // wywołać na textboxach
        }
        public bool isNullOrNot(string tekst, string nazwaPola)
        {
            if (String.IsNullOrEmpty(tekst))
            {
                MessageBox.Show("Wypełnij pole: " + nazwaPola + "!");
                return true;
            }
            else
            {
                return false;
            } // wywołać na textboxach
        }

        public bool isNullOrNot(NumericUpDown tekst, string nazwaPola)
        {
            if (String.IsNullOrEmpty(tekst.Text))
            {
                MyMessageBox.ShowBox("Wypełnij pole: " + nazwaPola + "!");
                return true;
            }
            else
            {
                return false;
            } // wywołać na numericupdownach oprocz nr mieszkania
        }

        public string deleteNumbers(TextBox tekst)
        {
            string withNumbers = tekst.Text;
            string withoutNumbers = Regex.Replace(withNumbers, "[0-9]", "");
            return withoutNumbers;
            //jak ktos wklei cyferke to problem
            //wpisywanie z klawiatury jest blokowane, ale wklejanie nie
            // funckja usunie cyfry
            // w przypadku numerów nie trzeba tego robić, jak pesel dostanie wklejone litery lub znaki
            //zadziała funkcja validatepesel , podobnie w numerze telefonu, numericupdowny domyslnie
            //przyjmuja tylko cyfry
        }

        public void tylkoLitery(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public  void tylkoLiteryMyslnik(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-');
        }

        public void tylkoLiteryMyslnikSpacja(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == ' ');
        }

        public void tylkoCyfryPlus(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '+');
        }

        public void tylkoCyfry(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void tylkoCyfryLitery(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsLetter(e.KeyChar));
        }

        public bool CanWork()
        {
            return true; //TODO: sprawdzenie daty badań
        }
    }
}
