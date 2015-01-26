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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.harmonogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.napiszNotatkęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.harmonogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlToolStripMenuItem,
            this.edytujToolStripMenuItem});
            this.harmonogramToolStripMenuItem.Name = "harmonogramToolStripMenuItem";
            this.harmonogramToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.harmonogramToolStripMenuItem.Text = "Harmonogram";
            this.harmonogramToolStripMenuItem.Click += new System.EventHandler(this.harmonogramToolStripMenuItem_Click);
            // 
            // wyświetlToolStripMenuItem
            // 
            this.wyświetlToolStripMenuItem.Name = "wyświetlToolStripMenuItem";
            this.wyświetlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.wyświetlToolStripMenuItem.Text = "Wyświetl";
            this.wyświetlToolStripMenuItem.Click += new System.EventHandler(this.wyświetlToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            this.edytujToolStripMenuItem.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // notatkiToolStripMenuItem
            // 
            this.notatkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.napiszNotatkęToolStripMenuItem});
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
            this.daneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńHasłoToolStripMenuItem});
            this.daneToolStripMenuItem.Name = "daneToolStripMenuItem";
            this.daneToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.daneToolStripMenuItem.Text = "Dane";
            this.daneToolStripMenuItem.Click += new System.EventHandler(this.daneToolStripMenuItem_Click);
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            this.zmieńHasłoToolStripMenuItem.Click += new System.EventHandler(this.zmieńHasłoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // napiszNotatkęToolStripMenuItem
            // 
            this.napiszNotatkęToolStripMenuItem.Name = "napiszNotatkęToolStripMenuItem";
            this.napiszNotatkęToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.napiszNotatkęToolStripMenuItem.Text = "Napisz notatkę";
            this.napiszNotatkęToolStripMenuItem.Click += new System.EventHandler(this.napiszNotatkęToolStripMenuItem_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 343);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPanel";
            this.Text = "UserPanel";
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
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem napiszNotatkęToolStripMenuItem;
    }
}