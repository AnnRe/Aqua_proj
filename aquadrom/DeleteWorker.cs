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

namespace aquadrom
{
    public partial class DeleteWorker : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector connector = new DBConnector();
        public static bool exist = false;
        private AdminPanel _mainform = null;

        private string chosen_id = "";
        private string WhichUser = "";
        private string sql_deleteuser = "from Pracownik where "+Constants.PracownikID+"=";
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
            IfLocked(DeleteWorkerComboBox, DeleteButton);
        }

        private void DeleteWorkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {                                                       // którego użytkownika usunąć
            WhichUser = this.DeleteWorkerComboBox.Text;
            DataTable dtWorkers2 = connector.Select(Constants.PracownikID+", concat(" + Constants.PracownikNazwisko + ",' '," + Constants.PracownikImie + ") from Pracownik order by 2 asc;");
            foreach (DataRow row in dtWorkers2.Rows)
            {
                if (row[1].ToString() == WhichUser)
                {
                    if (chosen_id != "")    // jeśli wcześniej był wybrany user,usuń dodany wcześniej id z sql_deleteuser
                    {
                        sql_deleteuser = sql_deleteuser.Remove(sql_deleteuser.Length - chosen_id.Length);
                    }
                    chosen_id = row[0].ToString();  // wybierz aktualne id wybranego usera i dodaj do sql_deleteuser
                    sql_deleteuser += chosen_id;
                    break;
                }
            }
            IfLocked(DeleteWorkerComboBox,DeleteButton);
        }

        private void DeleteButton_Click(object sender, EventArgs e) // usuwanie użytkownika po kliknięciu 'usuń'
        {
            if (WhichUser != "")    // gdy ktoś wybrany
            {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    adapter.Delete(sql_deleteuser);
                    MessageBox.Show("Użytkownik został usunięty");
                    _mainform.AdminPanel_Load(_mainform,e);   // odświeżanie listy z głównego okna admina.
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
        }

        private void IfLocked(ComboBox WhatEmpty, Button WhatLock)
        {
            if (WhatEmpty.Text == "")
                WhatLock.Enabled = false;
            else
                WhatLock.Enabled = true;
        }
    }
}
