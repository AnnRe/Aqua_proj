using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aquadrom.Utilities;

namespace Objects
{
    public class Validations
    {
        public bool ValidatePesel(string pesel)
        {
            System.Windows.Forms.MessageBox.Show("test");
            return true; //TODO
        }

        public bool ValidateMail(string mail)
        {
            return true; //TODO
        }

        public bool CanWork()
        {
            return true;//TODO: sprawdzenie daty badań
        }
    }
}
