using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Objects
{
    public class Pracownik
    {
        public eStanowisko stanowisko { get; set; }
        public eTypKonta typKonta {get;set;}
        public string idUmowy { get; set; }
        public string imie { get; set; } 
        public string nazwisko { get; set; } 
        public string pesel { get; set; } 
        public string mail { get; set; } 
        public string miasto{ get; set; } 
        public string ulica{ get; set; } 
        public string numerDomu{ get; set; }
        public string numerMieszkania { get; set; } 

        public string numerTelefonu{ get; set; } 
        public DateTime dataWażnościKPP{ get; set; } 
        public DateTime dataBadan{ get; set; } 
        public eStopien stopien{ get; set; } 
        public string login{ get; set; } 
        public string haslo{ get; set; }

        bool dobryEmail = false;
        bool dobryPesel = false;
        bool poprawny = false;
        private static readonly int[] mnozniki = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        

        public Pracownik()
        {
            this.stanowisko = eStanowisko.RW;
            this.imie = "";
            this.nazwisko = "";
            this.pesel = "";
            this.mail = "";
            this.miasto = "";
            this.ulica = "";
            this.numerDomu = "";
            this.numerMieszkania = null;
            this.numerTelefonu = "";
            this.stanowisko = eStanowisko.RW;
            this.dataWażnościKPP = new DateTime();
            this.dataBadan = new DateTime();
            this.stopien = eStopien.MR;
            this.login = "";
            this.haslo = "";
            this.idUmowy = "12";
            this.typKonta = eTypKonta.U;

        }

        public Pracownik(string imie,string nazwisko,eStanowisko stanowisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
        }

        public Pracownik(string imie, string nazwisko, eStanowisko stanowisko,
        string pesel, string mail, string miasto, string ulica, string numerDomu, string numerTelefonu, DateTime dataWażnościKPP,
            DateTime dataBadan, eStopien stopien, string login, string haslo, string idUmowy, eTypKonta 
            typKonta)
        {
            this.stanowisko=stanowisko;
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.pesel=pesel;
            this.mail=mail;
            this.miasto=miasto;
            this.ulica=ulica;
            this.numerDomu=numerDomu;
            this.numerTelefonu= numerTelefonu;
            this.dataWażnościKPP= dataWażnościKPP;
            this.dataBadan= dataBadan;
            this.stopien= stopien;
            this.login= login;
            this.haslo= haslo;
            this.idUmowy = idUmowy;
            this.typKonta = typKonta;
 
 
        }

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

        public bool ValidateNumber(string numer)
        {
            string poprawnyFormat = @"^(\+48)?[0-9]\d{8}$";
            if (numer != null) 
                return Regex.IsMatch(numer, poprawnyFormat);
            else 
                return false;
        }

        private bool CanWork()
        {
            return true;//TODO: sprawdzenie daty badań
        }
    }
}
