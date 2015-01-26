using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquadrom.Validators
{
    public class harmonogramValidations
    {
        public static string ValidateCell(DataGridViewCellValidatingEventArgs e)
        {
            DateTime dateValue;

            if (DateTime.TryParse(e.FormattedValue.ToString(), out dateValue))
            {
                DateTime godz = new DateTime(dateValue.Year, dateValue.Month, dateValue.Day, 8, 0, 0);
                DateTime godz2 = godz.AddHours(14);

                if (dateValue.CompareTo(godz) >= 0 && dateValue.CompareTo(godz.AddHours(14)) <= 0)
                {
                    if (Convert.ToInt32(dateValue.Minute.ToString()) % 15 != 0)
                        return "Czas podajemy co 15min";
                }
                else
                {
                    return "Błędna godzina - pracujemy 8-22!";
                }
            }
            else
                if (e.FormattedValue.ToString().Length > 0)
                {
                    return "Zły format";
                }
            return "";
        }

        public static bool bothTimesAreReady(int columnIndex, int rowIndex, DataGridView dataGridView1)
        {

            int start = columnIndex % 2 == 1 ? columnIndex : columnIndex - 1;

            if (dataGridView1[start, rowIndex].Value == null || dataGridView1[start, rowIndex].Value.ToString() == "")
            {//pierwsza pusta
                if (dataGridView1[start + 1, rowIndex].Value != null && dataGridView1[start + 1, rowIndex].Value.ToString() != "")
                {//druga niepusta
                    dataGridView1[2, rowIndex].Tag = "Prawie";
                    return false;
                }
                else
                {//i druga też pusta
                    dataGridView1[2, rowIndex].Tag = "";
                    return false;
                }
            }
            else if (dataGridView1[start + 1, rowIndex].Value == null || dataGridView1[start + 1, rowIndex].Value.ToString() == "")
            {//druga pusta, ale pierwsza nie
                dataGridView1[2, rowIndex].Tag = "Prawie";
                return false;
            }
            dataGridView1[2, rowIndex].Tag = "Gotowe";
            return true;
        }
        
    }
}
