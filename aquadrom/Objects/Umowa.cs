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
}
