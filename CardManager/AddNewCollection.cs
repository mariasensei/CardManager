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
    public partial class AddNewCollection : Form
    {
        public AddNewCollection()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string message = "";
            this.addNewCollectionTableAdapter.FillNewCollection(this.cardManagerDBDataSet.AddNewCollection, textBox1.Text, ref message);
            if (message == "Success")
                label2.Text = "The new collection was added successfully.";
            else if (message == "Fail")
                label2.Text = "Creation failed. Collection already exists.";
            else
                label2.Text = "Something went wrong!";
        }

        

        /*private void button1_Click()
        {

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewCollectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addNewCollectionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }
        
    }
}
