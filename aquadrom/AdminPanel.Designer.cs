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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ądzajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrzeglądajUżytkownikówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(956, 386);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // ądzajToolStripMenuItem
            // 
            this.ądzajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DodajUżytkownikówToolStripMenuItem,
            this.edytujUżytkownikaToolStripMenuItem,
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
            // edytujUżytkownikaToolStripMenuItem
            // 
            this.edytujUżytkownikaToolStripMenuItem.Name = "edytujUżytkownikaToolStripMenuItem";
            this.edytujUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.edytujUżytkownikaToolStripMenuItem.Text = "Edytuj użytkownika";
            this.edytujUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.edytujUżytkownikaToolStripMenuItem_Click);
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
            this.Text = "Panel Administratora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ądzajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DodajUżytkownikówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuńUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrzeglądajUżytkownikówToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}