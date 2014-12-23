namespace aquadrom
{
    partial class Form2
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
            this.Pracownik = new System.Windows.Forms.GroupBox();
            this.Badania = new System.Windows.Forms.GroupBox();
            this.Stanowisko2 = new System.Windows.Forms.ComboBox();
            this.Stopień = new System.Windows.Forms.ComboBox();
            this.DataMedycynyPRacy = new System.Windows.Forms.TextBox();
            this.DataKPP = new System.Windows.Forms.TextBox();
            this.Data_KPP = new System.Windows.Forms.Label();
            this.Stanowisko = new System.Windows.Forms.Label();
            this.Data_badan = new System.Windows.Forms.Label();
            this.Stopien = new System.Windows.Forms.Label();
            this.Dane_kontaktowe = new System.Windows.Forms.GroupBox();
            this.Email2 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.NumerTelefonu = new System.Windows.Forms.TextBox();
            this.Numer_telefonu = new System.Windows.Forms.Label();
            this.Konto = new System.Windows.Forms.GroupBox();
            this.Haslo2 = new System.Windows.Forms.TextBox();
            this.Login2 = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Dane_umowy = new System.Windows.Forms.GroupBox();
            this.Koniec_umowy = new System.Windows.Forms.Label();
            this.Poczatek_umowy = new System.Windows.Forms.Label();
            this.TypUmowy = new System.Windows.Forms.ComboBox();
            this.Wymiar_godzin = new System.Windows.Forms.Label();
            this.Typ_umowy = new System.Windows.Forms.Label();
            this.KoniecUmowy = new System.Windows.Forms.TextBox();
            this.PoczątekUmowy = new System.Windows.Forms.TextBox();
            this.WymiarGodzin = new System.Windows.Forms.TextBox();
            this.Dane_osobowe = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NumerDomu = new System.Windows.Forms.TextBox();
            this.Ulica2 = new System.Windows.Forms.TextBox();
            this.Miasto2 = new System.Windows.Forms.TextBox();
            this.Pesel2 = new System.Windows.Forms.TextBox();
            this.Nazwisko2 = new System.Windows.Forms.TextBox();
            this.Numer_mieszkania = new System.Windows.Forms.Label();
            this.Imie2 = new System.Windows.Forms.TextBox();
            this.Nr_domu = new System.Windows.Forms.Label();
            this.Ulica = new System.Windows.Forms.Label();
            this.Miasto = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddEmployer = new System.Windows.Forms.Button();
            this.Pracownik.SuspendLayout();
            this.Badania.SuspendLayout();
            this.Dane_kontaktowe.SuspendLayout();
            this.Konto.SuspendLayout();
            this.Dane_umowy.SuspendLayout();
            this.Dane_osobowe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pracownik
            // 
            this.Pracownik.Controls.Add(this.Badania);
            this.Pracownik.Controls.Add(this.Dane_kontaktowe);
            this.Pracownik.Controls.Add(this.Konto);
            this.Pracownik.Controls.Add(this.Dane_umowy);
            this.Pracownik.Controls.Add(this.Dane_osobowe);
            this.Pracownik.Location = new System.Drawing.Point(3, 3);
            this.Pracownik.Name = "Pracownik";
            this.Pracownik.Size = new System.Drawing.Size(532, 404);
            this.Pracownik.TabIndex = 0;
            this.Pracownik.TabStop = false;
            this.Pracownik.Text = "Pracownik";
            // 
            // Badania
            // 
            this.Badania.Controls.Add(this.Stanowisko2);
            this.Badania.Controls.Add(this.Stopień);
            this.Badania.Controls.Add(this.DataMedycynyPRacy);
            this.Badania.Controls.Add(this.DataKPP);
            this.Badania.Controls.Add(this.Data_KPP);
            this.Badania.Controls.Add(this.Stanowisko);
            this.Badania.Controls.Add(this.Data_badan);
            this.Badania.Controls.Add(this.Stopien);
            this.Badania.Location = new System.Drawing.Point(259, 243);
            this.Badania.Name = "Badania";
            this.Badania.Size = new System.Drawing.Size(240, 142);
            this.Badania.TabIndex = 38;
            this.Badania.TabStop = false;
            this.Badania.Text = "Badania i stanowisko";
            // 
            // Stanowisko2
            // 
            this.Stanowisko2.FormattingEnabled = true;
            this.Stanowisko2.Location = new System.Drawing.Point(117, 55);
            this.Stanowisko2.Name = "Stanowisko2";
            this.Stanowisko2.Size = new System.Drawing.Size(104, 21);
            this.Stanowisko2.TabIndex = 32;
            this.Stanowisko2.SelectedIndexChanged += new System.EventHandler(this.Stanowisko2_SelectedIndexChanged);
            // 
            // Stopień
            // 
            this.Stopień.FormattingEnabled = true;
            this.Stopień.Location = new System.Drawing.Point(117, 27);
            this.Stopień.Name = "Stopień";
            this.Stopień.Size = new System.Drawing.Size(104, 21);
            this.Stopień.TabIndex = 31;
            this.Stopień.SelectedIndexChanged += new System.EventHandler(this.Stopień_SelectedIndexChanged);
            // 
            // DataMedycynyPRacy
            // 
            this.DataMedycynyPRacy.Location = new System.Drawing.Point(117, 111);
            this.DataMedycynyPRacy.Name = "DataMedycynyPRacy";
            this.DataMedycynyPRacy.Size = new System.Drawing.Size(104, 20);
            this.DataMedycynyPRacy.TabIndex = 30;
            // 
            // DataKPP
            // 
            this.DataKPP.Location = new System.Drawing.Point(117, 82);
            this.DataKPP.Name = "DataKPP";
            this.DataKPP.Size = new System.Drawing.Size(104, 20);
            this.DataKPP.TabIndex = 29;
            // 
            // Data_KPP
            // 
            this.Data_KPP.AutoSize = true;
            this.Data_KPP.Location = new System.Drawing.Point(7, 85);
            this.Data_KPP.Name = "Data_KPP";
            this.Data_KPP.Size = new System.Drawing.Size(104, 13);
            this.Data_KPP.TabIndex = 10;
            this.Data_KPP.Text = "Data ważności KPP:";
            // 
            // Stanowisko
            // 
            this.Stanowisko.AutoSize = true;
            this.Stanowisko.Location = new System.Drawing.Point(7, 56);
            this.Stanowisko.Name = "Stanowisko";
            this.Stanowisko.Size = new System.Drawing.Size(65, 13);
            this.Stanowisko.TabIndex = 9;
            this.Stanowisko.Text = "Stanowisko:";
            // 
            // Data_badan
            // 
            this.Data_badan.AutoSize = true;
            this.Data_badan.Location = new System.Drawing.Point(7, 114);
            this.Data_badan.Name = "Data_badan";
            this.Data_badan.Size = new System.Drawing.Size(66, 13);
            this.Data_badan.TabIndex = 11;
            this.Data_badan.Text = "Data badań:";
            // 
            // Stopien
            // 
            this.Stopien.AutoSize = true;
            this.Stopien.Location = new System.Drawing.Point(7, 27);
            this.Stopien.Name = "Stopien";
            this.Stopien.Size = new System.Drawing.Size(46, 13);
            this.Stopien.TabIndex = 12;
            this.Stopien.Text = "Stopień:";
            // 
            // Dane_kontaktowe
            // 
            this.Dane_kontaktowe.Controls.Add(this.Email2);
            this.Dane_kontaktowe.Controls.Add(this.Email);
            this.Dane_kontaktowe.Controls.Add(this.NumerTelefonu);
            this.Dane_kontaktowe.Controls.Add(this.Numer_telefonu);
            this.Dane_kontaktowe.Location = new System.Drawing.Point(9, 194);
            this.Dane_kontaktowe.Name = "Dane_kontaktowe";
            this.Dane_kontaktowe.Size = new System.Drawing.Size(231, 81);
            this.Dane_kontaktowe.TabIndex = 37;
            this.Dane_kontaktowe.TabStop = false;
            this.Dane_kontaktowe.Text = "Dane kontaktowe";
            // 
            // Email2
            // 
            this.Email2.Location = new System.Drawing.Point(108, 46);
            this.Email2.Name = "Email2";
            this.Email2.Size = new System.Drawing.Size(104, 20);
            this.Email2.TabIndex = 22;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 49);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "E-mail:";
            // 
            // NumerTelefonu
            // 
            this.NumerTelefonu.Location = new System.Drawing.Point(108, 20);
            this.NumerTelefonu.Name = "NumerTelefonu";
            this.NumerTelefonu.Size = new System.Drawing.Size(104, 20);
            this.NumerTelefonu.TabIndex = 28;
            this.NumerTelefonu.TextChanged += new System.EventHandler(this.NumerTelefonu_TextChanged);
            // 
            // Numer_telefonu
            // 
            this.Numer_telefonu.AutoSize = true;
            this.Numer_telefonu.Location = new System.Drawing.Point(6, 23);
            this.Numer_telefonu.Name = "Numer_telefonu";
            this.Numer_telefonu.Size = new System.Drawing.Size(82, 13);
            this.Numer_telefonu.TabIndex = 8;
            this.Numer_telefonu.Text = "Numer telefonu:";
            // 
            // Konto
            // 
            this.Konto.Controls.Add(this.Haslo2);
            this.Konto.Controls.Add(this.Login2);
            this.Konto.Controls.Add(this.Haslo);
            this.Konto.Controls.Add(this.Login);
            this.Konto.Location = new System.Drawing.Point(9, 309);
            this.Konto.Name = "Konto";
            this.Konto.Size = new System.Drawing.Size(231, 76);
            this.Konto.TabIndex = 36;
            this.Konto.TabStop = false;
            this.Konto.Text = "Konto";
            // 
            // Haslo2
            // 
            this.Haslo2.Location = new System.Drawing.Point(110, 45);
            this.Haslo2.Name = "Haslo2";
            this.Haslo2.Size = new System.Drawing.Size(104, 20);
            this.Haslo2.TabIndex = 16;
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(110, 19);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(104, 20);
            this.Login2.TabIndex = 15;
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Location = new System.Drawing.Point(6, 48);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(36, 13);
            this.Haslo.TabIndex = 14;
            this.Haslo.Text = "Hasło";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(6, 22);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(36, 13);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login:";
            // 
            // Dane_umowy
            // 
            this.Dane_umowy.Controls.Add(this.Koniec_umowy);
            this.Dane_umowy.Controls.Add(this.Poczatek_umowy);
            this.Dane_umowy.Controls.Add(this.TypUmowy);
            this.Dane_umowy.Controls.Add(this.Wymiar_godzin);
            this.Dane_umowy.Controls.Add(this.Typ_umowy);
            this.Dane_umowy.Controls.Add(this.KoniecUmowy);
            this.Dane_umowy.Controls.Add(this.PoczątekUmowy);
            this.Dane_umowy.Controls.Add(this.WymiarGodzin);
            this.Dane_umowy.Location = new System.Drawing.Point(9, 21);
            this.Dane_umowy.Name = "Dane_umowy";
            this.Dane_umowy.Size = new System.Drawing.Size(231, 130);
            this.Dane_umowy.TabIndex = 35;
            this.Dane_umowy.TabStop = false;
            this.Dane_umowy.Text = "Dane umowy";
            // 
            // Koniec_umowy
            // 
            this.Koniec_umowy.AutoSize = true;
            this.Koniec_umowy.Location = new System.Drawing.Point(6, 105);
            this.Koniec_umowy.Name = "Koniec_umowy";
            this.Koniec_umowy.Size = new System.Drawing.Size(79, 13);
            this.Koniec_umowy.TabIndex = 33;
            this.Koniec_umowy.Text = "Koniec umowy:";
            // 
            // Poczatek_umowy
            // 
            this.Poczatek_umowy.AutoSize = true;
            this.Poczatek_umowy.Location = new System.Drawing.Point(6, 76);
            this.Poczatek_umowy.Name = "Poczatek_umowy";
            this.Poczatek_umowy.Size = new System.Drawing.Size(91, 13);
            this.Poczatek_umowy.TabIndex = 32;
            this.Poczatek_umowy.Text = "Początek umowy:";
            // 
            // TypUmowy
            // 
            this.TypUmowy.FormattingEnabled = true;
            this.TypUmowy.Location = new System.Drawing.Point(110, 18);
            this.TypUmowy.Name = "TypUmowy";
            this.TypUmowy.Size = new System.Drawing.Size(104, 21);
            this.TypUmowy.TabIndex = 31;
            this.TypUmowy.SelectedIndexChanged += new System.EventHandler(this.TypUmowy_SelectedIndexChanged);
            // 
            // Wymiar_godzin
            // 
            this.Wymiar_godzin.AutoSize = true;
            this.Wymiar_godzin.Location = new System.Drawing.Point(6, 48);
            this.Wymiar_godzin.Name = "Wymiar_godzin";
            this.Wymiar_godzin.Size = new System.Drawing.Size(79, 13);
            this.Wymiar_godzin.TabIndex = 30;
            this.Wymiar_godzin.Text = "Wymiar godzin:";
            // 
            // Typ_umowy
            // 
            this.Typ_umowy.AutoSize = true;
            this.Typ_umowy.Location = new System.Drawing.Point(6, 22);
            this.Typ_umowy.Name = "Typ_umowy";
            this.Typ_umowy.Size = new System.Drawing.Size(64, 13);
            this.Typ_umowy.TabIndex = 29;
            this.Typ_umowy.Text = "Typ umowy:";
            // 
            // KoniecUmowy
            // 
            this.KoniecUmowy.Location = new System.Drawing.Point(110, 102);
            this.KoniecUmowy.Name = "KoniecUmowy";
            this.KoniecUmowy.Size = new System.Drawing.Size(104, 20);
            this.KoniecUmowy.TabIndex = 18;
            // 
            // PoczątekUmowy
            // 
            this.PoczątekUmowy.Location = new System.Drawing.Point(110, 73);
            this.PoczątekUmowy.Name = "PoczątekUmowy";
            this.PoczątekUmowy.Size = new System.Drawing.Size(104, 20);
            this.PoczątekUmowy.TabIndex = 17;
            // 
            // WymiarGodzin
            // 
            this.WymiarGodzin.Location = new System.Drawing.Point(110, 45);
            this.WymiarGodzin.Name = "WymiarGodzin";
            this.WymiarGodzin.Size = new System.Drawing.Size(104, 20);
            this.WymiarGodzin.TabIndex = 16;
            // 
            // Dane_osobowe
            // 
            this.Dane_osobowe.Controls.Add(this.numericUpDown1);
            this.Dane_osobowe.Controls.Add(this.NumerDomu);
            this.Dane_osobowe.Controls.Add(this.Ulica2);
            this.Dane_osobowe.Controls.Add(this.Miasto2);
            this.Dane_osobowe.Controls.Add(this.Pesel2);
            this.Dane_osobowe.Controls.Add(this.Nazwisko2);
            this.Dane_osobowe.Controls.Add(this.Numer_mieszkania);
            this.Dane_osobowe.Controls.Add(this.Imie2);
            this.Dane_osobowe.Controls.Add(this.Nr_domu);
            this.Dane_osobowe.Controls.Add(this.Ulica);
            this.Dane_osobowe.Controls.Add(this.Miasto);
            this.Dane_osobowe.Controls.Add(this.Pesel);
            this.Dane_osobowe.Controls.Add(this.Nazwisko);
            this.Dane_osobowe.Controls.Add(this.Imie);
            this.Dane_osobowe.Location = new System.Drawing.Point(258, 21);
            this.Dane_osobowe.Name = "Dane_osobowe";
            this.Dane_osobowe.Size = new System.Drawing.Size(241, 209);
            this.Dane_osobowe.TabIndex = 34;
            this.Dane_osobowe.TabStop = false;
            this.Dane_osobowe.Text = "Dane osobowe";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 183);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 27;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // NumerDomu
            // 
            this.NumerDomu.Location = new System.Drawing.Point(118, 155);
            this.NumerDomu.Name = "NumerDomu";
            this.NumerDomu.Size = new System.Drawing.Size(104, 20);
            this.NumerDomu.TabIndex = 25;
            // 
            // Ulica2
            // 
            this.Ulica2.Location = new System.Drawing.Point(118, 129);
            this.Ulica2.Name = "Ulica2";
            this.Ulica2.Size = new System.Drawing.Size(104, 20);
            this.Ulica2.TabIndex = 24;
            this.Ulica2.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // Miasto2
            // 
            this.Miasto2.Location = new System.Drawing.Point(118, 101);
            this.Miasto2.Name = "Miasto2";
            this.Miasto2.Size = new System.Drawing.Size(104, 20);
            this.Miasto2.TabIndex = 23;
            // 
            // Pesel2
            // 
            this.Pesel2.Location = new System.Drawing.Point(118, 75);
            this.Pesel2.Name = "Pesel2";
            this.Pesel2.Size = new System.Drawing.Size(104, 20);
            this.Pesel2.TabIndex = 21;
            // 
            // Nazwisko2
            // 
            this.Nazwisko2.Location = new System.Drawing.Point(118, 49);
            this.Nazwisko2.Name = "Nazwisko2";
            this.Nazwisko2.Size = new System.Drawing.Size(104, 20);
            this.Nazwisko2.TabIndex = 20;
            // 
            // Numer_mieszkania
            // 
            this.Numer_mieszkania.AutoSize = true;
            this.Numer_mieszkania.Location = new System.Drawing.Point(6, 184);
            this.Numer_mieszkania.Name = "Numer_mieszkania";
            this.Numer_mieszkania.Size = new System.Drawing.Size(96, 13);
            this.Numer_mieszkania.TabIndex = 7;
            this.Numer_mieszkania.Text = "Numer mieszkania:";
            // 
            // Imie2
            // 
            this.Imie2.Location = new System.Drawing.Point(118, 23);
            this.Imie2.Name = "Imie2";
            this.Imie2.Size = new System.Drawing.Size(104, 20);
            this.Imie2.TabIndex = 19;
            // 
            // Nr_domu
            // 
            this.Nr_domu.AutoSize = true;
            this.Nr_domu.Location = new System.Drawing.Point(6, 158);
            this.Nr_domu.Name = "Nr_domu";
            this.Nr_domu.Size = new System.Drawing.Size(50, 13);
            this.Nr_domu.TabIndex = 6;
            this.Nr_domu.Text = "Nr domu:";
            // 
            // Ulica
            // 
            this.Ulica.AutoSize = true;
            this.Ulica.Location = new System.Drawing.Point(6, 132);
            this.Ulica.Name = "Ulica";
            this.Ulica.Size = new System.Drawing.Size(34, 13);
            this.Ulica.TabIndex = 5;
            this.Ulica.Text = "Ulica:";
            // 
            // Miasto
            // 
            this.Miasto.AutoSize = true;
            this.Miasto.Location = new System.Drawing.Point(6, 104);
            this.Miasto.Name = "Miasto";
            this.Miasto.Size = new System.Drawing.Size(41, 13);
            this.Miasto.TabIndex = 4;
            this.Miasto.Text = "Miasto:";
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
            this.Imie.Location = new System.Drawing.Point(6, 23);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(29, 13);
            this.Imie.TabIndex = 0;
            this.Imie.Text = "Imię:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(460, 413);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEmployer
            // 
            this.AddEmployer.Location = new System.Drawing.Point(326, 413);
            this.AddEmployer.Name = "AddEmployer";
            this.AddEmployer.Size = new System.Drawing.Size(128, 23);
            this.AddEmployer.TabIndex = 2;
            this.AddEmployer.Text = "Dodaj pracownika";
            this.AddEmployer.UseVisualStyleBackColor = true;
            this.AddEmployer.Click += new System.EventHandler(this.AddEmployer_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 441);
            this.Controls.Add(this.AddEmployer);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Pracownik);
            this.Name = "Form2";
            this.Text = "Dodaj pracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Pracownik.ResumeLayout(false);
            this.Badania.ResumeLayout(false);
            this.Badania.PerformLayout();
            this.Dane_kontaktowe.ResumeLayout(false);
            this.Dane_kontaktowe.PerformLayout();
            this.Konto.ResumeLayout(false);
            this.Konto.PerformLayout();
            this.Dane_umowy.ResumeLayout(false);
            this.Dane_umowy.PerformLayout();
            this.Dane_osobowe.ResumeLayout(false);
            this.Dane_osobowe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pracownik;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddEmployer;
        private System.Windows.Forms.TextBox WymiarGodzin;
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Stopien;
        private System.Windows.Forms.Label Data_badan;
        private System.Windows.Forms.Label Data_KPP;
        private System.Windows.Forms.Label Stanowisko;
        private System.Windows.Forms.Label Numer_telefonu;
        private System.Windows.Forms.Label Numer_mieszkania;
        private System.Windows.Forms.Label Nr_domu;
        private System.Windows.Forms.Label Ulica;
        private System.Windows.Forms.Label Miasto;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Pesel;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label Wymiar_godzin;
        private System.Windows.Forms.Label Typ_umowy;
        private System.Windows.Forms.TextBox NumerTelefonu;
        private System.Windows.Forms.TextBox NumerDomu;
        private System.Windows.Forms.TextBox Ulica2;
        private System.Windows.Forms.TextBox Miasto2;
        private System.Windows.Forms.TextBox Email2;
        private System.Windows.Forms.TextBox Pesel2;
        private System.Windows.Forms.TextBox Nazwisko2;
        private System.Windows.Forms.TextBox Imie2;
        private System.Windows.Forms.TextBox KoniecUmowy;
        private System.Windows.Forms.TextBox PoczątekUmowy;
        private System.Windows.Forms.Label Koniec_umowy;
        private System.Windows.Forms.Label Poczatek_umowy;
        private System.Windows.Forms.ComboBox TypUmowy;
        private System.Windows.Forms.GroupBox Dane_kontaktowe;
        private System.Windows.Forms.GroupBox Konto;
        private System.Windows.Forms.TextBox Haslo2;
        private System.Windows.Forms.TextBox Login2;
        private System.Windows.Forms.GroupBox Dane_umowy;
        private System.Windows.Forms.GroupBox Dane_osobowe;
        private System.Windows.Forms.GroupBox Badania;
        private System.Windows.Forms.ComboBox Stanowisko2;
        private System.Windows.Forms.ComboBox Stopień;
        private System.Windows.Forms.TextBox DataMedycynyPRacy;
        private System.Windows.Forms.TextBox DataKPP;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}