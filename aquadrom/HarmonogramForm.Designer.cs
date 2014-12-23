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
            this.listBoxMiesiace = new System.Windows.Forms.ListBox();
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
            this.dataGridView1.AutoGenerateColumns = false;
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
            // listBoxMiesiace
            // 
            this.listBoxMiesiace.FormattingEnabled = true;
            this.listBoxMiesiace.Items.AddRange(new object[] {
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
            this.listBoxMiesiace.Location = new System.Drawing.Point(26, 14);
            this.listBoxMiesiace.Name = "listBoxMiesiace";
            this.listBoxMiesiace.Size = new System.Drawing.Size(120, 17);
            this.listBoxMiesiace.TabIndex = 1;
            this.listBoxMiesiace.SelectedIndexChanged += new System.EventHandler(this.listBoxMiesiace_SelectedIndexChanged);
            // 
            // HarmonogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 262);
            this.Controls.Add(this.listBoxMiesiace);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HarmonogramForm";
            this.Text = "Harmonogram";
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
        private System.Windows.Forms.ListBox listBoxMiesiace;
    }
}