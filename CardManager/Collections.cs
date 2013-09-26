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
    public partial class Collections : Form
    {
        public Collections()
        {
            InitializeComponent();
        }

        

        private void Collections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.CollectionManager' table. You can move, or remove it, as needed.
            this.collectionManagerTableAdapter.Fill(this.cardManagerDBDataSet.CollectionManager);
          
        }

        private void collectionManagerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.collectionManagerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }

        private void collectionManagerDataGridView_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(collectionManagerDataGridView.Rows[collectionManagerDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            SpecifiedCardSet specifiedCardSetForm = new SpecifiedCardSet();
            specifiedCardSetForm.LoadCardSets(id);
            specifiedCardSetForm.Show();
        }
    }
}
