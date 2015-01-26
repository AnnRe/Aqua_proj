namespace aquadrom
{
    partial class GeneratorNotatek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorNotatek));
            this.Generuj = new System.Windows.Forms.Button();
            this.AnulujNotatke = new System.Windows.Forms.Button();
            this.TekstNotatki = new System.Windows.Forms.RichTextBox();
            this.kiedyZdarzenie = new System.Windows.Forms.DateTimePicker();
            this.godzinaZdarzenia = new System.Windows.Forms.DateTimePicker();
            this.notatka = new System.Windows.Forms.GroupBox();
            this.znaki2 = new System.Windows.Forms.Label();
            this.znaki = new System.Windows.Forms.Label();
            this.strefaMiejsce = new System.Windows.Forms.TextBox();
            this.strefa = new System.Windows.Forms.Label();
            this.rodzajZdarzeniaL = new System.Windows.Forms.Label();
            this.rodzajZdarzenia = new System.Windows.Forms.TextBox();
            this.funkcjonariusze = new System.Windows.Forms.CheckBox();
            this.daneFunk = new System.Windows.Forms.GroupBox();
            this.nazwiskoFunkcL = new System.Windows.Forms.Label();
            this.imieFunkcL = new System.Windows.Forms.Label();
            this.nazwiskoFunkc = new System.Windows.Forms.TextBox();
            this.imieFunkc = new System.Windows.Forms.TextBox();
            this.daneInformatora = new System.Windows.Forms.GroupBox();
            this.nazwiskoWzywaL = new System.Windows.Forms.Label();
            this.imieWzywaL = new System.Windows.Forms.Label();
            this.nazwiskoWzywajacego = new System.Windows.Forms.TextBox();
            this.imieWzywajacego = new System.Windows.Forms.TextBox();
            this.trescNotatki = new System.Windows.Forms.Label();
            this.czasZdarzenia = new System.Windows.Forms.Label();
            this.dataZdarzenia = new System.Windows.Forms.Label();
            this.notatka.SuspendLayout();
            this.daneFunk.SuspendLayout();
            this.daneInformatora.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generuj
            // 
            this.Generuj.BackColor = System.Drawing.Color.Azure;
            this.Generuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generuj.Location = new System.Drawing.Point(47, 394);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(116, 23);
            this.Generuj.TabIndex = 11;
            this.Generuj.Text = "Generuj notatkę";
            this.Generuj.UseVisualStyleBackColor = false;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // AnulujNotatke
            // 
            this.AnulujNotatke.BackColor = System.Drawing.Color.Azure;
            this.AnulujNotatke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnulujNotatke.Location = new System.Drawing.Point(301, 394);
            this.AnulujNotatke.Name = "AnulujNotatke";
            this.AnulujNotatke.Size = new System.Drawing.Size(75, 23);
            this.AnulujNotatke.TabIndex = 12;
            this.AnulujNotatke.Text = "Anuluj";
            this.AnulujNotatke.UseVisualStyleBackColor = false;
            this.AnulujNotatke.Click += new System.EventHandler(this.AnulujNotatke_Click);
            // 
            // TekstNotatki
            // 
            this.TekstNotatki.BackColor = System.Drawing.Color.Azure;
            this.TekstNotatki.Location = new System.Drawing.Point(10, 155);
            this.TekstNotatki.MaxLength = 200;
            this.TekstNotatki.Name = "TekstNotatki";
            this.TekstNotatki.Size = new System.Drawing.Size(424, 143);
            this.TekstNotatki.TabIndex = 5;
            this.TekstNotatki.Text = "";
            this.TekstNotatki.TextChanged += new System.EventHandler(this.TekstNotatki_TextChanged);
            this.TekstNotatki.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TekstNotatki_KeyDown);
            // 
            // kiedyZdarzenie
            // 
            this.kiedyZdarzenie.Location = new System.Drawing.Point(110, 23);
            this.kiedyZdarzenie.Name = "kiedyZdarzenie";
            this.kiedyZdarzenie.Size = new System.Drawing.Size(145, 20);
            this.kiedyZdarzenie.TabIndex = 1;
            this.kiedyZdarzenie.Value = new System.DateTime(2015, 1, 25, 0, 0, 0, 0);
            // 
            // godzinaZdarzenia
            // 
            this.godzinaZdarzenia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.godzinaZdarzenia.Location = new System.Drawing.Point(110, 49);
            this.godzinaZdarzenia.Name = "godzinaZdarzenia";
            this.godzinaZdarzenia.Size = new System.Drawing.Size(145, 20);
            this.godzinaZdarzenia.TabIndex = 2;
            // 
            // notatka
            // 
            this.notatka.BackColor = System.Drawing.Color.Transparent;
            this.notatka.Controls.Add(this.Generuj);
            this.notatka.Controls.Add(this.znaki2);
            this.notatka.Controls.Add(this.AnulujNotatke);
            this.notatka.Controls.Add(this.znaki);
            this.notatka.Controls.Add(this.strefaMiejsce);
            this.notatka.Controls.Add(this.strefa);
            this.notatka.Controls.Add(this.rodzajZdarzeniaL);
            this.notatka.Controls.Add(this.rodzajZdarzenia);
            this.notatka.Controls.Add(this.funkcjonariusze);
            this.notatka.Controls.Add(this.daneFunk);
            this.notatka.Controls.Add(this.daneInformatora);
            this.notatka.Controls.Add(this.trescNotatki);
            this.notatka.Controls.Add(this.czasZdarzenia);
            this.notatka.Controls.Add(this.dataZdarzenia);
            this.notatka.Controls.Add(this.godzinaZdarzenia);
            this.notatka.Controls.Add(this.kiedyZdarzenie);
            this.notatka.Location = new System.Drawing.Point(4, 2);
            this.notatka.Name = "notatka";
            this.notatka.Size = new System.Drawing.Size(436, 423);
            this.notatka.TabIndex = 6;
            this.notatka.TabStop = false;
            this.notatka.Text = "Napisz notatkę";
            // 
            // znaki2
            // 
            this.znaki2.AutoSize = true;
            this.znaki2.Location = new System.Drawing.Point(397, 137);
            this.znaki2.Name = "znaki2";
            this.znaki2.Size = new System.Drawing.Size(13, 13);
            this.znaki2.TabIndex = 16;
            this.znaki2.Text = "0";
            // 
            // znaki
            // 
            this.znaki.AutoSize = true;
            this.znaki.Location = new System.Drawing.Point(296, 137);
            this.znaki.Name = "znaki";
            this.znaki.Size = new System.Drawing.Size(95, 13);
            this.znaki.TabIndex = 15;
            this.znaki.Text = "Wpisałeś znaków:";
            // 
            // strefaMiejsce
            // 
            this.strefaMiejsce.Location = new System.Drawing.Point(110, 101);
            this.strefaMiejsce.MaxLength = 20;
            this.strefaMiejsce.Name = "strefaMiejsce";
            this.strefaMiejsce.Size = new System.Drawing.Size(145, 20);
            this.strefaMiejsce.TabIndex = 4;
            this.strefaMiejsce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.strefaMiejsce_KeyPress);
            // 
            // strefa
            // 
            this.strefa.AutoSize = true;
            this.strefa.Location = new System.Drawing.Point(7, 104);
            this.strefa.Name = "strefa";
            this.strefa.Size = new System.Drawing.Size(79, 13);
            this.strefa.TabIndex = 14;
            this.strefa.Text = "Strefa/Miejsce:";
            // 
            // rodzajZdarzeniaL
            // 
            this.rodzajZdarzeniaL.AutoSize = true;
            this.rodzajZdarzeniaL.Location = new System.Drawing.Point(7, 78);
            this.rodzajZdarzeniaL.Name = "rodzajZdarzeniaL";
            this.rodzajZdarzeniaL.Size = new System.Drawing.Size(91, 13);
            this.rodzajZdarzeniaL.TabIndex = 13;
            this.rodzajZdarzeniaL.Text = "Rodzaj zdarzenia:";
            // 
            // rodzajZdarzenia
            // 
            this.rodzajZdarzenia.Location = new System.Drawing.Point(110, 75);
            this.rodzajZdarzenia.MaxLength = 20;
            this.rodzajZdarzenia.Name = "rodzajZdarzenia";
            this.rodzajZdarzenia.Size = new System.Drawing.Size(145, 20);
            this.rodzajZdarzenia.TabIndex = 3;
            this.rodzajZdarzenia.TextChanged += new System.EventHandler(this.rodzajZdarzenia_TextChanged);
            this.rodzajZdarzenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rodzajZdarzenia_KeyPress);
            // 
            // funkcjonariusze
            // 
            this.funkcjonariusze.AutoSize = true;
            this.funkcjonariusze.Location = new System.Drawing.Point(12, 128);
            this.funkcjonariusze.Name = "funkcjonariusze";
            this.funkcjonariusze.Size = new System.Drawing.Size(125, 17);
            this.funkcjonariusze.TabIndex = 6;
            this.funkcjonariusze.Text = "Policja/Straż Miejska";
            this.funkcjonariusze.UseVisualStyleBackColor = true;
            this.funkcjonariusze.CheckedChanged += new System.EventHandler(this.funkcjonariusze_CheckedChanged);
            // 
            // daneFunk
            // 
            this.daneFunk.BackColor = System.Drawing.Color.Azure;
            this.daneFunk.Controls.Add(this.nazwiskoFunkcL);
            this.daneFunk.Controls.Add(this.imieFunkcL);
            this.daneFunk.Controls.Add(this.nazwiskoFunkc);
            this.daneFunk.Controls.Add(this.imieFunkc);
            this.daneFunk.Location = new System.Drawing.Point(236, 308);
            this.daneFunk.Name = "daneFunk";
            this.daneFunk.Size = new System.Drawing.Size(194, 80);
            this.daneFunk.TabIndex = 10;
            this.daneFunk.TabStop = false;
            this.daneFunk.Text = "Dane funkcjonariusza";
            // 
            // nazwiskoFunkcL
            // 
            this.nazwiskoFunkcL.AutoSize = true;
            this.nazwiskoFunkcL.Location = new System.Drawing.Point(7, 52);
            this.nazwiskoFunkcL.Name = "nazwiskoFunkcL";
            this.nazwiskoFunkcL.Size = new System.Drawing.Size(56, 13);
            this.nazwiskoFunkcL.TabIndex = 3;
            this.nazwiskoFunkcL.Text = "Nazwisko:";
            // 
            // imieFunkcL
            // 
            this.imieFunkcL.AutoSize = true;
            this.imieFunkcL.Location = new System.Drawing.Point(7, 26);
            this.imieFunkcL.Name = "imieFunkcL";
            this.imieFunkcL.Size = new System.Drawing.Size(29, 13);
            this.imieFunkcL.TabIndex = 2;
            this.imieFunkcL.Text = "Imię:";
            // 
            // nazwiskoFunkc
            // 
            this.nazwiskoFunkc.Location = new System.Drawing.Point(65, 49);
            this.nazwiskoFunkc.Name = "nazwiskoFunkc";
            this.nazwiskoFunkc.Size = new System.Drawing.Size(123, 20);
            this.nazwiskoFunkc.TabIndex = 10;
            this.nazwiskoFunkc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nazwiskoFunkc_KeyPress);
            // 
            // imieFunkc
            // 
            this.imieFunkc.Location = new System.Drawing.Point(65, 23);
            this.imieFunkc.Name = "imieFunkc";
            this.imieFunkc.Size = new System.Drawing.Size(123, 20);
            this.imieFunkc.TabIndex = 9;
            this.imieFunkc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imieFunkc_KeyPress);
            // 
            // daneInformatora
            // 
            this.daneInformatora.BackColor = System.Drawing.Color.Azure;
            this.daneInformatora.Controls.Add(this.nazwiskoWzywaL);
            this.daneInformatora.Controls.Add(this.imieWzywaL);
            this.daneInformatora.Controls.Add(this.nazwiskoWzywajacego);
            this.daneInformatora.Controls.Add(this.imieWzywajacego);
            this.daneInformatora.Location = new System.Drawing.Point(10, 308);
            this.daneInformatora.Name = "daneInformatora";
            this.daneInformatora.Size = new System.Drawing.Size(194, 80);
            this.daneInformatora.TabIndex = 9;
            this.daneInformatora.TabStop = false;
            this.daneInformatora.Text = "Osoba wzywająca funkcjonariusza";
            // 
            // nazwiskoWzywaL
            // 
            this.nazwiskoWzywaL.AutoSize = true;
            this.nazwiskoWzywaL.Location = new System.Drawing.Point(7, 52);
            this.nazwiskoWzywaL.Name = "nazwiskoWzywaL";
            this.nazwiskoWzywaL.Size = new System.Drawing.Size(56, 13);
            this.nazwiskoWzywaL.TabIndex = 3;
            this.nazwiskoWzywaL.Text = "Nazwisko:";
            // 
            // imieWzywaL
            // 
            this.imieWzywaL.AutoSize = true;
            this.imieWzywaL.Location = new System.Drawing.Point(7, 26);
            this.imieWzywaL.Name = "imieWzywaL";
            this.imieWzywaL.Size = new System.Drawing.Size(29, 13);
            this.imieWzywaL.TabIndex = 2;
            this.imieWzywaL.Text = "Imię:";
            // 
            // nazwiskoWzywajacego
            // 
            this.nazwiskoWzywajacego.Location = new System.Drawing.Point(65, 49);
            this.nazwiskoWzywajacego.Name = "nazwiskoWzywajacego";
            this.nazwiskoWzywajacego.Size = new System.Drawing.Size(123, 20);
            this.nazwiskoWzywajacego.TabIndex = 8;
            this.nazwiskoWzywajacego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nazwiskoWzywajacego_KeyPress);
            // 
            // imieWzywajacego
            // 
            this.imieWzywajacego.Location = new System.Drawing.Point(65, 23);
            this.imieWzywajacego.Name = "imieWzywajacego";
            this.imieWzywajacego.Size = new System.Drawing.Size(123, 20);
            this.imieWzywajacego.TabIndex = 7;
            this.imieWzywajacego.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imieWzywajacego_KeyPress);
            // 
            // trescNotatki
            // 
            this.trescNotatki.AutoSize = true;
            this.trescNotatki.Location = new System.Drawing.Point(7, 130);
            this.trescNotatki.Name = "trescNotatki";
            this.trescNotatki.Size = new System.Drawing.Size(72, 13);
            this.trescNotatki.TabIndex = 8;
            this.trescNotatki.Text = "Treść notatki:";
            // 
            // czasZdarzenia
            // 
            this.czasZdarzenia.AutoSize = true;
            this.czasZdarzenia.Location = new System.Drawing.Point(7, 52);
            this.czasZdarzenia.Name = "czasZdarzenia";
            this.czasZdarzenia.Size = new System.Drawing.Size(81, 13);
            this.czasZdarzenia.TabIndex = 7;
            this.czasZdarzenia.Text = "Czas zdarzenia:";
            // 
            // dataZdarzenia
            // 
            this.dataZdarzenia.AutoSize = true;
            this.dataZdarzenia.Location = new System.Drawing.Point(7, 26);
            this.dataZdarzenia.Name = "dataZdarzenia";
            this.dataZdarzenia.Size = new System.Drawing.Size(81, 13);
            this.dataZdarzenia.TabIndex = 6;
            this.dataZdarzenia.Text = "Data zdarzenia:";
            // 
            // GeneratorNotatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::aquadrom.Properties.Resources.bg_page;
            this.ClientSize = new System.Drawing.Size(583, 442);
            this.Controls.Add(this.TekstNotatki);
            this.Controls.Add(this.notatka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorNotatek";
            this.Text = "Generator notatek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneratorNotatek_FormClosing);
            this.Load += new System.EventHandler(this.GeneratorNotatek_Load);
            this.notatka.ResumeLayout(false);
            this.notatka.PerformLayout();
            this.daneFunk.ResumeLayout(false);
            this.daneFunk.PerformLayout();
            this.daneInformatora.ResumeLayout(false);
            this.daneInformatora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button AnulujNotatke;
        private System.Windows.Forms.RichTextBox TekstNotatki;
        private System.Windows.Forms.DateTimePicker kiedyZdarzenie;
        private System.Windows.Forms.DateTimePicker godzinaZdarzenia;
        private System.Windows.Forms.GroupBox notatka;
        private System.Windows.Forms.Label trescNotatki;
        private System.Windows.Forms.Label czasZdarzenia;
        private System.Windows.Forms.Label dataZdarzenia;
        private System.Windows.Forms.GroupBox daneFunk;
        private System.Windows.Forms.GroupBox daneInformatora;
        private System.Windows.Forms.Label nazwiskoFunkcL;
        private System.Windows.Forms.Label imieFunkcL;
        private System.Windows.Forms.TextBox nazwiskoFunkc;
        private System.Windows.Forms.TextBox imieFunkc;
        private System.Windows.Forms.Label nazwiskoWzywaL;
        private System.Windows.Forms.Label imieWzywaL;
        private System.Windows.Forms.TextBox nazwiskoWzywajacego;
        private System.Windows.Forms.TextBox imieWzywajacego;
        private System.Windows.Forms.CheckBox funkcjonariusze;
        private System.Windows.Forms.Label strefa;
        private System.Windows.Forms.Label rodzajZdarzeniaL;
        private System.Windows.Forms.TextBox rodzajZdarzenia;
        private System.Windows.Forms.TextBox strefaMiejsce;
        private System.Windows.Forms.Label znaki;
        private System.Windows.Forms.Label znaki2;
    }
}