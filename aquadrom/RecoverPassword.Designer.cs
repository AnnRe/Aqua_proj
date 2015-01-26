namespace aquadrom
{
    partial class RecoverPassword
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
            this.wyslijNowe = new System.Windows.Forms.GroupBox();
            this.mailZapomniany1 = new System.Windows.Forms.Label();
            this.mailZapomniany = new System.Windows.Forms.TextBox();
            this.loginZapomniany = new System.Windows.Forms.TextBox();
            this.loginZapomniany1 = new System.Windows.Forms.Label();
            this.Anulujprzy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.wyslijNowe.SuspendLayout();
            this.SuspendLayout();
            // 
            // wyslijNowe
            // 
            this.wyslijNowe.Controls.Add(this.mailZapomniany1);
            this.wyslijNowe.Controls.Add(this.mailZapomniany);
            this.wyslijNowe.Controls.Add(this.loginZapomniany);
            this.wyslijNowe.Controls.Add(this.loginZapomniany1);
            this.wyslijNowe.Controls.Add(this.Anulujprzy);
            this.wyslijNowe.Controls.Add(this.button1);
            this.wyslijNowe.Location = new System.Drawing.Point(3, 3);
            this.wyslijNowe.Name = "wyslijNowe";
            this.wyslijNowe.Size = new System.Drawing.Size(281, 105);
            this.wyslijNowe.TabIndex = 0;
            this.wyslijNowe.TabStop = false;
            this.wyslijNowe.Text = "Formularz";
            // 
            // mailZapomniany1
            // 
            this.mailZapomniany1.AutoSize = true;
            this.mailZapomniany1.Location = new System.Drawing.Point(7, 52);
            this.mailZapomniany1.Name = "mailZapomniany1";
            this.mailZapomniany1.Size = new System.Drawing.Size(38, 13);
            this.mailZapomniany1.TabIndex = 5;
            this.mailZapomniany1.Text = "E-mail:";
            // 
            // mailZapomniany
            // 
            this.mailZapomniany.Location = new System.Drawing.Point(110, 49);
            this.mailZapomniany.Name = "mailZapomniany";
            this.mailZapomniany.Size = new System.Drawing.Size(166, 20);
            this.mailZapomniany.TabIndex = 4;
            // 
            // loginZapomniany
            // 
            this.loginZapomniany.Location = new System.Drawing.Point(110, 23);
            this.loginZapomniany.Name = "loginZapomniany";
            this.loginZapomniany.Size = new System.Drawing.Size(166, 20);
            this.loginZapomniany.TabIndex = 3;
            this.loginZapomniany.TextChanged += new System.EventHandler(this.loginZapomniany_TextChanged);
            this.loginZapomniany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginZapomniany_KeyPress);
            // 
            // loginZapomniany1
            // 
            this.loginZapomniany1.AutoSize = true;
            this.loginZapomniany1.Location = new System.Drawing.Point(7, 26);
            this.loginZapomniany1.Name = "loginZapomniany1";
            this.loginZapomniany1.Size = new System.Drawing.Size(36, 13);
            this.loginZapomniany1.TabIndex = 2;
            this.loginZapomniany1.Text = "Login:";
            // 
            // Anulujprzy
            // 
            this.Anulujprzy.Location = new System.Drawing.Point(201, 75);
            this.Anulujprzy.Name = "Anulujprzy";
            this.Anulujprzy.Size = new System.Drawing.Size(75, 23);
            this.Anulujprzy.TabIndex = 1;
            this.Anulujprzy.Text = "Anuluj";
            this.Anulujprzy.UseVisualStyleBackColor = true;
            this.Anulujprzy.Click += new System.EventHandler(this.Anulujprzy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyślij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 113);
            this.Controls.Add(this.wyslijNowe);
            this.Name = "RecoverPassword";
            this.Text = "Zapomniałem hasła";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecoverPassword_FormClosing);
            this.wyslijNowe.ResumeLayout(false);
            this.wyslijNowe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox wyslijNowe;
        private System.Windows.Forms.Button Anulujprzy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginZapomniany1;
        private System.Windows.Forms.TextBox loginZapomniany;
        private System.Windows.Forms.TextBox mailZapomniany;
        private System.Windows.Forms.Label mailZapomniany1;
    }
}