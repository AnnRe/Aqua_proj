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
        public int id_p { get; set; }
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
        //public string login{ private get; set; } 
        //public string haslo{ private get; set; } 
        public string login{ get; set; } 
        public string haslo{ get; set; }

        public string oUmowa { get; set; }
        public string oKPP { get; set; }
        public string oBadania { get; set; } 

        //bool dobryPesel = false;
        //bool poprawny = false; 

        public Pracownik()
        {
            this.stanowisko = eStanowisko.RW;
            this.imie = "";
            this.nazwisko = "";
            this.pesel = "";
            this.mail = "";
            this.miasto = "";
            this.ulica = "";
            //this.numerDomu = "";
            this.numerMieszkania = null;
            //this.numerMieszkania = null;
            this.numerTelefonu = "";
            this.stanowisko = eStanowisko.RW;
            this.dataWażnościKPP = new DateTime();
            this.dataBadan = new DateTime();
            this.stopien = eStopien.MR;
            this.login = "";
            this.haslo = "";
            this.idUmowy = "12";
            this.typKonta = eTypKonta.U;
            this.oUmowa = "f";
            this.oKPP = "f";
            this.oBadania = "f";

        }

        public Pracownik(string imie, string nazwisko, eStanowisko stanowisko,
        string pesel, string mail, string miasto, string ulica, string numerDomu, string numerTelefonu, DateTime dataWażnościKPP,
            DateTime dataBadan, eStopien stopien, string login, string haslo, string idUmowy, eTypKonta 
            typKonta)
        {
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.pesel=pesel;
            this.miasto = miasto;
            this.ulica = ulica;
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.numerTelefonu = numerTelefonu;
            this.mail=mail;
            this.stopien = stopien;
            this.stanowisko = stanowisko;
            this.dataWażnościKPP = dataWażnościKPP;
            this.dataBadan= dataBadan;
            this.stopien= stopien;
            this.login= login;
            this.haslo= haslo;
            this.idUmowy = idUmowy;
            this.typKonta = typKonta;
 
        }

        public Pracownik(int id_p, string imie, string nazwisko, string pesel,
           string miasto, string ulica, string numerDomu, string numerMieszkania,
           string numerTelefonu, string mail, eStopien stopien, eStanowisko stanowisko,
           DateTime dataWażnościKPP, DateTime dataBadan)
        {
            this.id_p = id_p;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel = pesel;
            this.miasto = miasto;
            this.ulica = ulica;
            this.numerDomu = numerDomu;
            this.numerMieszkania = numerMieszkania;
            this.numerTelefonu = numerTelefonu;
            this.mail = mail;
            this.stopien = stopien;
            this.stanowisko = stanowisko;
            this.dataWażnościKPP = dataWażnościKPP;
            this.dataBadan = dataBadan;
        }

        private bool CanWork()
        {
            return true;//TODO: sprawdzenie daty badań
        }
    }
}
