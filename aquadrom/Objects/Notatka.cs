using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquadrom.Objects
{
    public class Notatka
    {
        public string opis { get; set; }
        public DateTime czasZdarzenia { get; set; }
        public string rodzajZdarzenia { get; set; }//TODO:?string?
        public string uwagi { get; set; }
        public bool akceptacjaKZ { get; set; }
        public bool akceptacjaKSR { get; set; }

        public int ID_R { get; set; }
        public int ID_KZ { get; set; }
        public int ID_KSR { get; set; }

        public Notatka()
        {
            this.opis = opis;
            this.czasZdarzenia = czasZdarzenia;
            this.rodzajZdarzenia = rodzajZdarzenia;
            this.uwagi = uwagi;
            this.akceptacjaKSR = true; 
            this.akceptacjaKZ = true;
            this.ID_R = ID_R;
            this.ID_KSR = 1;
            this.ID_KZ = 1;
        }
        public Notatka(string opis, DateTime czasZdarzenia, string rodzajZdarzenia, string uwagi, bool akceptackaKZ,
            bool akceptacjaKSR, int ID_R, int ID_KZ, int ID_KSR)
        {
            this.opis = opis;
            this.czasZdarzenia = czasZdarzenia;
            this.rodzajZdarzenia = rodzajZdarzenia;
            this.uwagi = "Wyjaśnienie składane jest później.";
            this.akceptacjaKSR = true;
            this.akceptacjaKZ = true;
            this.ID_R = ID_R;
            this.ID_KSR = 1;
            this.ID_KZ = 1;
        }

    }
}
