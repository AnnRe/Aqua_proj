using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;
using DB;
using aquadrom.Utilities;

namespace aquadrom.Objects
{
    public class Harmonogram
    {

        public void Add(Pracownik pracownik, DateTime pocz, DateTime koniec)
        {
            DBAdapter polaczenie = new DBAdapter();
            string query = "into " + Constants.TabGodzinyPracy + "(" + Constants.GodzinyPracyOd + "," + Constants.GodzinyPracyDo + "," +
                Constants.GodzinyPracyIdP+") values ("+
                pocz.Date.ToString("yyyy-MM-dd HH:mm:ss")+","+koniec.Date.ToString("yyyy-MM-dd HH:mm:ss")+","+pracownik.id_p+")";
            polaczenie.Insert(query);
           
        }

        /// <summary>
        /// Sprawdza, czy w każdym momencie jest wystarczająca ilość pracowników oraz czy są KZ/KSR
        /// </summary>
        /// <returns></returns>
        private bool PoprawnieRozplanowanyDzien(DateTime day)
        {
            DateTime t = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            DateTime endOfDay = new DateTime(day.Year, day.Month, day.Day, 23, 59, 59);
            for (; t < endOfDay; t.AddMinutes(15))
            {
                if (!StanowiskaObsadzone(t) || !PracownicyMajaOdpowiednieGodziny(t))
                    return false;
            
            }
                //TODO: sprawdzenie po godzinie, 
                //TODO: sprawdzenie KZ,KSR
                return true;
        }

        /// <summary>
        /// Sprawdza czy pracownicy mają wypełnioną pulę godzin
        /// </summary>
        /// <returns></returns>
        private bool PracownicyMajaOdpowiednieGodziny(DateTime time)
        {
            DBAdapter polaczenie = new DBAdapter();
          //  string query="SELECT * from pracownik where "+const
            //var pracownicyDataTable=polaczenie.GetData()
            return true;
        }

        private bool StanowiskaObsadzone(DateTime time)
        {

            return true;
 
        }

        public bool CorrectFormat(string value)
        {
            DateTime dateValue;
            if (DateTime.TryParse(value, out dateValue))
            {
                return true;
            }
            else
                return false;
        }

         
    
    }
}
