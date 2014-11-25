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
        public static bool exist = false;
        private string chosen_id = "";
        private string WhichUser = "";
        private string sql_deleteuser = "from Pracownik where ID_p=";
        public DeleteWorker()
        {
            InitializeComponent();
            exist = true;
        }

        private void DeleteWorker_Load(object sender, EventArgs e)
        {
            string sql_workers = "select ID_p, concat(Nazwisko,' ',Imie) from Pracownik order by 2 asc;";
            DataTable dtWorkers = adapter.GetData(sql_workers);

            foreach (DataRow row in dtWorkers.Rows)
            {
                DeleteWorkerComboBox.Items.Add(row[1].ToString());
            }
        }

        private void DeleteWorkerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WhichUser = this.DeleteWorkerComboBox.Text;
            string sql_workers = "select ID_p, concat(Nazwisko,' ',Imie) from Pracownik order by 2 asc;";
            DataTable dtWorkers = adapter.GetData(sql_workers);

            foreach (DataRow row in dtWorkers.Rows)
            {
                if (row[1].ToString() == WhichUser)
                {
                    if (chosen_id != "")
                    {
                        sql_deleteuser = sql_deleteuser.Remove(sql_deleteuser.Length - chosen_id.Length);
                    }
                    chosen_id = row[0].ToString();
                    sql_deleteuser += chosen_id;
                    MessageBox.Show(chosen_id);
                    break;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (WhichUser != "")
            {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    adapter.Delete(sql_deleteuser);
                    MessageBox.Show("Użytkownik został usunięty");
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
    }
}
