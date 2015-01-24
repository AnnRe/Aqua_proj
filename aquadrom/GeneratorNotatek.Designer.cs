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
            this.SuspendLayout();
            // 
            // Generuj
            // 
            this.Generuj.Location = new System.Drawing.Point(351, 407);
            this.Generuj.Name = "Generuj";
            this.Generuj.Size = new System.Drawing.Size(116, 23);
            this.Generuj.TabIndex = 0;
            this.Generuj.Text = "Generuj notatkę";
            this.Generuj.UseVisualStyleBackColor = true;
            this.Generuj.Click += new System.EventHandler(this.Generuj_Click);
            // 
            // AnulujNotatke
            // 
            this.AnulujNotatke.Location = new System.Drawing.Point(473, 407);
            this.AnulujNotatke.Name = "AnulujNotatke";
            this.AnulujNotatke.Size = new System.Drawing.Size(75, 23);
            this.AnulujNotatke.TabIndex = 1;
            this.AnulujNotatke.Text = "Anuluj";
            this.AnulujNotatke.UseVisualStyleBackColor = true;
            // 
            // TekstNotatki
            // 
            this.TekstNotatki.BackColor = System.Drawing.Color.Azure;
            this.TekstNotatki.Location = new System.Drawing.Point(38, 72);
            this.TekstNotatki.Name = "TekstNotatki";
            this.TekstNotatki.Size = new System.Drawing.Size(510, 122);
            this.TekstNotatki.TabIndex = 2;
            this.TekstNotatki.Text = "";
            this.TekstNotatki.TextChanged += new System.EventHandler(this.TekstNotatki_TextChanged);
            // 
            // GeneratorNotatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::aquadrom.Properties.Resources.bg_page;
            this.ClientSize = new System.Drawing.Size(583, 442);
            this.Controls.Add(this.TekstNotatki);
            this.Controls.Add(this.AnulujNotatke);
            this.Controls.Add(this.Generuj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorNotatek";
            this.Text = "GeneratorNotatek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneratorNotatek_FormClosing);
            this.Load += new System.EventHandler(this.GeneratorNotatek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generuj;
        private System.Windows.Forms.Button AnulujNotatke;
        private System.Windows.Forms.RichTextBox TekstNotatki;
    }
}