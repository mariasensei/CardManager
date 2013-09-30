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
    public partial class UpdateCardSets : Form
    {
        public UpdateCardSets()
        {
            InitializeComponent();
        }

        private void UpdateCardSets_Load(object sender, EventArgs e)
        {
            this.collectionDropdownTableAdapter.Fill(this.cardManagerDBDataSet.CollectionDropdown, "D");
            collectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
