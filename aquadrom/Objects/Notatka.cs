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
        private bool akceptacjaKZ { get; set; }
        private bool akceptacjaKSR { get; set; }

        public int ID_R { get; set; }
        public int ID_KZ { get; set; }
        public int ID_KSR { get; set; }

        public Notatka(DateTime czasZdarzenia)
        {
            akceptacjaKSR = false; akceptacjaKZ = false;
            this.czasZdarzenia = czasZdarzenia;
            ID_KSR = GetKSR_ID();
            ID_KZ = GetKZ_ID();
        }


        private int GetKSR_ID()
        {
            return 1;//TODO:sprawdzenie kto w czasie zdarzenia pracował
        }
        private int GetKZ_ID()
        {
            return 1;//TODO:sprawdzenie kto w czasie zdarzenia pracował
        }
    }
}
