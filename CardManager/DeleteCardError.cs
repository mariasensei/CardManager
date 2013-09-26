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
    public partial class DeleteCardError : Form
    {
        public DeleteCardError()
        {
            InitializeComponent();
            e2_label1.Text = Main.errorMsgDeleteCard;
        }

        private void e2_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
