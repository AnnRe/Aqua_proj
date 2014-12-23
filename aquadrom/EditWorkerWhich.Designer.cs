namespace aquadrom
{
    partial class EditWorkerWhich
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
            this.EditWorkerComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditWorkerComboBox
            // 
            this.EditWorkerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditWorkerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditWorkerComboBox.FormattingEnabled = true;
            this.EditWorkerComboBox.Location = new System.Drawing.Point(62, 31);
            this.EditWorkerComboBox.Name = "EditWorkerComboBox";
            this.EditWorkerComboBox.Size = new System.Drawing.Size(231, 21);
            this.EditWorkerComboBox.TabIndex = 8;
            this.EditWorkerComboBox.SelectedIndexChanged += new System.EventHandler(this.EditWorkerComboBox_SelectedIndexChanged);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(62, 77);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(110, 23);
            this.ChooseButton.TabIndex = 1;
            this.ChooseButton.Text = "Wybierz";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditWorkerWhich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(348, 112);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.EditWorkerComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditWorkerWhich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj pracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditWorkerWhich_FormClosing);
            this.Load += new System.EventHandler(this.EditWorkerWhich_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EditWorkerComboBox;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button button1;
    }
}