using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DB;
using aquadrom.Utilities;
using System.Security.Cryptography;
using aquadrom.Objects;

namespace aquadrom
{
    public partial class DeleteWorker : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector connector = new DBConnector();
        public static bool exist = false;
        private AdminPanel _mainform = null;

        private string chosen_id = "";
        private string chosen_concid = "";
        private string WhichUser = "";
        private string sql_deleteuser = "from "+Constants.TabPracownik+" where "+Constants.PracownikID+"=";
        private string sql_deletecontract = "from " + Constants.TabUmowa + " where " + Constants.UmowaIDu + "=";

        public DeleteWorker(Form callingForm)
        {
            _mainform = callingForm as AdminPanel;
            InitializeComponent();
            exist = true;
        }

        public void DeleteWorker_Load(object sender, EventArgs e)   // dodawanie imion i nazwisk wszystkich pracownikow do DeleteWorkerComboBox
        {
            DataTable dtWorkers = connector.Select(Constants.PracownikID + ", concat(" + Constants.PracownikNazwisko + ",' '," + Constants.PracownikImie + ") from Pracownik order by 2 asc;");
            foreach (DataRow row in dtWorkers.Rows)
            {
                DeleteWorkerComboBox.Items.Add(row[1].ToString());
            }
            adapter.LockButton(DeleteWorkerComboBox, DeleteButton);
        }

        private void DeleteWorkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {                                                       // którego użytkownika usunąć
            WhichUser = this.DeleteWorkerComboBox.Text;
            DataTable dtWorkers2 = connector.Select(Constants.PracownikID+", concat(" + Constants.PracownikNazwisko + ",' '," + Constants.PracownikImie + "),"+Constants.PracownikIDUmowy+" from Pracownik order by 2 asc;");
            foreach (DataRow row in dtWorkers2.Rows)
            {
                if (row[1].ToString() == WhichUser)
                {
                    chosen_id = row[0].ToString();  // wybierz aktualne id wybranego usera i dodaj do sql_deleteuser
                    chosen_concid = row[2].ToString(); 
                    break;
                }
            }
            adapter.LockButton(DeleteWorkerComboBox, DeleteButton);
        }

        private void DeleteButton_Click(object sender, EventArgs e) // usuwanie użytkownika po kliknięciu 'usuń'
        {
            if (WhichUser != "")    // gdy ktoś wybrany
            {
                DialogResult dialogResult = MyMessageBox.ShowBox("Na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sql_deleteuser += chosen_id;
                    sql_deletecontract += chosen_concid;
                    adapter.Delete(sql_deleteuser);
                    adapter.Delete(sql_deletecontract);
                    MyMessageBox.ShowBox("Użytkownik oraz jego umowa została usunięta");
                    _mainform.AdminPanel_Load(_mainform,e);   // odświeżanie listy z głównego okna admina.
                    exist = false;
                    this.Close();
                }
            }
        }

        private void DeleteWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            exist = false;
        }

        private void DeleteWorkerComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            var brush = Brushes.Black;
            e.DrawBackground();
            e.Graphics.DrawString(DeleteWorkerComboBox.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
    }
}
