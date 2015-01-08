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
using System.Net;
using System.Net.Mail;

namespace aquadrom
{
    public partial class AdminPanel : Form
    {
        DBConnector connector = new DBConnector();
        DBAdapter adapter = new DBAdapter();
        public AdminPanel()
        {
            InitializeComponent();
        }

        public void AdminPanel_Load(object sender, EventArgs e)
        {
            DataTable dtlista = connector.Select("* from "+Constants.TabPracownik+" p,"+Constants.TabUmowa+" u where p."+Constants.PracownikIDUmowyKol+"=u."+Constants.UmowaIDu);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtlista.Columns.Remove(Constants.UmowaIDu);
            dtlista.Columns.Remove(Constants.PracownikIDUmowyKol);
            dtlista.Columns.Remove(Constants.PracownikHasloKol);
            dataGridView1.DataSource = dtlista.DefaultView;
            dataGridView1.Columns[Constants.PracownikOstrzezenie].Visible = false;
            ColorCheckUser();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( (DeleteWorker.exist==false) && (EditWorkerWhich.exist==false) )  // jeśli okno DeleteWorker,WhichWorker zamknięte to je otwórz else nic
            {
                DeleteWorker DelWor = new DeleteWorker(this);
                DelWor.Show();
            }
        }

        private void PrzeglądajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel_Load(this, e);
        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( (DeleteWorker.exist==false) && (EditWorkerWhich.exist==false) )
            {
                EditWorkerWhich EdWor = new EditWorkerWhich(this);
                EdWor.Show();
            }
        }

        private void ColorCheckUser()
        {
            bool changeKPP = false;
            bool changemedi = false;
            DateTime today = DateTime.Today.AddDays(7); // jaki okres przed

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                changeKPP = false;
                changemedi = false;
                DateTime KPPdate = DateTime.Parse(dataGridView1.Rows[i].Cells[Constants.PracownikWaznKPPKol].Value.ToString());
                DateTime medicaldate = DateTime.Parse(dataGridView1.Rows[i].Cells[Constants.PracownikDataBadanKol].Value.ToString());


                if (today >= KPPdate)
                {
                    dataGridView1.Rows[i].Cells[Constants.PracownikIDpKol].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[Constants.PracownikWaznKPPKol].Style.BackColor = Color.Red;
                    changeKPP = true;
                }

                if (today >= medicaldate)
                {
                    dataGridView1.Rows[i].Cells[Constants.PracownikIDpKol].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[Constants.PracownikDataBadanKol].Style.BackColor = Color.Red;
                    changemedi = true;
                }

                if ( (changeKPP == true) || (changemedi == true) ) 
                {
                    sendmail(i,KPPdate,medicaldate,changeKPP);
                }
                else if (dataGridView1.Rows[i].Cells[Constants.PracownikOstrzezenie].Value.ToString() == "t")
                    adapter.Update(Constants.TabPracownik + " set " + Constants.PracownikOstrzezenie + "='f' where " + Constants.PracownikIDpKol + "=" + dataGridView1.Rows[i].Cells[Constants.PracownikIDpKol].Value.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void sendmail(int iterator, DateTime KPPdate, DateTime medicaldate, bool changeKPP)
        {
            string what = "";
            if (dataGridView1.Rows[iterator].Cells[Constants.PracownikOstrzezenie].Value.ToString() == "f")
            {
                var fromAdress = new MailAddress("aquadromautomat@gmail.com", "System automatycznej informacji");
                var toAdress = new MailAddress("aquadromboss@gmail.com", "Administrator Firmy sMMonpar ");
                const string fromPassword = "aquadrom123";
                string subject = "Ostrzeżenie " + dataGridView1.Rows[iterator].Cells[Constants.PracownikImieKol].Value.ToString() + " " + dataGridView1.Rows[iterator].Cells[Constants.PracownikNazwiskoKol].Value.ToString();

                if (changeKPP == true) what = " Data ważności KPP: " + KPPdate.ToString("dd-MM-yyyy");
                else what = " Data ważności badań lekarskich " + medicaldate.ToString("dd-MM-yyyy");

                string body = "Pracownik: " + dataGridView1.Rows[iterator].Cells[Constants.PracownikImieKol].Value.ToString() + " " + dataGridView1.Rows[iterator].Cells[Constants.PracownikNazwiskoKol].Value.ToString() + "\n" + what;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAdress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAdress, toAdress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                adapter.Update(Constants.TabPracownik + " set " + Constants.PracownikOstrzezenie + "='t' where " + Constants.PracownikIDpKol + "=" + dataGridView1.Rows[iterator].Cells[Constants.PracownikIDpKol].Value.ToString());
            }
        }
    }
}
