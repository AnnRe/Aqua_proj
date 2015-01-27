namespace aquadrom
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.HasloZmienG = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PowtorzHaslo2 = new System.Windows.Forms.TextBox();
            this.ZmianaHasla = new System.Windows.Forms.Button();
            this.NoweHaslo2 = new System.Windows.Forms.TextBox();
            this.StareHaslo2 = new System.Windows.Forms.TextBox();
            this.PowtorzHaslo = new System.Windows.Forms.Label();
            this.NoweHaslo = new System.Windows.Forms.Label();
            this.StareHaslo = new System.Windows.Forms.Label();
            this.HasloZmienG.SuspendLayout();
            this.SuspendLayout();
            // 
            // HasloZmienG
            // 
            this.HasloZmienG.BackColor = System.Drawing.Color.Azure;
            this.HasloZmienG.Controls.Add(this.button2);
            this.HasloZmienG.Controls.Add(this.PowtorzHaslo2);
            this.HasloZmienG.Controls.Add(this.ZmianaHasla);
            this.HasloZmienG.Controls.Add(this.NoweHaslo2);
            this.HasloZmienG.Controls.Add(this.StareHaslo2);
            this.HasloZmienG.Controls.Add(this.PowtorzHaslo);
            this.HasloZmienG.Controls.Add(this.NoweHaslo);
            this.HasloZmienG.Controls.Add(this.StareHaslo);
            this.HasloZmienG.Location = new System.Drawing.Point(2, 3);
            this.HasloZmienG.Name = "HasloZmienG";
            this.HasloZmienG.Size = new System.Drawing.Size(283, 140);
            this.HasloZmienG.TabIndex = 0;
            this.HasloZmienG.TabStop = false;
            this.HasloZmienG.Text = "Formularz";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(200, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PowtorzHaslo2
            // 
            this.PowtorzHaslo2.Location = new System.Drawing.Point(110, 75);
            this.PowtorzHaslo2.Name = "PowtorzHaslo2";
            this.PowtorzHaslo2.Size = new System.Drawing.Size(166, 20);
            this.PowtorzHaslo2.TabIndex = 3;
            this.PowtorzHaslo2.UseSystemPasswordChar = true;
            // 
            // ZmianaHasla
            // 
            this.ZmianaHasla.BackColor = System.Drawing.Color.Azure;
            this.ZmianaHasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ZmianaHasla.Location = new System.Drawing.Point(110, 108);
            this.ZmianaHasla.Name = "ZmianaHasla";
            this.ZmianaHasla.Size = new System.Drawing.Size(82, 23);
            this.ZmianaHasla.TabIndex = 4;
            this.ZmianaHasla.Text = "Zmień hasło";
            this.ZmianaHasla.UseVisualStyleBackColor = false;
            this.ZmianaHasla.Click += new System.EventHandler(this.ZmianaHasla_Click);
            // 
            // NoweHaslo2
            // 
            this.NoweHaslo2.Location = new System.Drawing.Point(110, 49);
            this.NoweHaslo2.Name = "NoweHaslo2";
            this.NoweHaslo2.Size = new System.Drawing.Size(166, 20);
            this.NoweHaslo2.TabIndex = 2;
            this.NoweHaslo2.UseSystemPasswordChar = true;
            // 
            // StareHaslo2
            // 
            this.StareHaslo2.Location = new System.Drawing.Point(110, 23);
            this.StareHaslo2.Name = "StareHaslo2";
            this.StareHaslo2.Size = new System.Drawing.Size(165, 20);
            this.StareHaslo2.TabIndex = 1;
            this.StareHaslo2.UseSystemPasswordChar = true;
            this.StareHaslo2.TextChanged += new System.EventHandler(this.StareHaslo2_TextChanged);
            // 
            // PowtorzHaslo
            // 
            this.PowtorzHaslo.AutoSize = true;
            this.PowtorzHaslo.Location = new System.Drawing.Point(7, 78);
            this.PowtorzHaslo.Name = "PowtorzHaslo";
            this.PowtorzHaslo.Size = new System.Drawing.Size(78, 13);
            this.PowtorzHaslo.TabIndex = 2;
            this.PowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // NoweHaslo
            // 
            this.NoweHaslo.AutoSize = true;
            this.NoweHaslo.BackColor = System.Drawing.Color.Azure;
            this.NoweHaslo.Location = new System.Drawing.Point(7, 52);
            this.NoweHaslo.Name = "NoweHaslo";
            this.NoweHaslo.Size = new System.Drawing.Size(68, 13);
            this.NoweHaslo.TabIndex = 1;
            this.NoweHaslo.Text = "Nowe hasło:";
            // 
            // StareHaslo
            // 
            this.StareHaslo.AutoSize = true;
            this.StareHaslo.Location = new System.Drawing.Point(7, 26);
            this.StareHaslo.Name = "StareHaslo";
            this.StareHaslo.Size = new System.Drawing.Size(65, 13);
            this.StareHaslo.TabIndex = 0;
            this.StareHaslo.Text = "Stare hasło:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(287, 144);
            this.Controls.Add(this.HasloZmienG);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.Text = "Zmień hasło";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.HasloZmienG.ResumeLayout(false);
            this.HasloZmienG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox HasloZmienG;
        private System.Windows.Forms.Label PowtorzHaslo;
        private System.Windows.Forms.Label NoweHaslo;
        private System.Windows.Forms.Label StareHaslo;
        private System.Windows.Forms.TextBox PowtorzHaslo2;
        private System.Windows.Forms.TextBox NoweHaslo2;
        private System.Windows.Forms.TextBox StareHaslo2;
        private System.Windows.Forms.Button ZmianaHasla;
        private System.Windows.Forms.Button button2;
    }
}