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
    public partial class DeleteCard : Form
    {
        public static int deletePosition;
        public static string deleteNumber;
        public static string deleteName;
        public static string deleteBlock;
        public static string deleteDescription;

        public DeleteCard()
        {
            InitializeComponent();
        }

        private void d_button1_Click(object sender, EventArgs e)
        {
            if((d_textBox1.Text == "") && (d_textBox2.Text == ""))
            {
                Main.errorMsgDeleteCard = "You must give a value for the name or the number of the card.";
                DeleteCardError DeleteCardErrorForm = new DeleteCardError();
                DeleteCardErrorForm.Show();
            }
            else
            {
                if(d_comboBox1.Text == "")
                {
                    Main.errorMsgDeleteCard = "Please give a value for the block of the card to be deleted.";
                    DeleteCardError DeleteCardErrorForm = new DeleteCardError();
                    DeleteCardErrorForm.Show();
                }
                else
                {
                    ;
                }
            }
        }
    }
}
