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
    public partial class AddNewCard : Form
    {
        public AddNewCard()
        {
            InitializeComponent();
        }

        public void AddNewCard_Load(object sender, EventArgs e)
        {
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "D");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //this.cardSetDropdownCardTableAdapter.Fill(this.cardManagerDBDataSet.CardSetDropdownCard, comboBox1.Text);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void RefreshCombobox2(object sender, EventArgs e)
        {
            this.cardSetDropdownCardTableAdapter.Fill(this.cardManagerDBDataSet.CardSetDropdownCard, comboBox1.Text);
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void RefreshTotalSetLabel(object sender, EventArgs e)
        {
            int? totalCards = -1;
            this.cardSetTotalAmountTableAdapter.Fill(this.cardManagerDBDataSet.CardSetTotalAmount, comboBox2.Text, ref totalCards);
            totalSetLabel.Text = "/" + totalCards;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (comboBox1.Text == "")
                msg = "Collection is required";
            else if (comboBox2.Text == "")
                msg = "CardSet is required";
            else if (cardNameTextBox.Text == "")
                msg = "Name is required";
            else if (cardTypeComboBox.Text == "")
                msg = "Type is required";
            else if (rarityComboBox.Text == "")
                msg = "Rarity is required";
            else if (colorComboBox.Text == "")
                msg = "Color is required";
            else if (languageComboBox.Text == "")
                msg = "Language is required";
            else if (collectorNumeric.Value == 0)
                msg = "Collector Number is required";
            else if ((normalAmountNumeric.Value + follieAmountNumeric.Value) == 0)
                msg = "Amount of cards is required";
            else
            {

                this.cardManagerInsertTableAdapter.Fill(this.cardManagerDBDataSet.CardManagerInsert, "I", (int?)collectorNumeric.Value, cardNameTextBox.Text, (int?)normalAmountNumeric.Value,
                    languageComboBox.Text, rarityComboBox.Text, comboBox2.Text, cardDescription.Text, cardTypeComboBox.Text,
                    subtypeTextbox.Text, colorComboBox.Text, color2ComboBox.Text, color3ComboBox.Text, (int?)follieAmountNumeric.Value, ref msg);

                if (msg == "Fail1")
                    msg = "Please fill all required fields";
                else if (msg == "Fail2")
                {
                    string normal = normalAmountNumeric.Value.ToString();
                    var msgReply = MessageBox.Show("Card already exists. Add " + normalAmountNumeric.Value.ToString() + " normal and " + follieAmountNumeric.Value.ToString() + " follie?", "Card already in database.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msgReply == DialogResult.No)
                        this.Close();
                    else
                    {
                        this.cardManagerInsertTableAdapter.Fill(this.cardManagerDBDataSet.CardManagerInsert, "A", (int?)collectorNumeric.Value, cardNameTextBox.Text, (int?)normalAmountNumeric.Value,
                            languageComboBox.Text, rarityComboBox.Text, comboBox2.Text, cardDescription.Text, cardTypeComboBox.Text,
                            subtypeTextbox.Text, colorComboBox.Text, color2ComboBox.Text, color3ComboBox.Text, (int?)follieAmountNumeric.Value, ref msg);

                        if (msg == "Success")
                            msg = "Card added successfully.";
                    }
                }
                else if (msg == "Fail4")
                    msg = "Card Number is out of range.";
                else if (msg == "Fail3")
                    msg = "CardSet with that name does not exist.";
                else if (msg == "Success")
                    msg = "Card added successfully.";

                msgLabel.Text = msg;
                msgLabel.Visible = true;
            }
            if (msg != "")
            {
                msgLabel.Text = msg;
                msgLabel.Visible = true;
            }
        }
    }
}
