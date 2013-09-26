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
    public partial class CardSets : Form
    {
        public CardSets()
        {
            InitializeComponent();
        }

       

        private void CardSets_Load(object sender, EventArgs e)
        {
           
        }

        internal void CardSetsLoadForm(int collectionID)
        {
            //specifiedCardSetSelectBindingNavigator.
        }

        private void specifiedCardSetSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specifiedCardSetSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }
    }
}
