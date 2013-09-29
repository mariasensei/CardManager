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
    public partial class AddCopyOfCard : Form
    {
        public AddCopyOfCard()
        {
            InitializeComponent();
        }

        private void AddCopyOfCard_Load(object sender, EventArgs e)
        {
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "D");
            collectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            setComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cardComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void RefreshSetComboBox(object sender, EventArgs e)
        {
            this.cardSetDropdownCardTableAdapter.Fill(this.cardManagerDBDataSet.CardSetDropdownCard, collectionComboBox.Text);
        }

        private void RefreshCardComboBox(object sender, EventArgs e)
        {
            this.cardDropDownTableAdapter.Fill(this.cardManagerDBDataSet.CardDropDown, setComboBox.Text);
        }

        private void AddCards_Click(object sender, EventArgs e)
        {
            string msg = "";
            this.addCardCopyTableAdapter.Fill(this.cardManagerDBDataSet.AddCardCopy, collectionComboBox.Text, setComboBox.Text, cardComboBox.Text, (int?)normalNumeric.Value, (int?)follieNumeric.Value, ref msg);
            if (msg == "Fail")
                msg = "Failed to update card.";
            else if (msg == "Success")
                msg = "Card updated successfully.";
            label8.Text = msg;
            label8.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
