using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquadrom
{
    public partial class UserPanel : Form
    {
        string sql = "";
        public UserPanel(string login)
        {
            InitializeComponent();
            string login2 = login;
            sql += login2; 
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
        }

        private void harmonogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarmonogramForm harmonogramF = new HarmonogramForm(false);
            if (!HarmonogramForm.exists)
                harmonogramF.Show();
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void daneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zmieńHasłoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(sql);
            change.Show();
        }

        private void napiszNotatkęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratorNotatek change = new GeneratorNotatek(sql);
            change.Show();

        }
    }
}
