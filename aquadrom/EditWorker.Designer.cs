namespace aquadrom
{
    partial class EditWorker
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
            this.PracownikGroupBox = new System.Windows.Forms.GroupBox();
            this.BadaniaGroupBox = new System.Windows.Forms.GroupBox();
            this.DataBadanDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.KoniecKPPDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StanowiskoUseraComboBox = new System.Windows.Forms.ComboBox();
            this.StopienComboBox = new System.Windows.Forms.ComboBox();
            this.Data_KPP = new System.Windows.Forms.Label();
            this.Stanowisko = new System.Windows.Forms.Label();
            this.Data_badan = new System.Windows.Forms.Label();
            this.Stopien = new System.Windows.Forms.Label();
            this.DaneKontaktoweGroupBox = new System.Windows.Forms.GroupBox();
            this.AdresEmailTextBox = new System.Windows.Forms.TextBox();
            this.NumerTelefonuTextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.Numer_telefonu = new System.Windows.Forms.Label();
            this.KontoGroupBox = new System.Windows.Forms.GroupBox();
            this.IDUseraLabel = new System.Windows.Forms.Label();
            this.IDUseraTextBox = new System.Windows.Forms.TextBox();
            this.LoginUseraTextBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.DaneUmowyGroupBox = new System.Windows.Forms.GroupBox();
            this.IDUmowyLabel = new System.Windows.Forms.Label();
            this.IDUmowyTextBox = new System.Windows.Forms.TextBox();
            this.KoniecUmowyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PoczatekUmowyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WymiarGodzinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TypUmowyComboBox = new System.Windows.Forms.ComboBox();
            this.Koniec_umowy = new System.Windows.Forms.Label();
            this.Poczatek_umowy = new System.Windows.Forms.Label();
            this.Wymiar_godzin = new System.Windows.Forms.Label();
            this.Typ_umowy = new System.Windows.Forms.Label();
            this.DaneOsoboweGroupBox = new System.Windows.Forms.GroupBox();
            this.NumerMieszkaniaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumerDomuTextBox = new System.Windows.Forms.TextBox();
            this.UlicaUseraTextBox = new System.Windows.Forms.TextBox();
            this.MiastoUseraTextBox = new System.Windows.Forms.TextBox();
            this.PeselUseraTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoUseraTextBox = new System.Windows.Forms.TextBox();
            this.ImieUseraTextBox = new System.Windows.Forms.TextBox();
            this.Numer_mieszkania = new System.Windows.Forms.Label();
            this.Nr_domu = new System.Windows.Forms.Label();
            this.Ulica = new System.Windows.Forms.Label();
            this.Miasto = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.Label();
            this.AnulujButton = new System.Windows.Forms.Button();
            this.EdytujUseraButton = new System.Windows.Forms.Button();
            this.PracownikGroupBox.SuspendLayout();
            this.BadaniaGroupBox.SuspendLayout();
            this.DaneKontaktoweGroupBox.SuspendLayout();
            this.KontoGroupBox.SuspendLayout();
            this.DaneUmowyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WymiarGodzinNumericUpDown)).BeginInit();
            this.DaneOsoboweGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumerMieszkaniaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PracownikGroupBox
            // 
            this.PracownikGroupBox.Controls.Add(this.BadaniaGroupBox);
            this.PracownikGroupBox.Controls.Add(this.DaneKontaktoweGroupBox);
            this.PracownikGroupBox.Controls.Add(this.KontoGroupBox);
            this.PracownikGroupBox.Controls.Add(this.DaneUmowyGroupBox);
            this.PracownikGroupBox.Controls.Add(this.DaneOsoboweGroupBox);
            this.PracownikGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PracownikGroupBox.Name = "PracownikGroupBox";
            this.PracownikGroupBox.Size = new System.Drawing.Size(583, 411);
            this.PracownikGroupBox.TabIndex = 0;
            this.PracownikGroupBox.TabStop = false;
            this.PracownikGroupBox.Text = "Pracownik";
            // 
            // BadaniaGroupBox
            // 
            this.BadaniaGroupBox.Controls.Add(this.DataBadanDateTimePicker);
            this.BadaniaGroupBox.Controls.Add(this.KoniecKPPDateTimePicker);
            this.BadaniaGroupBox.Controls.Add(this.StanowiskoUseraComboBox);
            this.BadaniaGroupBox.Controls.Add(this.StopienComboBox);
            this.BadaniaGroupBox.Controls.Add(this.Data_KPP);
            this.BadaniaGroupBox.Controls.Add(this.Stanowisko);
            this.BadaniaGroupBox.Controls.Add(this.Data_badan);
            this.BadaniaGroupBox.Controls.Add(this.Stopien);
            this.BadaniaGroupBox.Location = new System.Drawing.Point(306, 243);
            this.BadaniaGroupBox.Name = "BadaniaGroupBox";
            this.BadaniaGroupBox.Size = new System.Drawing.Size(257, 147);
            this.BadaniaGroupBox.TabIndex = 38;
            this.BadaniaGroupBox.TabStop = false;
            this.BadaniaGroupBox.Text = "Badania i stanowisko";
            // 
            // DataBadanDateTimePicker
            // 
            this.DataBadanDateTimePicker.Location = new System.Drawing.Point(97, 101);
            this.DataBadanDateTimePicker.Name = "DataBadanDateTimePicker";
            this.DataBadanDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.DataBadanDateTimePicker.TabIndex = 16;
            // 
            // KoniecKPPDateTimePicker
            // 
            this.KoniecKPPDateTimePicker.Location = new System.Drawing.Point(97, 75);
            this.KoniecKPPDateTimePicker.Name = "KoniecKPPDateTimePicker";
            this.KoniecKPPDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.KoniecKPPDateTimePicker.TabIndex = 15;
            // 
            // StanowiskoUseraComboBox
            // 
            this.StanowiskoUseraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StanowiskoUseraComboBox.FormattingEnabled = true;
            this.StanowiskoUseraComboBox.Location = new System.Drawing.Point(97, 49);
            this.StanowiskoUseraComboBox.Name = "StanowiskoUseraComboBox";
            this.StanowiskoUseraComboBox.Size = new System.Drawing.Size(148, 21);
            this.StanowiskoUseraComboBox.TabIndex = 14;
            this.StanowiskoUseraComboBox.SelectedIndexChanged += new System.EventHandler(this.StanowiskoUseraComboBox_SelectedIndexChanged);
            // 
            // StopienComboBox
            // 
            this.StopienComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopienComboBox.FormattingEnabled = true;
            this.StopienComboBox.Location = new System.Drawing.Point(97, 23);
            this.StopienComboBox.Name = "StopienComboBox";
            this.StopienComboBox.Size = new System.Drawing.Size(148, 21);
            this.StopienComboBox.TabIndex = 13;
            this.StopienComboBox.SelectedIndexChanged += new System.EventHandler(this.StopienComboBox_SelectedIndexChanged);
            // 
            // Data_KPP
            // 
            this.Data_KPP.AutoSize = true;
            this.Data_KPP.Location = new System.Drawing.Point(7, 75);
            this.Data_KPP.Name = "Data_KPP";
            this.Data_KPP.Size = new System.Drawing.Size(79, 13);
            this.Data_KPP.TabIndex = 10;
            this.Data_KPP.Text = "Ważność KPP:";
            // 
            // Stanowisko
            // 
            this.Stanowisko.AutoSize = true;
            this.Stanowisko.Location = new System.Drawing.Point(7, 49);
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
            this.Stopien.Location = new System.Drawing.Point(7, 23);
            this.Stopien.Name = "Stopien";
            this.Stopien.Size = new System.Drawing.Size(46, 13);
            this.Stopien.TabIndex = 12;
            this.Stopien.Text = "Stopień:";
            // 
            // DaneKontaktoweGroupBox
            // 
            this.DaneKontaktoweGroupBox.Controls.Add(this.AdresEmailTextBox);
            this.DaneKontaktoweGroupBox.Controls.Add(this.NumerTelefonuTextBox);
            this.DaneKontaktoweGroupBox.Controls.Add(this.Email);
            this.DaneKontaktoweGroupBox.Controls.Add(this.Numer_telefonu);
            this.DaneKontaktoweGroupBox.Location = new System.Drawing.Point(9, 189);
            this.DaneKontaktoweGroupBox.Name = "DaneKontaktoweGroupBox";
            this.DaneKontaktoweGroupBox.Size = new System.Drawing.Size(272, 81);
            this.DaneKontaktoweGroupBox.TabIndex = 37;
            this.DaneKontaktoweGroupBox.TabStop = false;
            this.DaneKontaktoweGroupBox.Text = "Dane kontaktowe";
            // 
            // AdresEmailTextBox
            // 
            this.AdresEmailTextBox.Location = new System.Drawing.Point(106, 49);
            this.AdresEmailTextBox.Name = "AdresEmailTextBox";
            this.AdresEmailTextBox.Size = new System.Drawing.Size(148, 20);
            this.AdresEmailTextBox.TabIndex = 10;
            // 
            // NumerTelefonuTextBox
            // 
            this.NumerTelefonuTextBox.Location = new System.Drawing.Point(106, 23);
            this.NumerTelefonuTextBox.Name = "NumerTelefonuTextBox";
            this.NumerTelefonuTextBox.Size = new System.Drawing.Size(148, 20);
            this.NumerTelefonuTextBox.TabIndex = 9;
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
            // KontoGroupBox
            // 
            this.KontoGroupBox.Controls.Add(this.IDUseraLabel);
            this.KontoGroupBox.Controls.Add(this.IDUseraTextBox);
            this.KontoGroupBox.Controls.Add(this.LoginUseraTextBox);
            this.KontoGroupBox.Controls.Add(this.Login);
            this.KontoGroupBox.Location = new System.Drawing.Point(9, 276);
            this.KontoGroupBox.Name = "KontoGroupBox";
            this.KontoGroupBox.Size = new System.Drawing.Size(272, 114);
            this.KontoGroupBox.TabIndex = 36;
            this.KontoGroupBox.TabStop = false;
            this.KontoGroupBox.Text = "Konto";
            // 
            // IDUseraLabel
            // 
            this.IDUseraLabel.AutoSize = true;
            this.IDUseraLabel.Location = new System.Drawing.Point(6, 45);
            this.IDUseraLabel.Name = "IDUseraLabel";
            this.IDUseraLabel.Size = new System.Drawing.Size(18, 13);
            this.IDUseraLabel.TabIndex = 18;
            this.IDUseraLabel.Text = "ID";
            // 
            // IDUseraTextBox
            // 
            this.IDUseraTextBox.Location = new System.Drawing.Point(106, 42);
            this.IDUseraTextBox.Name = "IDUseraTextBox";
            this.IDUseraTextBox.ReadOnly = true;
            this.IDUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.IDUseraTextBox.TabIndex = 17;
            // 
            // LoginUseraTextBox
            // 
            this.LoginUseraTextBox.Location = new System.Drawing.Point(106, 68);
            this.LoginUseraTextBox.Name = "LoginUseraTextBox";
            this.LoginUseraTextBox.ReadOnly = true;
            this.LoginUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.LoginUseraTextBox.TabIndex = 15;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(6, 71);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(36, 13);
            this.Login.TabIndex = 13;
            this.Login.Text = "Login:";
            // 
            // DaneUmowyGroupBox
            // 
            this.DaneUmowyGroupBox.Controls.Add(this.IDUmowyLabel);
            this.DaneUmowyGroupBox.Controls.Add(this.IDUmowyTextBox);
            this.DaneUmowyGroupBox.Controls.Add(this.KoniecUmowyDateTimePicker);
            this.DaneUmowyGroupBox.Controls.Add(this.PoczatekUmowyDateTimePicker);
            this.DaneUmowyGroupBox.Controls.Add(this.WymiarGodzinNumericUpDown);
            this.DaneUmowyGroupBox.Controls.Add(this.TypUmowyComboBox);
            this.DaneUmowyGroupBox.Controls.Add(this.Koniec_umowy);
            this.DaneUmowyGroupBox.Controls.Add(this.Poczatek_umowy);
            this.DaneUmowyGroupBox.Controls.Add(this.Wymiar_godzin);
            this.DaneUmowyGroupBox.Controls.Add(this.Typ_umowy);
            this.DaneUmowyGroupBox.Location = new System.Drawing.Point(9, 21);
            this.DaneUmowyGroupBox.Name = "DaneUmowyGroupBox";
            this.DaneUmowyGroupBox.Size = new System.Drawing.Size(272, 162);
            this.DaneUmowyGroupBox.TabIndex = 35;
            this.DaneUmowyGroupBox.TabStop = false;
            this.DaneUmowyGroupBox.Text = "Dane umowy";
            // 
            // IDUmowyLabel
            // 
            this.IDUmowyLabel.AutoSize = true;
            this.IDUmowyLabel.Location = new System.Drawing.Point(6, 26);
            this.IDUmowyLabel.Name = "IDUmowyLabel";
            this.IDUmowyLabel.Size = new System.Drawing.Size(54, 13);
            this.IDUmowyLabel.TabIndex = 39;
            this.IDUmowyLabel.Text = "ID umowy";
            // 
            // IDUmowyTextBox
            // 
            this.IDUmowyTextBox.Location = new System.Drawing.Point(106, 20);
            this.IDUmowyTextBox.Name = "IDUmowyTextBox";
            this.IDUmowyTextBox.ReadOnly = true;
            this.IDUmowyTextBox.Size = new System.Drawing.Size(148, 20);
            this.IDUmowyTextBox.TabIndex = 38;
            // 
            // KoniecUmowyDateTimePicker
            // 
            this.KoniecUmowyDateTimePicker.Location = new System.Drawing.Point(106, 127);
            this.KoniecUmowyDateTimePicker.Name = "KoniecUmowyDateTimePicker";
            this.KoniecUmowyDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.KoniecUmowyDateTimePicker.TabIndex = 37;
            // 
            // PoczatekUmowyDateTimePicker
            // 
            this.PoczatekUmowyDateTimePicker.Location = new System.Drawing.Point(106, 101);
            this.PoczatekUmowyDateTimePicker.Name = "PoczatekUmowyDateTimePicker";
            this.PoczatekUmowyDateTimePicker.Size = new System.Drawing.Size(148, 20);
            this.PoczatekUmowyDateTimePicker.TabIndex = 36;
            // 
            // WymiarGodzinNumericUpDown
            // 
            this.WymiarGodzinNumericUpDown.Location = new System.Drawing.Point(106, 75);
            this.WymiarGodzinNumericUpDown.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.WymiarGodzinNumericUpDown.Name = "WymiarGodzinNumericUpDown";
            this.WymiarGodzinNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.WymiarGodzinNumericUpDown.TabIndex = 35;
            // 
            // TypUmowyComboBox
            // 
            this.TypUmowyComboBox.FormattingEnabled = true;
            this.TypUmowyComboBox.Location = new System.Drawing.Point(106, 46);
            this.TypUmowyComboBox.Name = "TypUmowyComboBox";
            this.TypUmowyComboBox.Size = new System.Drawing.Size(148, 21);
            this.TypUmowyComboBox.TabIndex = 34;
            this.TypUmowyComboBox.SelectedIndexChanged += new System.EventHandler(this.TypUmowyComboBox_SelectedIndexChanged);
            // 
            // Koniec_umowy
            // 
            this.Koniec_umowy.AutoSize = true;
            this.Koniec_umowy.Location = new System.Drawing.Point(6, 130);
            this.Koniec_umowy.Name = "Koniec_umowy";
            this.Koniec_umowy.Size = new System.Drawing.Size(79, 13);
            this.Koniec_umowy.TabIndex = 33;
            this.Koniec_umowy.Text = "Koniec umowy:";
            // 
            // Poczatek_umowy
            // 
            this.Poczatek_umowy.AutoSize = true;
            this.Poczatek_umowy.Location = new System.Drawing.Point(6, 104);
            this.Poczatek_umowy.Name = "Poczatek_umowy";
            this.Poczatek_umowy.Size = new System.Drawing.Size(91, 13);
            this.Poczatek_umowy.TabIndex = 32;
            this.Poczatek_umowy.Text = "Początek umowy:";
            // 
            // Wymiar_godzin
            // 
            this.Wymiar_godzin.AutoSize = true;
            this.Wymiar_godzin.Location = new System.Drawing.Point(6, 78);
            this.Wymiar_godzin.Name = "Wymiar_godzin";
            this.Wymiar_godzin.Size = new System.Drawing.Size(79, 13);
            this.Wymiar_godzin.TabIndex = 30;
            this.Wymiar_godzin.Text = "Wymiar godzin:";
            // 
            // Typ_umowy
            // 
            this.Typ_umowy.AutoSize = true;
            this.Typ_umowy.Location = new System.Drawing.Point(6, 52);
            this.Typ_umowy.Name = "Typ_umowy";
            this.Typ_umowy.Size = new System.Drawing.Size(64, 13);
            this.Typ_umowy.TabIndex = 29;
            this.Typ_umowy.Text = "Typ umowy:";
            // 
            // DaneOsoboweGroupBox
            // 
            this.DaneOsoboweGroupBox.Controls.Add(this.NumerMieszkaniaNumericUpDown);
            this.DaneOsoboweGroupBox.Controls.Add(this.NumerDomuTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.UlicaUseraTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.MiastoUseraTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.PeselUseraTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.NazwiskoUseraTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.ImieUseraTextBox);
            this.DaneOsoboweGroupBox.Controls.Add(this.Numer_mieszkania);
            this.DaneOsoboweGroupBox.Controls.Add(this.Nr_domu);
            this.DaneOsoboweGroupBox.Controls.Add(this.Ulica);
            this.DaneOsoboweGroupBox.Controls.Add(this.Miasto);
            this.DaneOsoboweGroupBox.Controls.Add(this.Pesel);
            this.DaneOsoboweGroupBox.Controls.Add(this.Nazwisko);
            this.DaneOsoboweGroupBox.Controls.Add(this.Imie);
            this.DaneOsoboweGroupBox.Location = new System.Drawing.Point(306, 21);
            this.DaneOsoboweGroupBox.Name = "DaneOsoboweGroupBox";
            this.DaneOsoboweGroupBox.Size = new System.Drawing.Size(257, 209);
            this.DaneOsoboweGroupBox.TabIndex = 34;
            this.DaneOsoboweGroupBox.TabStop = false;
            this.DaneOsoboweGroupBox.Text = "Dane osobowe";
            // 
            // NumerMieszkaniaNumericUpDown
            // 
            this.NumerMieszkaniaNumericUpDown.Location = new System.Drawing.Point(97, 179);
            this.NumerMieszkaniaNumericUpDown.Name = "NumerMieszkaniaNumericUpDown";
            this.NumerMieszkaniaNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.NumerMieszkaniaNumericUpDown.TabIndex = 14;
            // 
            // NumerDomuTextBox
            // 
            this.NumerDomuTextBox.Location = new System.Drawing.Point(97, 153);
            this.NumerDomuTextBox.Name = "NumerDomuTextBox";
            this.NumerDomuTextBox.Size = new System.Drawing.Size(148, 20);
            this.NumerDomuTextBox.TabIndex = 13;
            // 
            // UlicaUseraTextBox
            // 
            this.UlicaUseraTextBox.Location = new System.Drawing.Point(97, 127);
            this.UlicaUseraTextBox.Name = "UlicaUseraTextBox";
            this.UlicaUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.UlicaUseraTextBox.TabIndex = 12;
            // 
            // MiastoUseraTextBox
            // 
            this.MiastoUseraTextBox.Location = new System.Drawing.Point(97, 101);
            this.MiastoUseraTextBox.Name = "MiastoUseraTextBox";
            this.MiastoUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.MiastoUseraTextBox.TabIndex = 11;
            // 
            // PeselUseraTextBox
            // 
            this.PeselUseraTextBox.Location = new System.Drawing.Point(97, 75);
            this.PeselUseraTextBox.Name = "PeselUseraTextBox";
            this.PeselUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.PeselUseraTextBox.TabIndex = 10;
            // 
            // NazwiskoUseraTextBox
            // 
            this.NazwiskoUseraTextBox.Location = new System.Drawing.Point(97, 49);
            this.NazwiskoUseraTextBox.Name = "NazwiskoUseraTextBox";
            this.NazwiskoUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.NazwiskoUseraTextBox.TabIndex = 9;
            // 
            // ImieUseraTextBox
            // 
            this.ImieUseraTextBox.Location = new System.Drawing.Point(97, 23);
            this.ImieUseraTextBox.Name = "ImieUseraTextBox";
            this.ImieUseraTextBox.Size = new System.Drawing.Size(148, 20);
            this.ImieUseraTextBox.TabIndex = 8;
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
            // AnulujButton
            // 
            this.AnulujButton.Location = new System.Drawing.Point(511, 420);
            this.AnulujButton.Name = "AnulujButton";
            this.AnulujButton.Size = new System.Drawing.Size(75, 23);
            this.AnulujButton.TabIndex = 1;
            this.AnulujButton.Text = "Anuluj";
            this.AnulujButton.UseVisualStyleBackColor = true;
            this.AnulujButton.Click += new System.EventHandler(this.AnulujButton_Click);
            // 
            // EdytujUseraButton
            // 
            this.EdytujUseraButton.Location = new System.Drawing.Point(377, 420);
            this.EdytujUseraButton.Name = "EdytujUseraButton";
            this.EdytujUseraButton.Size = new System.Drawing.Size(128, 23);
            this.EdytujUseraButton.TabIndex = 2;
            this.EdytujUseraButton.Text = "Edytuj";
            this.EdytujUseraButton.UseVisualStyleBackColor = true;
            this.EdytujUseraButton.Click += new System.EventHandler(this.EdytujUseraButton_Click);
            // 
            // EditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 447);
            this.Controls.Add(this.EdytujUseraButton);
            this.Controls.Add(this.AnulujButton);
            this.Controls.Add(this.PracownikGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj pracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditWorker_FormClosing_1);
            this.Load += new System.EventHandler(this.EditWorker_Load);
            this.PracownikGroupBox.ResumeLayout(false);
            this.BadaniaGroupBox.ResumeLayout(false);
            this.BadaniaGroupBox.PerformLayout();
            this.DaneKontaktoweGroupBox.ResumeLayout(false);
            this.DaneKontaktoweGroupBox.PerformLayout();
            this.KontoGroupBox.ResumeLayout(false);
            this.KontoGroupBox.PerformLayout();
            this.DaneUmowyGroupBox.ResumeLayout(false);
            this.DaneUmowyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WymiarGodzinNumericUpDown)).EndInit();
            this.DaneOsoboweGroupBox.ResumeLayout(false);
            this.DaneOsoboweGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumerMieszkaniaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PracownikGroupBox;
        private System.Windows.Forms.Button AnulujButton;
        private System.Windows.Forms.Button EdytujUseraButton;
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
        private System.Windows.Forms.GroupBox DaneKontaktoweGroupBox;
        private System.Windows.Forms.GroupBox KontoGroupBox;
        private System.Windows.Forms.GroupBox DaneUmowyGroupBox;
        private System.Windows.Forms.GroupBox DaneOsoboweGroupBox;
        private System.Windows.Forms.GroupBox BadaniaGroupBox;
        private System.Windows.Forms.DateTimePicker DataBadanDateTimePicker;
        private System.Windows.Forms.DateTimePicker KoniecKPPDateTimePicker;
        private System.Windows.Forms.ComboBox StanowiskoUseraComboBox;
        private System.Windows.Forms.ComboBox StopienComboBox;
        private System.Windows.Forms.TextBox AdresEmailTextBox;
        private System.Windows.Forms.TextBox NumerTelefonuTextBox;
        private System.Windows.Forms.TextBox LoginUseraTextBox;
        private System.Windows.Forms.DateTimePicker KoniecUmowyDateTimePicker;
        private System.Windows.Forms.DateTimePicker PoczatekUmowyDateTimePicker;
        private System.Windows.Forms.NumericUpDown WymiarGodzinNumericUpDown;
        private System.Windows.Forms.ComboBox TypUmowyComboBox;
        private System.Windows.Forms.NumericUpDown NumerMieszkaniaNumericUpDown;
        private System.Windows.Forms.TextBox NumerDomuTextBox;
        private System.Windows.Forms.TextBox UlicaUseraTextBox;
        private System.Windows.Forms.TextBox MiastoUseraTextBox;
        private System.Windows.Forms.TextBox PeselUseraTextBox;
        private System.Windows.Forms.TextBox NazwiskoUseraTextBox;
        private System.Windows.Forms.TextBox ImieUseraTextBox;
        private System.Windows.Forms.Label IDUseraLabel;
        private System.Windows.Forms.TextBox IDUseraTextBox;
        private System.Windows.Forms.Label IDUmowyLabel;
        private System.Windows.Forms.TextBox IDUmowyTextBox;
    }
}