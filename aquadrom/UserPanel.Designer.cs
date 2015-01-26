namespace aquadrom
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.harmonogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harmonogramToolStripMenuItem,
            this.notatkiToolStripMenuItem,
            this.umowaToolStripMenuItem,
            this.daneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // harmonogramToolStripMenuItem
            // 
            this.harmonogramToolStripMenuItem.Name = "harmonogramToolStripMenuItem";
            this.harmonogramToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.harmonogramToolStripMenuItem.Text = "Harmonogram";
            this.harmonogramToolStripMenuItem.Click += new System.EventHandler(this.harmonogramToolStripMenuItem_Click);
            // 
            // notatkiToolStripMenuItem
            // 
            this.notatkiToolStripMenuItem.Name = "notatkiToolStripMenuItem";
            this.notatkiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.notatkiToolStripMenuItem.Text = "Notatki";
            // 
            // umowaToolStripMenuItem
            // 
            this.umowaToolStripMenuItem.Name = "umowaToolStripMenuItem";
            this.umowaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.umowaToolStripMenuItem.Text = "Umowa";
            // 
            // daneToolStripMenuItem
            // 
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::aquadrom.Properties.Resources.bg_page;
            this.ClientSize = new System.Drawing.Size(488, 343);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPanel_FormClosed);
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem harmonogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daneToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wyświetlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
    }
}