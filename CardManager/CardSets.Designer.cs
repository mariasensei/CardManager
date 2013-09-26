namespace CardManager
{
    partial class CardSets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardSets));
            System.Windows.Forms.Label setIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label cardAmountLabel;
            System.Windows.Forms.Label collectionNameLabel;
            System.Windows.Forms.Label collectionIDLabel;
            this.Collection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.specifiedCardSetSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specifiedCardSetSelectTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.SpecifiedCardSetSelectTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.specifiedCardSetSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.specifiedCardSetSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.setIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cardAmountTextBox = new System.Windows.Forms.TextBox();
            this.collectionNameTextBox = new System.Windows.Forms.TextBox();
            this.collectionIDTextBox = new System.Windows.Forms.TextBox();
            setIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            cardAmountLabel = new System.Windows.Forms.Label();
            collectionNameLabel = new System.Windows.Forms.Label();
            collectionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingNavigator)).BeginInit();
            this.specifiedCardSetSelectBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Collection
            // 
            this.Collection.DataPropertyName = "CollectionID";
            this.Collection.HeaderText = "Collection";
            this.Collection.Name = "Collection";
            // 
            // cardManagerDBDataSet
            // 
            this.cardManagerDBDataSet.DataSetName = "CardManagerDBDataSet";
            this.cardManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specifiedCardSetSelectBindingSource
            // 
            this.specifiedCardSetSelectBindingSource.DataMember = "SpecifiedCardSetSelect";
            this.specifiedCardSetSelectBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // specifiedCardSetSelectTableAdapter
            // 
            this.specifiedCardSetSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CollectionManagerTableAdapter = null;
            this.tableAdapterManager.SpecifiedCardSetSelectTableAdapter = this.specifiedCardSetSelectTableAdapter;
            this.tableAdapterManager.UpdateOrder = CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specifiedCardSetSelectBindingNavigator
            // 
            this.specifiedCardSetSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specifiedCardSetSelectBindingNavigator.BindingSource = this.specifiedCardSetSelectBindingSource;
            this.specifiedCardSetSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specifiedCardSetSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specifiedCardSetSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.specifiedCardSetSelectBindingNavigatorSaveItem});
            this.specifiedCardSetSelectBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specifiedCardSetSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specifiedCardSetSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specifiedCardSetSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specifiedCardSetSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specifiedCardSetSelectBindingNavigator.Name = "specifiedCardSetSelectBindingNavigator";
            this.specifiedCardSetSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specifiedCardSetSelectBindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.specifiedCardSetSelectBindingNavigator.TabIndex = 0;
            this.specifiedCardSetSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // specifiedCardSetSelectBindingNavigatorSaveItem
            // 
            this.specifiedCardSetSelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specifiedCardSetSelectBindingNavigatorSaveItem.Image")));
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Name = "specifiedCardSetSelectBindingNavigatorSaveItem";
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Text = "Save Data";
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Click += new System.EventHandler(this.specifiedCardSetSelectBindingNavigatorSaveItem_Click);
            // 
            // setIDLabel
            // 
            setIDLabel.AutoSize = true;
            setIDLabel.Location = new System.Drawing.Point(93, 67);
            setIDLabel.Name = "setIDLabel";
            setIDLabel.Size = new System.Drawing.Size(40, 13);
            setIDLabel.TabIndex = 2;
            setIDLabel.Text = "Set ID:";
            // 
            // setIDTextBox
            // 
            this.setIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "SetID", true));
            this.setIDTextBox.Location = new System.Drawing.Point(186, 64);
            this.setIDTextBox.Name = "setIDTextBox";
            this.setIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.setIDTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(93, 109);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(186, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // cardAmountLabel
            // 
            cardAmountLabel.AutoSize = true;
            cardAmountLabel.Location = new System.Drawing.Point(93, 153);
            cardAmountLabel.Name = "cardAmountLabel";
            cardAmountLabel.Size = new System.Drawing.Size(71, 13);
            cardAmountLabel.TabIndex = 6;
            cardAmountLabel.Text = "Card Amount:";
            // 
            // cardAmountTextBox
            // 
            this.cardAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CardAmount", true));
            this.cardAmountTextBox.Location = new System.Drawing.Point(186, 150);
            this.cardAmountTextBox.Name = "cardAmountTextBox";
            this.cardAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardAmountTextBox.TabIndex = 7;
            // 
            // collectionNameLabel
            // 
            collectionNameLabel.AutoSize = true;
            collectionNameLabel.Location = new System.Drawing.Point(93, 207);
            collectionNameLabel.Name = "collectionNameLabel";
            collectionNameLabel.Size = new System.Drawing.Size(87, 13);
            collectionNameLabel.TabIndex = 8;
            collectionNameLabel.Text = "Collection Name:";
            // 
            // collectionNameTextBox
            // 
            this.collectionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CollectionName", true));
            this.collectionNameTextBox.Location = new System.Drawing.Point(186, 204);
            this.collectionNameTextBox.Name = "collectionNameTextBox";
            this.collectionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.collectionNameTextBox.TabIndex = 9;
            // 
            // collectionIDLabel
            // 
            collectionIDLabel.AutoSize = true;
            collectionIDLabel.Location = new System.Drawing.Point(93, 263);
            collectionIDLabel.Name = "collectionIDLabel";
            collectionIDLabel.Size = new System.Drawing.Size(70, 13);
            collectionIDLabel.TabIndex = 10;
            collectionIDLabel.Text = "Collection ID:";
            // 
            // collectionIDTextBox
            // 
            this.collectionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CollectionID", true));
            this.collectionIDTextBox.Location = new System.Drawing.Point(186, 260);
            this.collectionIDTextBox.Name = "collectionIDTextBox";
            this.collectionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.collectionIDTextBox.TabIndex = 11;
            // 
            // CardSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 426);
            this.Controls.Add(setIDLabel);
            this.Controls.Add(this.setIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(cardAmountLabel);
            this.Controls.Add(this.cardAmountTextBox);
            this.Controls.Add(collectionNameLabel);
            this.Controls.Add(this.collectionNameTextBox);
            this.Controls.Add(collectionIDLabel);
            this.Controls.Add(this.collectionIDTextBox);
            this.Controls.Add(this.specifiedCardSetSelectBindingNavigator);
            this.Name = "CardSets";
            this.Text = "CardSets";
            this.Load += new System.EventHandler(this.CardSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingNavigator)).EndInit();
            this.specifiedCardSetSelectBindingNavigator.ResumeLayout(false);
            this.specifiedCardSetSelectBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewComboBoxColumn Collection;
        private CardManagerDBDataSet cardManagerDBDataSet;
        private System.Windows.Forms.BindingSource specifiedCardSetSelectBindingSource;
        private CardManagerDBDataSetTableAdapters.SpecifiedCardSetSelectTableAdapter specifiedCardSetSelectTableAdapter;
        private CardManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specifiedCardSetSelectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton specifiedCardSetSelectBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox setIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cardAmountTextBox;
        private System.Windows.Forms.TextBox collectionNameTextBox;
        private System.Windows.Forms.TextBox collectionIDTextBox;









    }
}