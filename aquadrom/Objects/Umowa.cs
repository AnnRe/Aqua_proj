using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;

namespace Objects
{
    public class Umowa
    {
        public int ID_u { get; set; }
        public eUmowa Typ { get; set; }
        public string Wymiar_godzin { get; set; }
        public DateTime Poczatek_umowy { get; set; }
        public DateTime Koniec_umowy { get; set; }

        public Umowa(int ID_u, eUmowa Typ, string Wymiar_godzin, DateTime Poczatek_umowy, DateTime Koniec_umowy)
        {
            this.ID_u = ID_u;
            this.Typ = Typ;
            this.Wymiar_godzin = Wymiar_godzin;
            this.Poczatek_umowy = Poczatek_umowy;
            this.Koniec_umowy = Koniec_umowy;
        }
    }


}
