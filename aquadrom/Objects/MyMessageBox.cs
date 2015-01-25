using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquadrom.Objects
{
    public partial class MyMessageBox : Form
    {

        static MyMessageBox newMessageBox;
        public Label label;
        static string Button_id;
        public DialogResult dialogResult;
        int disposeFormTimer;
        MessageBoxButtons buttons;

        public MyMessageBox()
        {
            InitializeComponent();
            label = label1;
        }

        public static string ShowBox(string txtMessage)
        {

            newMessageBox = new MyMessageBox();
            newMessageBox.buttons = MessageBoxButtons.OK;
            newMessageBox.button1.Text = "OK";
            newMessageBox.button1.Visible = true;
            newMessageBox.button2.Visible = false;
            newMessageBox.button3.Visible = false;

            newMessageBox.label.Text = txtMessage;
            newMessageBox.ShowDialog();
            
            return Button_id;
        }

        public static DialogResult ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBox();

            newMessageBox.buttons = MessageBoxButtons.OK;
            newMessageBox.button1.Text = "OK";
            newMessageBox.button1.Visible = true;
            newMessageBox.button2.Visible = false;
            newMessageBox.button3.Visible = false;
            newMessageBox.Text = txtTitle;
            newMessageBox.label.Text = txtMessage;
            
            newMessageBox.ShowDialog();
            return newMessageBox.dialogResult;
        }

        public static DialogResult ShowBox(string txtMessage, string txtTitle,MessageBoxButtons messageBoxButtons)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.buttons = messageBoxButtons;

            if (messageBoxButtons == MessageBoxButtons.OK)
            {
                newMessageBox.button1.Text = "OK";
                newMessageBox.button1.Visible = true;
                newMessageBox.button2.Visible = false;
                newMessageBox.button3.Visible = false;
            }
            else if(messageBoxButtons==MessageBoxButtons.YesNo)
            {
                newMessageBox.button1.Text = "Tak";
                newMessageBox.button1.Visible = true;
                newMessageBox.button2.Text = "Nie";
                newMessageBox.button2.Visible = true;
                newMessageBox.button3.Visible = false;
            }
            else if (messageBoxButtons == MessageBoxButtons.YesNoCancel)
            {
                newMessageBox.button1.Text = "Tak";
                newMessageBox.button1.Visible = true;
                newMessageBox.button2.Text = "Nie";
                newMessageBox.button2.Visible = true;
                newMessageBox.button3.Text = "Anuluj";
                newMessageBox.button3.Visible = true;
            }
            newMessageBox.Text = txtTitle;
            newMessageBox.label.Text = txtMessage;

            newMessageBox.ShowDialog();
            return newMessageBox.dialogResult;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (buttons == MessageBoxButtons.OK)
                dialogResult = DialogResult.OK;
            else 
                dialogResult = DialogResult.Yes;
            
            Button_id = "1";
            newMessageBox.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.No;
            Button_id = "2";
            newMessageBox.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.Cancel;

            Button_id = "3";
            newMessageBox.Dispose();
        }

        private void MyMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
    }
}
