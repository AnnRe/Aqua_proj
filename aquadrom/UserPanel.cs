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
        public UserPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void harmonogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wyświetlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HarmonogramForm harmonogramF = new HarmonogramForm();
            harmonogramF.Show();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
