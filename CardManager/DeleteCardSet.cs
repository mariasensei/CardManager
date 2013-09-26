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
    public partial class DeleteCardSet : Form
    {
        public DeleteCardSet()
        {
            InitializeComponent();
        }

        private void DeletCardSet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CollectionDropdown' table. You can move, or remove it, as needed.
            this.cardSetDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CardSetDropdown, "D");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "If you delete this card set, all cards associated with it will be deleted too. Proceed?";
            string title = "Deleting CardSet";
            var choice = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (choice == DialogResult.Cancel)
            {
                this.Close();
            }
            else if (choice == DialogResult.OK)
            {
                //change it for delete
                string message = "";
                this.deleteCardSetTableAdapter.Fill(this.cardManagerDBDataSet.DeleteCardSet, comboBox1.Text, ref message);
                if (message == "Success")
                    //label2.Text = "The collection " + textBox1.Text + " was deleted successfully.";
                    label2.Text = "The CardSet was deleted successfully.";
                else if (message == "Fail")
                    label2.Text = "Deletion failed. CardSet doesn't exist.";
                else
                    label2.Text = "Something went wrong!";
            }
        }

        /*private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                object errorMessage = errorMessageToolStripTextBox.Text;
                this.deleteCardSetTableAdapter.Fill(this.cardManagerDBDataSet.DeleteCardSet, nameToolStripTextBox.Text, errorMessage);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }*/
    }
}
