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
using System.Net;
using System.Net.Mail;

namespace aquadrom
{
    public partial class AdminPanel : Form
    {
        DBConnector connector = new DBConnector();
        DBAdapter adapter = new DBAdapter();
        string sql = "";
        bool reload;
        public AdminPanel(string login)
        {
            InitializeComponent();
            sql += login;
            reload = false;
        }

        public void AdminPanel_Load(object sender, EventArgs e) // wypelnienie głównego DataTable
        {
            DataTable dtlista = connector.Select("* from "+Constants.TabPracownik+" p,"+Constants.TabUmowa+" u where p."+Constants.PracownikIDUmowy+"=u."+Constants.UmowaIDu+" order by "+Constants.PracownikNazwisko+" asc");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtlista.Columns.Remove(Constants.UmowaIDu);
            dtlista.Columns.Remove(Constants.PracownikIDUmowy);
            dtlista.Columns.Remove(Constants.PracownikHaslo);
            dataGridView1.DataSource = dtlista.DefaultView;
            dataGridView1.Columns[Constants.PracownikOstrzezenieBadania].Visible = false;
            dataGridView1.Columns[Constants.PracownikOstrzezenieKPP].Visible = false;
            dataGridView1.Columns[Constants.PracownikOstrzezenieUmowa].Visible = false;
            ColorCheckUser();

            if (CheckInternetConnection() == false)     // sprawdzanie połączenia internetowego
                PolczenieStripStatus.Text = "Brak połączenia internetowego";
            else
                PolczenieStripStatus.Text = "Połączenie internetowe aktywne";
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UsuńToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(CanOpen()==false)
            {
                DeleteWorker DelWor = new DeleteWorker(this);
                DelWor.Show();
                reload = true;
            }
        }

        private void PrzeglądajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel_Load(this, e);
        }

        private void edytujUżytkownikaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(CanOpen()==false)
            {
                EditWorkerWhich EdWor = new EditWorkerWhich(this);
                EdWor.Show();
            }
        }

        private void DodajUżytkownikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CanOpen() == false)
            {
                Form2 AddWor = new Form2();
                AddWor.Show();
            }
            
        }


        private void ColorCheckUser()       //zaznaczanie na czerwowo użytkowników którym kończą się badania,kpp,umowa
        {
            bool internetcon = CheckInternetConnection();
            bool changeKPP = false;
            bool changemedi = false;
            bool changeconcract = false;
            DateTime today = DateTime.Today.AddDays(7); // jaki okres przed

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                changeKPP = false;
                changemedi = false;
                changeconcract = false;

                DateTime KPPdate;   // if user to KZ (brak KPPdate) to ustala odległą w przyszłość
                if(dataGridView1.Rows[i].Cells[Constants.PracownikWaznKPP].Value.ToString() == "")
                    KPPdate = DateTime.Now.AddYears(99);

                else KPPdate = DateTime.Parse(dataGridView1.Rows[i].Cells[Constants.PracownikWaznKPP].Value.ToString());
                DateTime medicaldate = DateTime.Parse(dataGridView1.Rows[i].Cells[Constants.PracownikDataBadan].Value.ToString());
                DateTime concractdate = DateTime.Parse(dataGridView1.Rows[i].Cells[Constants.UmowaKoniecUmowy].Value.ToString());

                if (today >= KPPdate)
                {
                    dataGridView1.Rows[i].Cells[Constants.PracownikID].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[Constants.PracownikWaznKPP].Style.BackColor = Color.Red;
                    changeKPP = true;
                }
                if (today >= medicaldate)
                {
                    dataGridView1.Rows[i].Cells[Constants.PracownikID].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[Constants.PracownikDataBadan].Style.BackColor = Color.Red;
                    changemedi = true;
                }
                if (today >= concractdate)
                {
                    dataGridView1.Rows[i].Cells[Constants.PracownikID].Style.BackColor = Color.Red;
                    dataGridView1.Rows[i].Cells[Constants.UmowaKoniecUmowy].Style.BackColor = Color.Red;
                    changeconcract = true;
                }
                        // jeśli jest połączenie internetowe oraz jakieś ostrzeżenie to sendmail
                if ( ((changeKPP == true) || (changeconcract == true) || (changemedi == true)) && (internetcon == true) )
                {
                    sendmail(i, KPPdate, changeKPP, medicaldate, changemedi, concractdate, changeconcract);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void sendmail(int iterator, DateTime KPPdate, bool changeKPP, DateTime medicaldate, bool changemedi, DateTime concractdate, bool changeconcract )
        {
            string what = "";

            if ((changeKPP == true) && (dataGridView1.Rows[iterator].Cells[Constants.PracownikOstrzezenieKPP].Value.ToString() == "f"))
            {
                what += "Data ważności KPP: " + KPPdate.ToString("dd-MM-yyyy") + "\n";
                adapter.Update(Constants.TabPracownik + " set " + Constants.PracownikOstrzezenieKPP + "='t' where " + Constants.PracownikID + "=" + dataGridView1.Rows[iterator].Cells[Constants.PracownikID].Value.ToString());
            }
            else if ((changemedi == true) && (dataGridView1.Rows[iterator].Cells[Constants.PracownikOstrzezenieBadania].Value.ToString() == "f"))
            {
                what += "Data ważności badań: " + medicaldate.ToString("dd-MM-yyyy") + "\n";
                adapter.Update(Constants.TabPracownik + " set " + Constants.PracownikOstrzezenieBadania + "='t' where " + Constants.PracownikID + "=" + dataGridView1.Rows[iterator].Cells[Constants.PracownikID].Value.ToString());
            }
            else if ((changeconcract == true) && (dataGridView1.Rows[iterator].Cells[Constants.PracownikOstrzezenieUmowa].Value.ToString() == "f"))
            {
                what += "Data ważności umowy: " + medicaldate.ToString("dd-MM-yyyy") + "\n";
                adapter.Update(Constants.TabPracownik + " set " + Constants.PracownikOstrzezenieUmowa + "='t' where " + Constants.PracownikID + "=" + dataGridView1.Rows[iterator].Cells[Constants.PracownikID].Value.ToString());
            }

            if (what.Length != 0)   // jeśli jest ostrzeżenie i mail nie był jeszcze wysłany to wyślij
            {
                var fromAdress = new MailAddress("aquadromautomat@gmail.com", "System automatycznej informacji");
                var toAdress = new MailAddress("aquadromboss@gmail.com", "Administrator Firmy sMMonpar ");
                const string fromPassword = "aquadrom123";
                string subject = "Ostrzeżenie " + dataGridView1.Rows[iterator].Cells[Constants.PracownikImie].Value.ToString() + " " + dataGridView1.Rows[iterator].Cells[Constants.PracownikNazwisko].Value.ToString();
                string body = "Pracownik: " + dataGridView1.Rows[iterator].Cells[Constants.PracownikImie].Value.ToString() + " " + dataGridView1.Rows[iterator].Cells[Constants.PracownikNazwisko].Value.ToString() + "\n" + what;
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
            }
        }

        private bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            ColorCheckUser();
        }

        private void napiszNotatkęToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GeneratorNotatek notatka = new GeneratorNotatek(sql);
            notatka.Show();
        }

        private void harmonogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CanOpen()==false)
            {
                HarmonogramForm HarmonogramAdmin = new HarmonogramForm(true);
                HarmonogramAdmin.Show();
            }
        }

        private void napiszNotatkęToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CanOpen() == false)
            {
                GeneratorNotatek notatka = new GeneratorNotatek(sql);
                notatka.Show();
            }
        }

        private bool CanOpen()
        {
            if ((DeleteWorker.exist == false) &&
                (EditWorkerWhich.exist == false) &&
                (EditWorker.exist == false) &&
                (HarmonogramForm.exists == false) &&
                (GeneratorNotatek.exist == false) &&
                (Form2.exist == false)
                )
                return false;
            else return true;
        }

        private void ądzajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zmieńHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(sql);
            change.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminPanel_Load(this, e);
            reload = false;
        }
    }
}
