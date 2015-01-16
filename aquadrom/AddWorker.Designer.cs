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
            this.Anuluj = new System.Windows.Forms.Button();
            this.AddEmployer = new System.Windows.Forms.Button();
            this.Badania = new System.Windows.Forms.GroupBox();
            this.NrUmowy = new System.Windows.Forms.NumericUpDown();
            this.NumerUmowy = new System.Windows.Forms.Label();
            this.DataBadan = new System.Windows.Forms.DateTimePicker();
            this.KoniecKPP = new System.Windows.Forms.DateTimePicker();
            this.StanowiskoUzytkownika = new System.Windows.Forms.ComboBox();
            this.Stopień = new System.Windows.Forms.ComboBox();
            this.Data_KPP = new System.Windows.Forms.Label();
            this.Stanowisko = new System.Windows.Forms.Label();
            this.Data_badan = new System.Windows.Forms.Label();
            this.Stopien = new System.Windows.Forms.Label();
            this.Dane_kontaktowe = new System.Windows.Forms.GroupBox();
            this.AdresEmail = new System.Windows.Forms.TextBox();
            this.NumerTelefonu = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Numer_telefonu = new System.Windows.Forms.Label();
            this.Konto = new System.Windows.Forms.GroupBox();
            this.TypKonta2 = new System.Windows.Forms.ComboBox();
            this.TypKonta = new System.Windows.Forms.Label();
            this.HasloUzytkownika = new System.Windows.Forms.TextBox();
            this.LoginUzytkownika = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Dane_umowy = new System.Windows.Forms.GroupBox();
            this.StwórzUmowe = new System.Windows.Forms.Button();
            this.KoniecUmowy = new System.Windows.Forms.DateTimePicker();
            this.PoczatekUmowy = new System.Windows.Forms.DateTimePicker();
            this.WymiarGodzin = new System.Windows.Forms.NumericUpDown();
            this.TypUmowy = new System.Windows.Forms.ComboBox();
            this.Koniec_umowy = new System.Windows.Forms.Label();
            this.Poczatek_umowy = new System.Windows.Forms.Label();
            this.Wymiar_godzin = new System.Windows.Forms.Label();
            this.Typ_umowy = new System.Windows.Forms.Label();
            this.Dane_osobowe = new System.Windows.Forms.GroupBox();
            this.NumerMieszkania = new System.Windows.Forms.NumericUpDown();
            this.NumerDomu = new System.Windows.Forms.TextBox();
            this.UlicaUzytkownika = new System.Windows.Forms.TextBox();
            this.MiastoUzytkownika = new System.Windows.Forms.TextBox();
            this.PeselUzytkownika = new System.Windows.Forms.TextBox();
            this.NazwiskoUzytkownika = new System.Windows.Forms.TextBox();
            this.ImieUzytkownika = new System.Windows.Forms.TextBox();
            this.Numer_mieszkania = new System.Windows.Forms.Label();
            this.Nr_domu = new System.Windows.Forms.Label();
            this.Ulica = new System.Windows.Forms.Label();
            this.Miasto = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.Label();
            this.Pracownik.SuspendLayout();
            this.Badania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrUmowy)).BeginInit();
            this.Dane_kontaktowe.SuspendLayout();
            this.Konto.SuspendLayout();
            this.Dane_umowy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WymiarGodzin)).BeginInit();
            this.Dane_osobowe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumerMieszkania)).BeginInit();
            this.SuspendLayout();
            // 
            // Pracownik
            // 
            this.Pracownik.Controls.Add(this.Anuluj);
            this.Pracownik.Controls.Add(this.AddEmployer);
            this.Pracownik.Controls.Add(this.Badania);
            this.Pracownik.Controls.Add(this.Dane_kontaktowe);
            this.Pracownik.Controls.Add(this.Konto);
            this.Pracownik.Controls.Add(this.Dane_umowy);
            this.Pracownik.Controls.Add(this.Dane_osobowe);
            this.Pracownik.Location = new System.Drawing.Point(3, 3);
            this.Pracownik.Name = "Pracownik";
            this.Pracownik.Size = new System.Drawing.Size(583, 459);
            this.Pracownik.TabIndex = 0;
            this.Pracownik.TabStop = false;
            this.Pracownik.Text = "Pracownik";
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(488, 427);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 1;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddEmployer
            // 
            this.AddEmployer.Location = new System.Drawing.Point(354, 427);
            this.AddEmployer.Name = "AddEmployer";
            this.AddEmployer.Size = new System.Drawing.Size(128, 23);
            this.AddEmployer.TabIndex = 2;
            this.AddEmployer.Text = "Dodaj pracownika";
            this.AddEmployer.UseVisualStyleBackColor = true;
            this.AddEmployer.Click += new System.EventHandler(this.AddEmployer_Click);
            // 
            // Badania
            // 
            this.Badania.Controls.Add(this.NrUmowy);
            this.Badania.Controls.Add(this.NumerUmowy);
            this.Badania.Controls.Add(this.DataBadan);
            this.Badania.Controls.Add(this.KoniecKPP);
            this.Badania.Controls.Add(this.StanowiskoUzytkownika);
            this.Badania.Controls.Add(this.Stopień);
            this.Badania.Controls.Add(this.Data_KPP);
            this.Badania.Controls.Add(this.Stanowisko);
            this.Badania.Controls.Add(this.Data_badan);
            this.Badania.Controls.Add(this.Stopien);
            this.Badania.Location = new System.Drawing.Point(306, 255);
            this.Badania.Name = "Badania";
            this.Badania.Size = new System.Drawing.Size(257, 166);
            this.Badania.TabIndex = 38;
            this.Badania.TabStop = false;
            this.Badania.Text = "Badania i stanowisko";
            // 
            // NrUmowy
            // 
            this.NrUmowy.Location = new System.Drawing.Point(97, 127);
            this.NrUmowy.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NrUmowy.Name = "NrUmowy";
            this.NrUmowy.Size = new System.Drawing.Size(148, 20);
            this.NrUmowy.TabIndex = 18;
            this.NrUmowy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NrUmowy.ValueChanged += new System.EventHandler(this.NrUmowy_ValueChanged);
            // 
            // NumerUmowy
            // 
            this.NumerUmowy.AutoSize = true;
            this.NumerUmowy.Location = new System.Drawing.Point(7, 130);
            this.NumerUmowy.Name = "NumerUmowy";
            this.NumerUmowy.Size = new System.Drawing.Size(57, 13);
            this.NumerUmowy.TabIndex = 17;
            this.NumerUmowy.Text = "Nr umowy:";
            // 
            // DataBadan
            // 
            this.DataBadan.Location = new System.Drawing.Point(97, 101);
            this.DataBadan.Name = "DataBadan";
            this.DataBadan.Size = new System.Drawing.Size(148, 20);
            this.DataBadan.TabIndex = 16;
            // 
            // KoniecKPP
            // 
            this.KoniecKPP.Location = new System.Drawing.Point(97, 75);
            this.KoniecKPP.Name = "KoniecKPP";
            this.KoniecKPP.Size = new System.Drawing.Size(148, 20);
            this.KoniecKPP.TabIndex = 15;
            // 
            // StanowiskoUzytkownika
            // 
            this.StanowiskoUzytkownika.FormattingEnabled = true;
            this.StanowiskoUzytkownika.Location = new System.Drawing.Point(97, 49);
            this.StanowiskoUzytkownika.Name = "StanowiskoUzytkownika";
            this.StanowiskoUzytkownika.Size = new System.Drawing.Size(148, 21);
            this.StanowiskoUzytkownika.TabIndex = 14;
            this.StanowiskoUzytkownika.SelectedIndexChanged += new System.EventHandler(this.StanowiskoUzytkownika_SelectedIndexChanged);
            // 
            // Stopień
            // 
            this.Stopień.FormattingEnabled = true;
            this.Stopień.Location = new System.Drawing.Point(97, 23);
            this.Stopień.Name = "Stopień";
            this.Stopień.Size = new System.Drawing.Size(148, 21);
            this.Stopień.TabIndex = 13;
            this.Stopień.SelectedIndexChanged += new System.EventHandler(this.Stopień_SelectedIndexChanged_1);
            // 
            // Data_KPP
            // 
            this.Data_KPP.AutoSize = true;
            this.Data_KPP.Location = new System.Drawing.Point(7, 78);
            this.Data_KPP.Name = "Data_KPP";
            this.Data_KPP.Size = new System.Drawing.Size(79, 13);
            this.Data_KPP.TabIndex = 10;
            this.Data_KPP.Text = "Ważność KPP:";
            // 
            // Stanowisko
            // 
            this.Stanowisko.AutoSize = true;
            this.Stanowisko.Location = new System.Drawing.Point(7, 52);
            this.Stanowisko.Name = "Stanowisko";
            this.Stanowisko.Size = new System.Drawing.Size(65, 13);
            this.Stanowisko.TabIndex = 9;
            this.Stanowisko.Text = "Stanowisko:";
            // 
            // Data_badan
            // 
            this.Data_badan.AutoSize = true;
            this.Data_badan.Location = new System.Drawing.Point(7, 104);
            this.Data_badan.Name = "Data_badan";
            this.Data_badan.Size = new System.Drawing.Size(66, 13);
            this.Data_badan.TabIndex = 11;
            this.Data_badan.Text = "Data badań:";
            // 
            // Stopien
            // 
            this.Stopien.AutoSize = true;
            this.Stopien.Location = new System.Drawing.Point(7, 26);
            this.Stopien.Name = "Stopien";
            this.Stopien.Size = new System.Drawing.Size(46, 13);
            this.Stopien.TabIndex = 12;
            this.Stopien.Text = "Stopień:";
            // 
            // Dane_kontaktowe
            // 
            this.Dane_kontaktowe.Controls.Add(this.AdresEmail);
            this.Dane_kontaktowe.Controls.Add(this.NumerTelefonu);
            this.Dane_kontaktowe.Controls.Add(this.Email);
            this.Dane_kontaktowe.Controls.Add(this.Numer_telefonu);
            this.Dane_kontaktowe.Location = new System.Drawing.Point(9, 203);
            this.Dane_kontaktowe.Name = "Dane_kontaktowe";
            this.Dane_kontaktowe.Size = new System.Drawing.Size(272, 81);
            this.Dane_kontaktowe.TabIndex = 37;
            this.Dane_kontaktowe.TabStop = false;
            this.Dane_kontaktowe.Text = "Dane kontaktowe";
            // 
            // AdresEmail
            // 
            this.AdresEmail.Location = new System.Drawing.Point(106, 49);
            this.AdresEmail.Name = "AdresEmail";
            this.AdresEmail.Size = new System.Drawing.Size(148, 20);
            this.AdresEmail.TabIndex = 39;
            this.AdresEmail.Text = "nazwa@domena";
            this.AdresEmail.TextChanged += new System.EventHandler(this.AdresEmail_TextChanged);
            // 
            // NumerTelefonu
            // 
            this.NumerTelefonu.Location = new System.Drawing.Point(106, 23);
            this.NumerTelefonu.MaxLength = 12;
            this.NumerTelefonu.Name = "NumerTelefonu";
            this.NumerTelefonu.Size = new System.Drawing.Size(148, 20);
            this.NumerTelefonu.TabIndex = 38;
            this.NumerTelefonu.Text = "+48500500500";
            this.NumerTelefonu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerTelefonu_KeyPress);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(6, 52);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 13);
            this.Email.TabIndex = 3;
            this.Email.Text = "E-mail:";
            // 
            // Numer_telefonu
            // 
            this.Numer_telefonu.AutoSize = true;
            this.Numer_telefonu.Location = new System.Drawing.Point(6, 26);
            this.Numer_telefonu.Name = "Numer_telefonu";
            this.Numer_telefonu.Size = new System.Drawing.Size(82, 13);
            this.Numer_telefonu.TabIndex = 8;
            this.Numer_telefonu.Text = "Numer telefonu:";
            // 
            // Konto
            // 
            this.Konto.Controls.Add(this.TypKonta2);
            this.Konto.Controls.Add(this.TypKonta);
            this.Konto.Controls.Add(this.HasloUzytkownika);
            this.Konto.Controls.Add(this.LoginUzytkownika);
            this.Konto.Controls.Add(this.Haslo);
            this.Konto.Controls.Add(this.Login);
            this.Konto.Location = new System.Drawing.Point(9, 311);
            this.Konto.Name = "Konto";
            this.Konto.Size = new System.Drawing.Size(272, 110);
            this.Konto.TabIndex = 36;
            this.Konto.TabStop = false;
            this.Konto.Text = "Konto";
            // 
            // TypKonta2
            // 
            this.TypKonta2.FormattingEnabled = true;
            this.TypKonta2.Location = new System.Drawing.Point(106, 77);
            this.TypKonta2.Name = "TypKonta2";
            this.TypKonta2.Size = new System.Drawing.Size(148, 21);
            this.TypKonta2.TabIndex = 17;
            // 
            // TypKonta
            // 
            this.TypKonta.AutoSize = true;
            this.TypKonta.Location = new System.Drawing.Point(6, 78);
            this.TypKonta.Name = "TypKonta";
            this.TypKonta.Size = new System.Drawing.Size(58, 13);
            this.TypKonta.TabIndex = 15;
            this.TypKonta.Text = "Typ konta:";
            // 
            // HasloUzytkownika
            // 
            this.HasloUzytkownika.Location = new System.Drawing.Point(106, 49);
            this.HasloUzytkownika.MaxLength = 256;
            this.HasloUzytkownika.Name = "HasloUzytkownika";
            this.HasloUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.HasloUzytkownika.TabIndex = 16;
            // 
            // LoginUzytkownika
            // 
            this.LoginUzytkownika.Location = new System.Drawing.Point(106, 23);
            this.LoginUzytkownika.Name = "LoginUzytkownika";
            this.LoginUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.LoginUzytkownika.TabIndex = 15;
            this.LoginUzytkownika.Text = "imię.nazwisko";
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Location = new System.Drawing.Point(6, 52);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(39, 13);
            this.Haslo.TabIndex = 14;
            this.Haslo.Text = "Hasło:";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(6, 26);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(36, 13);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login:";
            // 
            // Dane_umowy
            // 
            this.Dane_umowy.Controls.Add(this.StwórzUmowe);
            this.Dane_umowy.Controls.Add(this.KoniecUmowy);
            this.Dane_umowy.Controls.Add(this.PoczatekUmowy);
            this.Dane_umowy.Controls.Add(this.WymiarGodzin);
            this.Dane_umowy.Controls.Add(this.TypUmowy);
            this.Dane_umowy.Controls.Add(this.Koniec_umowy);
            this.Dane_umowy.Controls.Add(this.Poczatek_umowy);
            this.Dane_umowy.Controls.Add(this.Wymiar_godzin);
            this.Dane_umowy.Controls.Add(this.Typ_umowy);
            this.Dane_umowy.Location = new System.Drawing.Point(9, 21);
            this.Dane_umowy.Name = "Dane_umowy";
            this.Dane_umowy.Size = new System.Drawing.Size(272, 162);
            this.Dane_umowy.TabIndex = 35;
            this.Dane_umowy.TabStop = false;
            this.Dane_umowy.Text = "Dane umowy";
            // 
            // StwórzUmowe
            // 
            this.StwórzUmowe.Location = new System.Drawing.Point(150, 133);
            this.StwórzUmowe.Name = "StwórzUmowe";
            this.StwórzUmowe.Size = new System.Drawing.Size(104, 23);
            this.StwórzUmowe.TabIndex = 38;
            this.StwórzUmowe.Text = "Stwórz umowę";
            this.StwórzUmowe.UseVisualStyleBackColor = true;
            this.StwórzUmowe.Click += new System.EventHandler(this.StwórzUmowe_Click);
            // 
            // KoniecUmowy
            // 
            this.KoniecUmowy.Location = new System.Drawing.Point(106, 101);
            this.KoniecUmowy.Name = "KoniecUmowy";
            this.KoniecUmowy.Size = new System.Drawing.Size(148, 20);
            this.KoniecUmowy.TabIndex = 37;
            // 
            // PoczatekUmowy
            // 
            this.PoczatekUmowy.Location = new System.Drawing.Point(106, 75);
            this.PoczatekUmowy.Name = "PoczatekUmowy";
            this.PoczatekUmowy.Size = new System.Drawing.Size(148, 20);
            this.PoczatekUmowy.TabIndex = 36;
            this.PoczatekUmowy.ValueChanged += new System.EventHandler(this.PoczatekUmowy_ValueChanged);
            // 
            // WymiarGodzin
            // 
            this.WymiarGodzin.Location = new System.Drawing.Point(106, 49);
            this.WymiarGodzin.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.WymiarGodzin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WymiarGodzin.Name = "WymiarGodzin";
            this.WymiarGodzin.Size = new System.Drawing.Size(148, 20);
            this.WymiarGodzin.TabIndex = 35;
            this.WymiarGodzin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TypUmowy
            // 
            this.TypUmowy.FormattingEnabled = true;
            this.TypUmowy.Location = new System.Drawing.Point(106, 23);
            this.TypUmowy.Name = "TypUmowy";
            this.TypUmowy.Size = new System.Drawing.Size(148, 21);
            this.TypUmowy.TabIndex = 34;
            // 
            // Koniec_umowy
            // 
            this.Koniec_umowy.AutoSize = true;
            this.Koniec_umowy.Location = new System.Drawing.Point(6, 104);
            this.Koniec_umowy.Name = "Koniec_umowy";
            this.Koniec_umowy.Size = new System.Drawing.Size(79, 13);
            this.Koniec_umowy.TabIndex = 33;
            this.Koniec_umowy.Text = "Koniec umowy:";
            // 
            // Poczatek_umowy
            // 
            this.Poczatek_umowy.AutoSize = true;
            this.Poczatek_umowy.Location = new System.Drawing.Point(6, 78);
            this.Poczatek_umowy.Name = "Poczatek_umowy";
            this.Poczatek_umowy.Size = new System.Drawing.Size(91, 13);
            this.Poczatek_umowy.TabIndex = 32;
            this.Poczatek_umowy.Text = "Początek umowy:";
            // 
            // Wymiar_godzin
            // 
            this.Wymiar_godzin.AutoSize = true;
            this.Wymiar_godzin.Location = new System.Drawing.Point(6, 52);
            this.Wymiar_godzin.Name = "Wymiar_godzin";
            this.Wymiar_godzin.Size = new System.Drawing.Size(79, 13);
            this.Wymiar_godzin.TabIndex = 30;
            this.Wymiar_godzin.Text = "Wymiar godzin:";
            // 
            // Typ_umowy
            // 
            this.Typ_umowy.AutoSize = true;
            this.Typ_umowy.Location = new System.Drawing.Point(6, 26);
            this.Typ_umowy.Name = "Typ_umowy";
            this.Typ_umowy.Size = new System.Drawing.Size(64, 13);
            this.Typ_umowy.TabIndex = 29;
            this.Typ_umowy.Text = "Typ umowy:";
            // 
            // Dane_osobowe
            // 
            this.Dane_osobowe.Controls.Add(this.NumerMieszkania);
            this.Dane_osobowe.Controls.Add(this.NumerDomu);
            this.Dane_osobowe.Controls.Add(this.UlicaUzytkownika);
            this.Dane_osobowe.Controls.Add(this.MiastoUzytkownika);
            this.Dane_osobowe.Controls.Add(this.PeselUzytkownika);
            this.Dane_osobowe.Controls.Add(this.NazwiskoUzytkownika);
            this.Dane_osobowe.Controls.Add(this.ImieUzytkownika);
            this.Dane_osobowe.Controls.Add(this.Numer_mieszkania);
            this.Dane_osobowe.Controls.Add(this.Nr_domu);
            this.Dane_osobowe.Controls.Add(this.Ulica);
            this.Dane_osobowe.Controls.Add(this.Miasto);
            this.Dane_osobowe.Controls.Add(this.Pesel);
            this.Dane_osobowe.Controls.Add(this.Nazwisko);
            this.Dane_osobowe.Controls.Add(this.Imie);
            this.Dane_osobowe.Location = new System.Drawing.Point(306, 21);
            this.Dane_osobowe.Name = "Dane_osobowe";
            this.Dane_osobowe.Size = new System.Drawing.Size(257, 209);
            this.Dane_osobowe.TabIndex = 34;
            this.Dane_osobowe.TabStop = false;
            this.Dane_osobowe.Text = "Dane osobowe";
            // 
            // NumerMieszkania
            // 
            this.NumerMieszkania.Location = new System.Drawing.Point(97, 179);
            this.NumerMieszkania.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumerMieszkania.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumerMieszkania.Name = "NumerMieszkania";
            this.NumerMieszkania.Size = new System.Drawing.Size(148, 20);
            this.NumerMieszkania.TabIndex = 14;
            this.NumerMieszkania.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumerDomu
            // 
            this.NumerDomu.Location = new System.Drawing.Point(97, 153);
            this.NumerDomu.MaxLength = 4;
            this.NumerDomu.Name = "NumerDomu";
            this.NumerDomu.Size = new System.Drawing.Size(148, 20);
            this.NumerDomu.TabIndex = 13;
            this.NumerDomu.TextChanged += new System.EventHandler(this.NumerDomu_TextChanged);
            this.NumerDomu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerDomu_KeyPress);
            // 
            // UlicaUzytkownika
            // 
            this.UlicaUzytkownika.Location = new System.Drawing.Point(97, 127);
            this.UlicaUzytkownika.MaxLength = 20;
            this.UlicaUzytkownika.Name = "UlicaUzytkownika";
            this.UlicaUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.UlicaUzytkownika.TabIndex = 12;
            this.UlicaUzytkownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UlicaUzytkownika_KeyPress);
            // 
            // MiastoUzytkownika
            // 
            this.MiastoUzytkownika.Location = new System.Drawing.Point(97, 101);
            this.MiastoUzytkownika.MaxLength = 20;
            this.MiastoUzytkownika.Name = "MiastoUzytkownika";
            this.MiastoUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.MiastoUzytkownika.TabIndex = 11;
            this.MiastoUzytkownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MiastoUzytkownika_KeyPress);
            // 
            // PeselUzytkownika
            // 
            this.PeselUzytkownika.Location = new System.Drawing.Point(97, 75);
            this.PeselUzytkownika.MaxLength = 11;
            this.PeselUzytkownika.Name = "PeselUzytkownika";
            this.PeselUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.PeselUzytkownika.TabIndex = 10;
            this.PeselUzytkownika.TextChanged += new System.EventHandler(this.PeselUzytkownika_TextChanged);
            this.PeselUzytkownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselUzytkownika_KeyPress);
            // 
            // NazwiskoUzytkownika
            // 
            this.NazwiskoUzytkownika.Location = new System.Drawing.Point(97, 49);
            this.NazwiskoUzytkownika.MaxLength = 50;
            this.NazwiskoUzytkownika.Name = "NazwiskoUzytkownika";
            this.NazwiskoUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.NazwiskoUzytkownika.TabIndex = 9;
            this.NazwiskoUzytkownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NazwiskoUzytkownika_KeyPress);
            // 
            // ImieUzytkownika
            // 
            this.ImieUzytkownika.Location = new System.Drawing.Point(97, 23);
            this.ImieUzytkownika.MaxLength = 50;
            this.ImieUzytkownika.Name = "ImieUzytkownika";
            this.ImieUzytkownika.Size = new System.Drawing.Size(148, 20);
            this.ImieUzytkownika.TabIndex = 8;
            this.ImieUzytkownika.TextChanged += new System.EventHandler(this.ImieUzytkownika_TextChanged);
            this.ImieUzytkownika.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImieUzytkownika_KeyPress);
            // 
            // Numer_mieszkania
            // 
            this.Numer_mieszkania.AutoSize = true;
            this.Numer_mieszkania.Location = new System.Drawing.Point(6, 182);
            this.Numer_mieszkania.Name = "Numer_mieszkania";
            this.Numer_mieszkania.Size = new System.Drawing.Size(76, 13);
            this.Numer_mieszkania.TabIndex = 7;
            this.Numer_mieszkania.Text = "Nr mieszkania:";
            // 
            // Nr_domu
            // 
            this.Nr_domu.AutoSize = true;
            this.Nr_domu.Location = new System.Drawing.Point(6, 156);
            this.Nr_domu.Name = "Nr_domu";
            this.Nr_domu.Size = new System.Drawing.Size(50, 13);
            this.Nr_domu.TabIndex = 6;
            this.Nr_domu.Text = "Nr domu:";
            // 
            // Ulica
            // 
            this.Ulica.AutoSize = true;
            this.Ulica.Location = new System.Drawing.Point(6, 130);
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
            this.Imie.Location = new System.Drawing.Point(6, 26);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(29, 13);
            this.Imie.TabIndex = 0;
            this.Imie.Text = "Imię:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 464);
            this.Controls.Add(this.Pracownik);
            this.Name = "Form2";
            this.Text = "Dodaj pracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Pracownik.ResumeLayout(false);
            this.Badania.ResumeLayout(false);
            this.Badania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NrUmowy)).EndInit();
            this.Dane_kontaktowe.ResumeLayout(false);
            this.Dane_kontaktowe.PerformLayout();
            this.Konto.ResumeLayout(false);
            this.Konto.PerformLayout();
            this.Dane_umowy.ResumeLayout(false);
            this.Dane_umowy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WymiarGodzin)).EndInit();
            this.Dane_osobowe.ResumeLayout(false);
            this.Dane_osobowe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumerMieszkania)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Pracownik;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button AddEmployer;
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
        private System.Windows.Forms.Label Koniec_umowy;
        private System.Windows.Forms.Label Poczatek_umowy;
        private System.Windows.Forms.GroupBox Dane_kontaktowe;
        private System.Windows.Forms.GroupBox Konto;
        private System.Windows.Forms.GroupBox Dane_umowy;
        private System.Windows.Forms.GroupBox Dane_osobowe;
        private System.Windows.Forms.GroupBox Badania;
        private System.Windows.Forms.DateTimePicker DataBadan;
        private System.Windows.Forms.DateTimePicker KoniecKPP;
        private System.Windows.Forms.ComboBox StanowiskoUzytkownika;
        private System.Windows.Forms.ComboBox Stopień;
        private System.Windows.Forms.TextBox AdresEmail;
        private System.Windows.Forms.TextBox NumerTelefonu;
        private System.Windows.Forms.TextBox HasloUzytkownika;
        private System.Windows.Forms.TextBox LoginUzytkownika;
        private System.Windows.Forms.DateTimePicker KoniecUmowy;
        private System.Windows.Forms.DateTimePicker PoczatekUmowy;
        private System.Windows.Forms.NumericUpDown WymiarGodzin;
        private System.Windows.Forms.ComboBox TypUmowy;
        private System.Windows.Forms.NumericUpDown NumerMieszkania;
        private System.Windows.Forms.TextBox NumerDomu;
        private System.Windows.Forms.TextBox UlicaUzytkownika;
        private System.Windows.Forms.TextBox MiastoUzytkownika;
        private System.Windows.Forms.TextBox PeselUzytkownika;
        private System.Windows.Forms.TextBox NazwiskoUzytkownika;
        private System.Windows.Forms.TextBox ImieUzytkownika;
        private System.Windows.Forms.ComboBox TypKonta2;
        private System.Windows.Forms.Label TypKonta;
        private System.Windows.Forms.Button StwórzUmowe;
        private System.Windows.Forms.NumericUpDown NrUmowy;
        private System.Windows.Forms.Label NumerUmowy;
    }
}