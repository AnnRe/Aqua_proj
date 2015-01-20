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
            this.HasloZmienG = new System.Windows.Forms.GroupBox();
            this.StareHaslo = new System.Windows.Forms.Label();
            this.NoweHaslo = new System.Windows.Forms.Label();
            this.PowtorzHaslo = new System.Windows.Forms.Label();
            this.StareHaslo2 = new System.Windows.Forms.TextBox();
            this.NoweHaslo2 = new System.Windows.Forms.TextBox();
            this.PowtorzHaslo2 = new System.Windows.Forms.TextBox();
            this.ZmianaHasla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HasloZmienG.SuspendLayout();
            this.SuspendLayout();
            // 
            // HasloZmienG
            // 
            this.HasloZmienG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HasloZmienG.Controls.Add(this.PowtorzHaslo2);
            this.HasloZmienG.Controls.Add(this.NoweHaslo2);
            this.HasloZmienG.Controls.Add(this.StareHaslo2);
            this.HasloZmienG.Controls.Add(this.PowtorzHaslo);
            this.HasloZmienG.Controls.Add(this.NoweHaslo);
            this.HasloZmienG.Controls.Add(this.StareHaslo);
            this.HasloZmienG.Location = new System.Drawing.Point(3, 3);
            this.HasloZmienG.Name = "HasloZmienG";
            this.HasloZmienG.Size = new System.Drawing.Size(282, 111);
            this.HasloZmienG.TabIndex = 0;
            this.HasloZmienG.TabStop = false;
            this.HasloZmienG.Text = "Formularz";
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
            // NoweHaslo
            // 
            this.NoweHaslo.AutoSize = true;
            this.NoweHaslo.Location = new System.Drawing.Point(7, 52);
            this.NoweHaslo.Name = "NoweHaslo";
            this.NoweHaslo.Size = new System.Drawing.Size(68, 13);
            this.NoweHaslo.TabIndex = 1;
            this.NoweHaslo.Text = "Nowe hasło:";
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
            // StareHaslo2
            // 
            this.StareHaslo2.Location = new System.Drawing.Point(110, 23);
            this.StareHaslo2.Name = "StareHaslo2";
            this.StareHaslo2.Size = new System.Drawing.Size(166, 20);
            this.StareHaslo2.TabIndex = 3;
            this.StareHaslo2.UseSystemPasswordChar = true;
            // 
            // NoweHaslo2
            // 
            this.NoweHaslo2.Location = new System.Drawing.Point(110, 49);
            this.NoweHaslo2.Name = "NoweHaslo2";
            this.NoweHaslo2.Size = new System.Drawing.Size(166, 20);
            this.NoweHaslo2.TabIndex = 4;
            this.NoweHaslo2.UseSystemPasswordChar = true;
            // 
            // PowtorzHaslo2
            // 
            this.PowtorzHaslo2.Location = new System.Drawing.Point(110, 75);
            this.PowtorzHaslo2.Name = "PowtorzHaslo2";
            this.PowtorzHaslo2.Size = new System.Drawing.Size(166, 20);
            this.PowtorzHaslo2.TabIndex = 5;
            this.PowtorzHaslo2.UseSystemPasswordChar = true;
            // 
            // ZmianaHasla
            // 
            this.ZmianaHasla.Location = new System.Drawing.Point(110, 120);
            this.ZmianaHasla.Name = "ZmianaHasla";
            this.ZmianaHasla.Size = new System.Drawing.Size(94, 23);
            this.ZmianaHasla.TabIndex = 1;
            this.ZmianaHasla.Text = "Zmień hasło";
            this.ZmianaHasla.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 146);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ZmianaHasla);
            this.Controls.Add(this.HasloZmienG);
            this.Name = "ChangePassword";
            this.Text = "Zmień hasło";
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