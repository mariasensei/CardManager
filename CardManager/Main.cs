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

        private void m_button1_Click(object sender, EventArgs e)
        {
            AddCard AddCardForm = new AddCard();
            AddCardForm.ShowDialog();
        }

        private void m_button2_Click(object sender, EventArgs e)
        {
            DeleteCard DeleteCardForm = new DeleteCard();
            DeleteCardForm.ShowDialog();
        }

        private void m_button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_button5_Click(object sender, EventArgs e)
        {
            Collections CollectionsForm = new Collections();
            CollectionsForm.MdiParent = this;
            CollectionsForm.WindowState = FormWindowState.Maximized;
            CollectionsForm.Show();
        }

        private void m_button6_Click(object sender, EventArgs e)
        {
            CardSets CardSetsForm = new CardSets();
            CardSetsForm.ShowDialog();
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
    }
}
