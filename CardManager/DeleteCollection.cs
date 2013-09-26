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
    public partial class DeleteCollection : Form
    {
        public DeleteCollection()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "If you delete this collection, all sets and cards associated with it will be deleted too. Proceed?";
            string title = "Deleting Collection";
            var choice = MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (choice == DialogResult.Cancel)
            {
                this.Close();
            }
            else if (choice == DialogResult.OK)
            {
                //change it for delete
                string message = "";
                this.deleteCollectionTableAdapter.Fill(this.cardManagerDBDataSet.DeleteCollection, comboBox1.Text, ref message);
                if (message == "Success")
                    //label2.Text = "The collection " + textBox1.Text + " was deleted successfully.";
                    label2.Text = "The collection was deleted successfully.";
                else if (message == "Fail")
                    label2.Text = "Deletion failed. Collection doesn't exist.";
                else
                    label2.Text = "Something went wrong!";
            }
        }

        private void DeleteCollection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CollectionDropdown' table. You can move, or remove it, as needed.
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "D");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
