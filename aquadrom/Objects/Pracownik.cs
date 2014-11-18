using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;

namespace Objects
{
    public class Pracownik
    {
        public eStanowisko stanowisko { get; set; } 
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
        public eStopien stopien{ get{this.ToString()}; set; } 
        public string login{ private get; set; } 
        public string haslo{ private get; set; } 

        public Pracownik()
        {
            this.stanowisko = eStanowisko.RW;
            this.imie = "";
            this.nazwisko = "";
            this.pesel = "";
            this.mail = "";
            this.miasto = "";
            this.ulica = "";
            this.numerDomu = null;
            this.numerTelefonu = "";
            this.dataWażnościKPP = new DateTime();
            this.dataBadan = new DateTime();
            this.stopien = eStopien.MR;
            this.login = "";
            this.haslo = "";
        }

        public Pracownik(string imie,string nazwisko,eStanowisko stanowisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.stanowisko = stanowisko;
        }

        public Pracownik(string imie, string nazwisko, eStanowisko stanowisko,
        string pesel, string mail, string miasto, string ulica, string numerDomu, string numerTelefonu, DateTime dataWażnościKPP,
            DateTime dataBadan, eStopien stopien, string login, string haslo)
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
 
        }

        private bool ValidatePesel(string pesel)
        {
            return true; //TODO
        }

        private bool ValidateMail(string mail)
        {
            return true; //TODO
        }

        private bool CanWork()
        {
            return true;//TODO: sprawdzenie daty badań
        }
    }
}
