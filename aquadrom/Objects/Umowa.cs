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
        public DateTime poczatekUmowy { get; set; }
        public DateTime koniecUmowy { get; set; }
        public string wymiarGodzin { get; set; }
        public eUmowa typUmowy { get; set; }
        public int ID_u { get; set; }

        public Umowa()
        {
            this.typUmowy = eUmowa.UZ;
            this.wymiarGodzin= "";
            this.poczatekUmowy = new DateTime();
            this.koniecUmowy = new DateTime();
        }
        public Umowa(eUmowa typUmowy, string wymiarGodzin, DateTime początekUmowy, DateTime koniecUmowy)
        {
            this.typUmowy = typUmowy;
            this.wymiarGodzin = wymiarGodzin;
            this.poczatekUmowy = początekUmowy;
            this.koniecUmowy = koniecUmowy;
        }

        public Umowa(int ID_u, eUmowa Typ, string Wymiar_godzin, DateTime Poczatek_umowy, DateTime Koniec_umowy)
        {
            this.ID_u = ID_u;
            this.typUmowy = eUmowa.UZ;
            this.wymiarGodzin = Wymiar_godzin;
            this.poczatekUmowy = Poczatek_umowy;
            this.koniecUmowy = Koniec_umowy;
        }
    }


}
