﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;

namespace Objects
{
    public class Umowa
    {
<<<<<<< HEAD
        public DateTime początekUmowy { get; set; }
        public DateTime koniecUmowy { get; set; }
        public string wymiarGodzin { get; set; }
        public eUmowa typUmowy { get; set; } 

        public Umowa()
        {
            this.typUmowy = eUmowa.UZ;
            this.wymiarGodzin= "";
            this.początekUmowy = new DateTime();
            this.koniecUmowy = new DateTime();
        }
        public Umowa(eUmowa typUmowy, string wymiarGodzin, DateTime początekUmowy, DateTime koniecUmowy)
        {
            this.typUmowy = typUmowy;
            this.wymiarGodzin = wymiarGodzin;
            this.początekUmowy = początekUmowy;
            this.koniecUmowy = koniecUmowy;
        }
    }
=======
        public int ID_u { get; set; }
        public eUmowa Typ { get; set; }
        public string Wymiar_godzin { get; set; }
        public DateTime Poczatek_umowy { get; set; }
        public DateTime Koniec_umowy { get; set; }

        public Umowa(int ID_u, eUmowa Typ, string Wymiar_godzin, DateTime Poczatek_umowy, DateTime Koniec_umowy)
        {
            this.ID_u = ID_u;
            this.Typ = eUmowa.UZ;
            this.Wymiar_godzin = Wymiar_godzin;
            this.Poczatek_umowy = Poczatek_umowy;
            this.Koniec_umowy = Koniec_umowy;
        }
    }


>>>>>>> master
}
