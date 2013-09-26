using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CardManager
{
    public partial class AddCardConfirmed : Form
    {
        public AddCardConfirmed()
        {
            InitializeComponent();
        }

        private void cc_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
