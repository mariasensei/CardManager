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
    public partial class Main : Form
    {
        public static string errorMsgAddCard;
        public static string errorMsgDeleteCard;
            

        public Main()
        {
            InitializeComponent();
        }

        private void insertNewCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCollection AddNewCollectionForm = new AddNewCollection();
            AddNewCollectionForm.MdiParent = this;
            AddNewCollectionForm.WindowState = FormWindowState.Maximized;
            AddNewCollectionForm.Show();
        }

        private void updateViewCollectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCollection UpdateCollectionForm = new UpdateCollection();
            UpdateCollectionForm.MdiParent = this;
            UpdateCollectionForm.WindowState = FormWindowState.Maximized;
            UpdateCollectionForm.Show();
        }

        private void deleteCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCollection DeleteCollectionForm = new DeleteCollection();
            DeleteCollectionForm.MdiParent = this;
            DeleteCollectionForm.WindowState = FormWindowState.Maximized;
            DeleteCollectionForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Do you really want to exit?", "Leaving so soon?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
                this.Close();
        }

        private void insertNewSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCardSet AddCardSetForm = new AddCardSet();
            AddCardSetForm.MdiParent = this;
            AddCardSetForm.WindowState = FormWindowState.Maximized;
            AddCardSetForm.Show();
        }

        private void deleteSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCardSet DeleteCardSetForm = new DeleteCardSet();
            DeleteCardSetForm.MdiParent = this;
            DeleteCardSetForm.WindowState = FormWindowState.Maximized;
            DeleteCardSetForm.Show();
        }

        private void insertNewCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCard AddNewCardForm = new AddNewCard();
            AddNewCardForm.MdiParent = this;
            AddNewCardForm.WindowState = FormWindowState.Maximized;
            AddNewCardForm.Show();
        }

        private void viewUpdateCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCard UpdateCardForm = new UpdateCard();
            UpdateCardForm.MdiParent = this;
            UpdateCardForm.WindowState = FormWindowState.Maximized;
            UpdateCardForm.Show();
        }

        private void addOneCopyInExistingCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCopyOfCard AddCopyOfCardForm = new AddCopyOfCard();
            AddCopyOfCardForm.MdiParent = this;
            AddCopyOfCardForm.WindowState = FormWindowState.Maximized;
            AddCopyOfCardForm.Show();
        }

        private void deleteCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCard DeleteCardForm = new DeleteCard();
            DeleteCardForm.MdiParent = this;
            DeleteCardForm.WindowState = FormWindowState.Maximized;
            DeleteCardForm.Show();
        }

        private void updateViewSetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCardSets UpdateCardSetsForm = new UpdateCardSets();
            UpdateCardSetsForm.MdiParent = this;
            UpdateCardSetsForm.WindowState = FormWindowState.Maximized;
            UpdateCardSetsForm.Show();
        }
    }
}
