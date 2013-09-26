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
    public partial class UpdateCard : Form
    {
        public UpdateCard()
        {
            InitializeComponent();
        }

        private void UpdateCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CardManagerSelect' table. You can move, or remove it, as needed.
            this.cardManagerSelectTableAdapter.Fill(this.cardManagerDBDataSet.CardManagerSelect);

        }
    }
}
