using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aquadrom.Objects
{
    internal partial class myMessage : Form
    {
        /// <summary>
        /// This constructor is required for designer support.
        /// </summary>
        public myMessage()
        {
            InitializeComponent();
        }

        public myMessage(string title, string description)
        {
            InitializeComponent();

            this.titleLabel.Text = title;
            this.descriptionLabel.Text = description;
        }
    }
}
