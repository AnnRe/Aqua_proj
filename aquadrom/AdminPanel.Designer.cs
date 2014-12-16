namespace aquadrom
{
    partial class AdminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquadromDataSet = new aquadrom.aquadromDataSet();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ądzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrzeglądajUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownikTableAdapter = new aquadrom.aquadromDataSetTableAdapters.PracownikTableAdapter();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerdomuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numermieszkaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numertelefonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawaznosciKPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databadanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSet)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.miastoDataGridViewTextBoxColumn,
            this.ulicaDataGridViewTextBoxColumn,
            this.numerdomuDataGridViewTextBoxColumn,
            this.numermieszkaniaDataGridViewTextBoxColumn,
            this.numertelefonuDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn,
            this.datawaznosciKPPDataGridViewTextBoxColumn,
            this.databadanDataGridViewTextBoxColumn,
            this.stopienDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(956, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.aquadromDataSet;
            // 
            // aquadromDataSet
            // 
            this.aquadromDataSet.DataSetName = "aquadromDataSet";
            this.aquadromDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ądzajToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(980, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ądzajToolStripMenuItem
            // 
            this.ądzajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajUżytkownikówToolStripMenuItem,
            this.UsuńUżytkownikaToolStripMenuItem,
            this.PrzeglądajUżytkownikówToolStripMenuItem});
            this.ądzajToolStripMenuItem.Name = "ądzajToolStripMenuItem";
            this.ądzajToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ądzajToolStripMenuItem.Text = "Zarządzaj";
            // 
            // DodajUżytkownikówToolStripMenuItem
            // 
            this.DodajUżytkownikówToolStripMenuItem.Name = "DodajUżytkownikówToolStripMenuItem";
            this.DodajUżytkownikówToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.DodajUżytkownikówToolStripMenuItem.Text = "Dodaj użytkownika";
            this.DodajUżytkownikówToolStripMenuItem.Click += new System.EventHandler(this.DodajUżytkownikówToolStripMenuItem_Click);
            // 
            // UsuńUżytkownikaToolStripMenuItem
            // 
            this.UsuńUżytkownikaToolStripMenuItem.Name = "UsuńUżytkownikaToolStripMenuItem";
            this.UsuńUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.UsuńUżytkownikaToolStripMenuItem.Text = "Usuń użytkownika";
            this.UsuńUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.UsuńToolStripMenuItem_Click);
            // 
            // PrzeglądajUżytkownikówToolStripMenuItem
            // 
            this.PrzeglądajUżytkownikówToolStripMenuItem.Name = "PrzeglądajUżytkownikówToolStripMenuItem";
            this.PrzeglądajUżytkownikówToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.PrzeglądajUżytkownikówToolStripMenuItem.Text = "Przeglądaj użytkowników";
            this.PrzeglądajUżytkownikówToolStripMenuItem.Click += new System.EventHandler(this.PrzeglądajUżytkownikówToolStripMenuItem_Click);
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miastoDataGridViewTextBoxColumn
            // 
            this.miastoDataGridViewTextBoxColumn.DataPropertyName = "Miasto";
            this.miastoDataGridViewTextBoxColumn.HeaderText = "Miasto";
            this.miastoDataGridViewTextBoxColumn.Name = "miastoDataGridViewTextBoxColumn";
            this.miastoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulicaDataGridViewTextBoxColumn
            // 
            this.ulicaDataGridViewTextBoxColumn.DataPropertyName = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.HeaderText = "Ulica";
            this.ulicaDataGridViewTextBoxColumn.Name = "ulicaDataGridViewTextBoxColumn";
            this.ulicaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerdomuDataGridViewTextBoxColumn
            // 
            this.numerdomuDataGridViewTextBoxColumn.DataPropertyName = "Numer_domu";
            this.numerdomuDataGridViewTextBoxColumn.HeaderText = "Numer_domu";
            this.numerdomuDataGridViewTextBoxColumn.Name = "numerdomuDataGridViewTextBoxColumn";
            this.numerdomuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numermieszkaniaDataGridViewTextBoxColumn
            // 
            this.numermieszkaniaDataGridViewTextBoxColumn.DataPropertyName = "Numer_mieszkania";
            this.numermieszkaniaDataGridViewTextBoxColumn.HeaderText = "Numer_mieszkania";
            this.numermieszkaniaDataGridViewTextBoxColumn.Name = "numermieszkaniaDataGridViewTextBoxColumn";
            this.numermieszkaniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numertelefonuDataGridViewTextBoxColumn
            // 
            this.numertelefonuDataGridViewTextBoxColumn.DataPropertyName = "Numer_telefonu";
            this.numertelefonuDataGridViewTextBoxColumn.HeaderText = "Numer_telefonu";
            this.numertelefonuDataGridViewTextBoxColumn.Name = "numertelefonuDataGridViewTextBoxColumn";
            this.numertelefonuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stanowiskoDataGridViewTextBoxColumn
            // 
            this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
            this.stanowiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datawaznosciKPPDataGridViewTextBoxColumn
            // 
            this.datawaznosciKPPDataGridViewTextBoxColumn.DataPropertyName = "Data_waznosci_KPP";
            this.datawaznosciKPPDataGridViewTextBoxColumn.HeaderText = "Data_waznosci_KPP";
            this.datawaznosciKPPDataGridViewTextBoxColumn.Name = "datawaznosciKPPDataGridViewTextBoxColumn";
            this.datawaznosciKPPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // databadanDataGridViewTextBoxColumn
            // 
            this.databadanDataGridViewTextBoxColumn.DataPropertyName = "Data_badan";
            this.databadanDataGridViewTextBoxColumn.HeaderText = "Data_badan";
            this.databadanDataGridViewTextBoxColumn.Name = "databadanDataGridViewTextBoxColumn";
            this.databadanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stopienDataGridViewTextBoxColumn
            // 
            this.stopienDataGridViewTextBoxColumn.DataPropertyName = "Stopien";
            this.stopienDataGridViewTextBoxColumn.HeaderText = "Stopien";
            this.stopienDataGridViewTextBoxColumn.Name = "stopienDataGridViewTextBoxColumn";
            this.stopienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(980, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Test_FormClosing);
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSet)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ądzajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodajUżytkownikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuńUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrzeglądajUżytkownikówToolStripMenuItem;
        private aquadromDataSet aquadromDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private aquadromDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerdomuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numermieszkaniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numertelefonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawaznosciKPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databadanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopienDataGridViewTextBoxColumn;

    }
}