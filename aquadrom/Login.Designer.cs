﻿namespace aquadrom
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.noweHaslo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(138, 67);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.PasswordChar = '*';
            this.UserPasswordBox.Size = new System.Drawing.Size(207, 20);
            this.UserPasswordBox.TabIndex = 10;
            // 
            // UserPassword
            // 
            this.UserPassword.AutoSize = true;
            this.UserPassword.Location = new System.Drawing.Point(30, 74);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(36, 13);
            this.UserPassword.TabIndex = 9;
            this.UserPassword.Text = "Hasło";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(30, 42);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(102, 13);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "Nazwa użytkownika";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(138, 39);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(207, 20);
            this.UserNameBox.TabIndex = 7;
            this.UserNameBox.TextChanged += new System.EventHandler(this.UserNameBox_TextChanged);
            this.UserNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameBox_KeyDown);
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(138, 97);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // noweHaslo
            // 
            this.noweHaslo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noweHaslo.Location = new System.Drawing.Point(219, 97);
            this.noweHaslo.Name = "noweHaslo";
            this.noweHaslo.Size = new System.Drawing.Size(126, 23);
            this.noweHaslo.TabIndex = 11;
            this.noweHaslo.Text = "Zapomniałem hasła";
            this.noweHaslo.UseVisualStyleBackColor = true;
            this.noweHaslo.Click += new System.EventHandler(this.noweHaslo_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::aquadrom.Properties.Resources.bg_page;
            this.ClientSize = new System.Drawing.Size(384, 150);
            this.Controls.Add(this.noweHaslo);
            this.Controls.Add(this.UserPasswordBox);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.LoginButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.Label UserPassword;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Button noweHaslo;

    }
}

