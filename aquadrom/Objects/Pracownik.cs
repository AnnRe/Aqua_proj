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
        public int id_p { get; set; }
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
        public eStopien stopien{ get; set; } 
        public string login{ get; set; } 
        public string haslo{ get; set; } 

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
            this.numerMieszkania = null;
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

        public Pracownik(int id_p, string imie, string nazwisko, string pesel,
            string miasto, string ulica, string numerDomu, string numerMieszkania,
            string numerTelefonu, string mail, eStopien stopien, eStanowisko stanowisko, 
            DateTime dataWażnościKPP, DateTime dataBadan)
        {
            this.id_p = id_p;
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
        }
    }
}
