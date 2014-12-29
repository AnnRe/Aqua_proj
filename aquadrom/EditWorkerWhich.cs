﻿using System;
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

namespace aquadrom
{
    public partial class EditWorkerWhich : Form
    {
        DBAdapter adapter = new DBAdapter();
        DBConnector connector = new DBConnector();
        public static bool exist = false;
        private AdminPanel _mainform = null;

        private string chosen_id = "";
        private string WhichUser = "";
        private string sql_edituser = "from Pracownik where " + Constants.PracownikIDpKol + "=";
        public EditWorkerWhich(Form callingForm)
        {
            _mainform = callingForm as AdminPanel;
            InitializeComponent();
            exist = true;
        }

        public void EditWorkerWhich_Load(object sender, EventArgs e)
        {
            DataTable dtWorkers = connector.Select(Constants.PracownikIDpKol + ", concat(" + Constants.PracownikNazwiskoKol + ",' '," + Constants.PracownikImieKol + ") from Pracownik order by 2 asc;");
            foreach (DataRow row in dtWorkers.Rows)
            {
                EditWorkerComboBox.Items.Add(row[1].ToString());
            }
        }

        private void EditWorkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {                                                    
            WhichUser = this.EditWorkerComboBox.Text;
            DataTable dtWorkers2 = connector.Select(Constants.PracownikIDpKol + ", concat(" + Constants.PracownikNazwiskoKol + ",' '," + Constants.PracownikImieKol + ") from Pracownik order by 2 asc;");
            foreach (DataRow row in dtWorkers2.Rows)
            {
                if (row[1].ToString() == WhichUser)
                {
                    if (chosen_id != "")
                    {
                        sql_edituser = sql_edituser.Remove(sql_edituser.Length - chosen_id.Length);
                    }
                    chosen_id = row[0].ToString();
                    sql_edituser += chosen_id;
                    break;
                }
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (EditWorkerComboBox.Text != "")
            {
                if ((DeleteWorker.exist == false) && (EditWorkerWhich.exist == false))  // jeśli okno DeleteWorker,WhichWorker zamknięte to je otwórz else nic
                {
                    DeleteWorker DelWor = new DeleteWorker(this);
                    DelWor.Show();
                }
            }
            else this.Close();
        }

        private void EditWorkerWhich_FormClosing(object sender, FormClosingEventArgs e)
        {
            exist = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}