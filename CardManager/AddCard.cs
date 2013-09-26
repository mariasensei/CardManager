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
    public partial class AddCard : Form
    {
        private String SQLQuery = "";

        public AddCard()
        {
            InitializeComponent();
        }

       

        private void a_button2_Click(object sender, EventArgs e)
        {
            if ((a_textBox2.Text == "") || (a_textbox3.Text == "") || (a_comboBox1.Text == "") || (a_comboBox2.Text == ""))
            {
                Main.errorMsgAddCard = "Please fill in all the required fields before adding a new card.";
                AddCardError AddCardErrorForm = new AddCardError();
                AddCardErrorForm.Show();
            }
            else
            {
                SQLQuery = "SELECT * FROM Card WHERE Number = " + a_textBox1.Text + " and ";
            }
        }

        private void a_button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
