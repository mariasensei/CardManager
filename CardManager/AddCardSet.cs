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
    public partial class AddCardSet : Form
    {
        public AddCardSet()
        {
            InitializeComponent();
        }

        private void AddCardSet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CollectionDropdown' table. You can move, or remove it, as needed.
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "S");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "";

            if (comboBox1.Text == "")
                label5.Text = "You have to select a collection!";
            else if (textBox1.Text == "")
                label5.Text = "You have to give a name for the card set!";
            else
            {
                this.cardSetManagerInsertTableAdapter.FillSetInsert(this.cardManagerDBDataSet.CardSetManagerInsert, comboBox1.Text, textBox1.Text, Convert.ToInt32(numericUpDown1.Value), ref message);
                if (message == "Success")
                    label5.Text = "The new collection was added successfully.";
                else if (message == "Fail1")
                    label5.Text = "Creation failed. Collection already contains 3 sets.";
                else if (message == "Fail2")
                    label5.Text = "Creation failed. Set already exists.";
                else
                    label5.Text = "Something went wrong!";
            }
        }

        
    }
}
