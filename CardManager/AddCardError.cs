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
    public partial class AddCardError : Form
    {
        public AddCardError()
        {
            InitializeComponent();
            e_label1.Text = Main.errorMsgAddCard;
        }

        private void e_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
