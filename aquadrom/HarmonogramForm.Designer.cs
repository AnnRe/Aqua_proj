namespace aquadrom
{
    partial class HarmonogramForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aquadromDataSet = new aquadrom.aquadromDataSet();
            this.godzinypracyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.godziny_pracyTableAdapter = new aquadrom.aquadromDataSetTableAdapters.Godziny_pracyTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aquadromDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notatkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notatkaTableAdapter = new aquadrom.aquadromDataSetTableAdapters.NotatkaTableAdapter();
            this.pracownikTableAdapter = new aquadrom.aquadromDataSetTableAdapters.PracownikTableAdapter();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinypracyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notatkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aquadromDataSet
            // 
            this.aquadromDataSet.DataSetName = "aquadromDataSet";
            this.aquadromDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // godzinypracyBindingSource
            // 
            this.godzinypracyBindingSource.DataMember = "Godziny_pracy";
            this.godzinypracyBindingSource.DataSource = this.aquadromDataSet;
            // 
            // godziny_pracyTableAdapter
            // 
            this.godziny_pracyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.pracownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Stanowisko";
            this.dataGridViewTextBoxColumn1.HeaderText = "Stanowisko";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.aquadromDataSetBindingSource;
            // 
            // aquadromDataSetBindingSource
            // 
            this.aquadromDataSetBindingSource.DataSource = this.aquadromDataSet;
            this.aquadromDataSetBindingSource.Position = 0;
            // 
            // notatkaBindingSource
            // 
            this.notatkaBindingSource.DataMember = "Notatka";
            this.notatkaBindingSource.DataSource = this.aquadromDataSet;
            // 
            // notatkaTableAdapter
            // 
            this.notatkaTableAdapter.ClearBeforeFill = true;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.comboBoxMonths.Location = new System.Drawing.Point(12, 12);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonths.TabIndex = 2;
            this.comboBoxMonths.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_SelectedIndexChanged);
            this.comboBoxMonths.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxMonths_MouseClick);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.comboBoxYear.Location = new System.Drawing.Point(170, 12);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(58, 21);
            this.comboBoxYear.TabIndex = 3;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            this.comboBoxYear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxMonths_MouseClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(268, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz zmiany";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(386, 12);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(112, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Sprawdź";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // HarmonogramForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(697, 262);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonths);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HarmonogramForm";
            this.Text = "Harmonogram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HarmonogramForm_FormClosing);
            this.Load += new System.EventHandler(this.HarmonogramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinypracyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aquadromDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notatkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private aquadromDataSet aquadromDataSet;
        private System.Windows.Forms.BindingSource godzinypracyBindingSource;
        private aquadromDataSetTableAdapters.Godziny_pracyTableAdapter godziny_pracyTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource notatkaBindingSource;
        private aquadromDataSetTableAdapters.NotatkaTableAdapter notatkaTableAdapter;
        private System.Windows.Forms.BindingSource aquadromDataSetBindingSource;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private aquadromDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button btn_check;
    }
}