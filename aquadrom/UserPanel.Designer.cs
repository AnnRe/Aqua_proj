namespace aquadrom
{
    partial class UserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.harmonogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PolaczenieStripStatusU = new System.Windows.Forms.StatusStrip();
            this.PolaczenieStripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dane_osobowe = new System.Windows.Forms.GroupBox();
            this.Data_KPP = new System.Windows.Forms.Label();
            this.Data_badan = new System.Windows.Forms.Label();
            this.Koniec_umowy = new System.Windows.Forms.Label();
            this.Poczatek_umowy = new System.Windows.Forms.Label();
            this.PeselUzytkownika = new System.Windows.Forms.TextBox();
            this.NazwiskoUzytkownika = new System.Windows.Forms.TextBox();
            this.ImieUzytkownika = new System.Windows.Forms.TextBox();
            this.Pesel = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.Label();
            this.PoczatekUmowyTextBox = new System.Windows.Forms.TextBox();
            this.KoniecUmowyTextBox = new System.Windows.Forms.TextBox();
            this.WaznoscKPPTextBox = new System.Windows.Forms.TextBox();
            this.DataBadanTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.PolaczenieStripStatusU.SuspendLayout();
            this.Dane_osobowe.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harmonogramToolStripMenuItem,
            this.notatkiToolStripMenuItem,
            this.daneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // harmonogramToolStripMenuItem
            // 
            this.harmonogramToolStripMenuItem.Name = "harmonogramToolStripMenuItem";
            this.harmonogramToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.harmonogramToolStripMenuItem.Text = "Harmonogram";
            this.harmonogramToolStripMenuItem.Click += new System.EventHandler(this.harmonogramToolStripMenuItem_Click);
            // 
            // notatkiToolStripMenuItem
            // 
            this.notatkiToolStripMenuItem.Name = "notatkiToolStripMenuItem";
            this.notatkiToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.notatkiToolStripMenuItem.Text = "Napisz notatkę";
            this.notatkiToolStripMenuItem.Click += new System.EventHandler(this.notatkiToolStripMenuItem_Click);
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.daneToolStripMenuItem.Text = "Zmień hasło";
            this.daneToolStripMenuItem.Click += new System.EventHandler(this.daneToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PolaczenieStripStatusU
            // 
            this.PolaczenieStripStatusU.BackColor = System.Drawing.Color.LightCyan;
            this.PolaczenieStripStatusU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PolaczenieStripUser});
            this.PolaczenieStripStatusU.Location = new System.Drawing.Point(0, 209);
            this.PolaczenieStripStatusU.Name = "PolaczenieStripStatusU";
            this.PolaczenieStripStatusU.Size = new System.Drawing.Size(488, 22);
            this.PolaczenieStripStatusU.TabIndex = 2;
            this.PolaczenieStripStatusU.Text = "statusStrip1";
            // 
            // PolaczenieStripUser
            // 
            this.PolaczenieStripUser.Name = "PolaczenieStripUser";
            this.PolaczenieStripUser.Size = new System.Drawing.Size(63, 17);
            this.PolaczenieStripUser.Text = "Połączenie";
            // 
            // Dane_osobowe
            // 
            this.Dane_osobowe.BackColor = System.Drawing.Color.LightCyan;
            this.Dane_osobowe.Controls.Add(this.DataBadanTextBox);
            this.Dane_osobowe.Controls.Add(this.WaznoscKPPTextBox);
            this.Dane_osobowe.Controls.Add(this.KoniecUmowyTextBox);
            this.Dane_osobowe.Controls.Add(this.PoczatekUmowyTextBox);
            this.Dane_osobowe.Controls.Add(this.Data_KPP);
            this.Dane_osobowe.Controls.Add(this.Data_badan);
            this.Dane_osobowe.Controls.Add(this.Koniec_umowy);
            this.Dane_osobowe.Controls.Add(this.Poczatek_umowy);
            this.Dane_osobowe.Controls.Add(this.PeselUzytkownika);
            this.Dane_osobowe.Controls.Add(this.NazwiskoUzytkownika);
            this.Dane_osobowe.Controls.Add(this.ImieUzytkownika);
            this.Dane_osobowe.Controls.Add(this.Pesel);
            this.Dane_osobowe.Controls.Add(this.Nazwisko);
            this.Dane_osobowe.Controls.Add(this.Imie);
            this.Dane_osobowe.Location = new System.Drawing.Point(12, 42);
            this.Dane_osobowe.Name = "Dane_osobowe";
            this.Dane_osobowe.Size = new System.Drawing.Size(464, 142);
            this.Dane_osobowe.TabIndex = 35;
            this.Dane_osobowe.TabStop = false;
            this.Dane_osobowe.Text = "Dane osobowe";
            // 
            // Data_KPP
            // 
            this.Data_KPP.AutoSize = true;
            this.Data_KPP.Location = new System.Drawing.Point(214, 77);
            this.Data_KPP.Name = "Data_KPP";
            this.Data_KPP.Size = new System.Drawing.Size(79, 13);
            this.Data_KPP.TabIndex = 38;
            this.Data_KPP.Text = "Ważność KPP:";
            // 
            // Data_badan
            // 
            this.Data_badan.AutoSize = true;
            this.Data_badan.Location = new System.Drawing.Point(214, 106);
            this.Data_badan.Name = "Data_badan";
            this.Data_badan.Size = new System.Drawing.Size(66, 13);
            this.Data_badan.TabIndex = 39;
            this.Data_badan.Text = "Data badań:";
            // 
            // Koniec_umowy
            // 
            this.Koniec_umowy.AutoSize = true;
            this.Koniec_umowy.Location = new System.Drawing.Point(210, 52);
            this.Koniec_umowy.Name = "Koniec_umowy";
            this.Koniec_umowy.Size = new System.Drawing.Size(79, 13);
            this.Koniec_umowy.TabIndex = 37;
            this.Koniec_umowy.Text = "Koniec umowy:";
            // 
            // Poczatek_umowy
            // 
            this.Poczatek_umowy.AutoSize = true;
            this.Poczatek_umowy.Location = new System.Drawing.Point(210, 26);
            this.Poczatek_umowy.Name = "Poczatek_umowy";
            this.Poczatek_umowy.Size = new System.Drawing.Size(91, 13);
            this.Poczatek_umowy.TabIndex = 36;
            this.Poczatek_umowy.Text = "Początek umowy:";
            // 
            // PeselUzytkownika
            // 
            this.PeselUzytkownika.Enabled = false;
            this.PeselUzytkownika.Location = new System.Drawing.Point(71, 75);
            this.PeselUzytkownika.MaxLength = 11;
            this.PeselUzytkownika.Name = "PeselUzytkownika";
            this.PeselUzytkownika.Size = new System.Drawing.Size(122, 20);
            this.PeselUzytkownika.TabIndex = 8;
            // 
            // NazwiskoUzytkownika
            // 
            this.NazwiskoUzytkownika.Enabled = false;
            this.NazwiskoUzytkownika.Location = new System.Drawing.Point(71, 49);
            this.NazwiskoUzytkownika.MaxLength = 50;
            this.NazwiskoUzytkownika.Name = "NazwiskoUzytkownika";
            this.NazwiskoUzytkownika.Size = new System.Drawing.Size(122, 20);
            this.NazwiskoUzytkownika.TabIndex = 7;
            // 
            // ImieUzytkownika
            // 
            this.ImieUzytkownika.Enabled = false;
            this.ImieUzytkownika.Location = new System.Drawing.Point(71, 23);
            this.ImieUzytkownika.MaxLength = 50;
            this.ImieUzytkownika.Name = "ImieUzytkownika";
            this.ImieUzytkownika.Size = new System.Drawing.Size(122, 20);
            this.ImieUzytkownika.TabIndex = 6;
            // 
            // Pesel
            // 
            this.Pesel.AutoSize = true;
            this.Pesel.Location = new System.Drawing.Point(6, 78);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(36, 13);
            this.Pesel.TabIndex = 2;
            this.Pesel.Text = "Pesel:";
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.Location = new System.Drawing.Point(6, 52);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(56, 13);
            this.Nazwisko.TabIndex = 1;
            this.Nazwisko.Text = "Nazwisko:";
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Location = new System.Drawing.Point(6, 26);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(29, 13);
            this.Imie.TabIndex = 0;
            this.Imie.Text = "Imię:";
            // 
            // PoczatekUmowyTextBox
            // 
            this.PoczatekUmowyTextBox.Enabled = false;
            this.PoczatekUmowyTextBox.Location = new System.Drawing.Point(304, 19);
            this.PoczatekUmowyTextBox.MaxLength = 50;
            this.PoczatekUmowyTextBox.Name = "PoczatekUmowyTextBox";
            this.PoczatekUmowyTextBox.Size = new System.Drawing.Size(148, 20);
            this.PoczatekUmowyTextBox.TabIndex = 42;
            // 
            // KoniecUmowyTextBox
            // 
            this.KoniecUmowyTextBox.Enabled = false;
            this.KoniecUmowyTextBox.Location = new System.Drawing.Point(304, 49);
            this.KoniecUmowyTextBox.MaxLength = 50;
            this.KoniecUmowyTextBox.Name = "KoniecUmowyTextBox";
            this.KoniecUmowyTextBox.Size = new System.Drawing.Size(148, 20);
            this.KoniecUmowyTextBox.TabIndex = 43;
            // 
            // WaznoscKPPTextBox
            // 
            this.WaznoscKPPTextBox.Enabled = false;
            this.WaznoscKPPTextBox.Location = new System.Drawing.Point(304, 75);
            this.WaznoscKPPTextBox.MaxLength = 50;
            this.WaznoscKPPTextBox.Name = "WaznoscKPPTextBox";
            this.WaznoscKPPTextBox.Size = new System.Drawing.Size(148, 20);
            this.WaznoscKPPTextBox.TabIndex = 44;
            // 
            // DataBadanTextBox
            // 
            this.DataBadanTextBox.Enabled = false;
            this.DataBadanTextBox.Location = new System.Drawing.Point(304, 103);
            this.DataBadanTextBox.MaxLength = 50;
            this.DataBadanTextBox.Name = "DataBadanTextBox";
            this.DataBadanTextBox.Size = new System.Drawing.Size(148, 20);
            this.DataBadanTextBox.TabIndex = 45;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::aquadrom.Properties.Resources.bg_page;
            this.ClientSize = new System.Drawing.Size(488, 231);
            this.Controls.Add(this.Dane_osobowe);
            this.Controls.Add(this.PolaczenieStripStatusU);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPanel_FormClosing_1);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PolaczenieStripStatusU.ResumeLayout(false);
            this.PolaczenieStripStatusU.PerformLayout();
            this.Dane_osobowe.ResumeLayout(false);
            this.Dane_osobowe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem harmonogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wyświetlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.StatusStrip PolaczenieStripStatusU;
        private System.Windows.Forms.ToolStripStatusLabel PolaczenieStripUser;
        private System.Windows.Forms.GroupBox Dane_osobowe;
        private System.Windows.Forms.TextBox PeselUzytkownika;
        private System.Windows.Forms.TextBox NazwiskoUzytkownika;
        private System.Windows.Forms.TextBox ImieUzytkownika;
        private System.Windows.Forms.Label Pesel;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label Koniec_umowy;
        private System.Windows.Forms.Label Poczatek_umowy;
        private System.Windows.Forms.Label Data_KPP;
        private System.Windows.Forms.Label Data_badan;
        private System.Windows.Forms.TextBox DataBadanTextBox;
        private System.Windows.Forms.TextBox WaznoscKPPTextBox;
        private System.Windows.Forms.TextBox KoniecUmowyTextBox;
        private System.Windows.Forms.TextBox PoczatekUmowyTextBox;
    }
}