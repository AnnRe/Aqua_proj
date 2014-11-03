using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;

namespace aquadrom.Objects
{
    public class Harmonogram
    {

        public void Add(Pracownik pracownik, DateTime pocz, DateTime koniec)
        {
            if (PoprawnieRozdzieloneGodziny() && PoprawnieRozplanowanyDzien())
            { 
            }
            //TODO
        }

        /// <summary>
        /// Sprawdza, czy w każdym momencie jest wystarczająca ilość pracowników oraz czy są KZ/KSR
        /// </summary>
        /// <returns></returns>
        private bool PoprawnieRozplanowanyDzien()
        {
            //TODO: sprawdzenie po godzinie, 
            //TODO: sprawdzenie KZ,KSR
            return true;
        }

        /// <summary>
        /// Sprawdza czy pracownicy mają wypełnioną pulę godzin
        /// </summary>
        /// <returns></returns>
        private bool PoprawnieRozdzieloneGodziny()
        {
            //TODO
            return true;
        }
    
    }
}
