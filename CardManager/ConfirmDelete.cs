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
    public partial class ConfirmDelete : Form
    {
        public ConfirmDelete()
        {
            InitializeComponent();
            dc_label6.Text = DeleteCard.deleteNumber;
            dc_label7.Text = DeleteCard.deleteName;
            dc_label8.Text = DeleteCard.deleteBlock;
            dc_label9.Text = DeleteCard.deleteDescription;
        }

        private void dc_button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dc_button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
