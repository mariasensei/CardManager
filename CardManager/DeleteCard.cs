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

        private void DeleteCard_Load(object sender, EventArgs e)
        {
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "D");
            collectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            setComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void setComboBoxRefresh(object sender, EventArgs e)
        {
            this.cardSetDropdownCardTableAdapter.Fill(this.cardManagerDBDataSet.CardSetDropdownCard, collectionComboBox.Text);
        }

        private void cardComboBoxRefresh(object sender, EventArgs e)
        {
            this.cardDropDownTableAdapter.Fill(this.cardManagerDBDataSet.CardDropDown, setComboBox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string msg = "";
            this.cardManagerDeleteTableAdapter.Fill(this.cardManagerDBDataSet.CardManagerDelete, collectionComboBox.Text, setComboBox.Text, cardComboBox.Text, ref msg);
            if (msg == "Success")
                msg = "The card was deleted successfully.";
            else if (msg == "Fail")
                msg = "Failed to delete card.";

            label4.Text = msg;
            label4.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
