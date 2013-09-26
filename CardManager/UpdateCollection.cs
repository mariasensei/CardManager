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
    public partial class UpdateCollection : Form
    {
        public UpdateCollection()
        {
            InitializeComponent();
        }

        private void updateCollectionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.updateCollectionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cardManagerDBDataSet);

        }

        private void UpdateCollection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cardManagerDBDataSet.UpdateCollection' table. You can move, or remove it, as needed.
            this.updateCollectionTableAdapter.Fill(this.cardManagerDBDataSet.UpdateCollection);

        }
     }
}
