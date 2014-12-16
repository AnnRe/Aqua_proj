using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquadrom.Utilities
{
    public static class DateConvertor
    {
        public static string MonthName(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    return "Styczeń";
                case 2:
                    return "Luty";
                case 3:
                    return "Marzec";
                case 4:
                    return "Kwiecień";
                case 5: 
                    return "Maj";
                case 6:
                    return "Czerwiec";
                case 7:
                    return "Lipiec";
                case 8:
                    return "Sierpień";
                case 9:
                    return "Wrzesień";
                case 10:
                    return "Październik";
                case 11:
                    return "Listopad";
                default:
                    return "Grudzień";
            }
        }
        public static int GetMonthNumber(string MonthName)
        {
            switch (MonthName)
            {
                case "Styczeń":
                    return 1;
                case "Luty":
                    return 2;
                case "Marzec":
                    return 3;
                case "Kwiecień":
                    return 4;
                case "Maj":
                    return 5;
                case "Czerwiec":
                    return 6;
                case "Lipiec":
                    return 7;
                case "Sierpień":
                    return 8;
                case "Wrzesień":
                    return 9;
                case "Październik":
                    return 10;
                case "Listopad":
                    return 11;
                default:
                    return 12;
            }
        }

        public static object MonthName(int p)
        {
            throw new NotImplementedException();
        }
    }
}
