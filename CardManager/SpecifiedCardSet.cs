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
    public partial class SpecifiedCardSet : Form
    {
        public SpecifiedCardSet()
        {
            InitializeComponent();
        }

        private void SpecifiedCardSet_Load(object sender, EventArgs e)
        {
            DataRowView setCurrent = (DataRowView)specifiedCardSetSelectBindingNavigator.BindingSource.Current;
            int setID = int.Parse(setCurrent[0].ToString());
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CardsBySetsSelect' table. You can move, or remove it, as needed.
            this.cardsBySetsSelectTableAdapter.FillBySetID(this.cardManagerDBDataSet.CardsBySetsSelect, setID);
            this.specifiedCardSetSelectBindingNavigator.BindingSource.PositionChanged += new EventHandler(BindingSource_PositionChanged);
        }


        void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView setCurrent = (DataRowView)specifiedCardSetSelectBindingNavigator.BindingSource.Current;
            int setID = int.Parse(setCurrent[0].ToString());
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CardsBySetsSelect' table. You can move, or remove it, as needed.
            this.cardsBySetsSelectTableAdapter.FillBySetID(this.cardManagerDBDataSet.CardsBySetsSelect, setID);
        }

        internal void LoadCardSets(int CollectionID)
        {
            specifiedCardSetSelectTableAdapter.FillByCollectionID(cardManagerDBDataSet.SpecifiedCardSetSelect, CollectionID);
        }

        private void specifiedCardSetSelectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specifiedCardSetSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }

        private void specifiedCardSetSelectBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.specifiedCardSetSelectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView setCurrent = (DataRowView)specifiedCardSetSelectBindingNavigator.BindingSource.Current;
            int collectionID = int.Parse(setCurrent[4].ToString());
            CardSets cardSetsForm = new CardSets();
            //cardSetsForm.CardSets_Load(collectionID);
            cardSetsForm.Show();
        }
    }
}
