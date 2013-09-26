namespace CardManager
{
    partial class SpecifiedCardSet
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
            System.Windows.Forms.Label setIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label cardAmountLabel;
            System.Windows.Forms.Label collectionNameLabel;
            System.Windows.Forms.Label collectionIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecifiedCardSet));
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.specifiedCardSetSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specifiedCardSetSelectTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.SpecifiedCardSetSelectTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.specifiedCardSetSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.specifiedCardSetSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.setIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cardAmountTextBox = new System.Windows.Forms.TextBox();
            this.collectionNameTextBox = new System.Windows.Forms.TextBox();
            this.collectionIDTextBox = new System.Windows.Forms.TextBox();
            this.cardsBySetsSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsBySetsSelectTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardsBySetsSelectTableAdapter();
            this.cardsBySetsSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            setIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            cardAmountLabel = new System.Windows.Forms.Label();
            collectionNameLabel = new System.Windows.Forms.Label();
            collectionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingNavigator)).BeginInit();
            this.specifiedCardSetSelectBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBySetsSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBySetsSelectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // setIDLabel
            // 
            setIDLabel.AutoSize = true;
            setIDLabel.Location = new System.Drawing.Point(33, 39);
            setIDLabel.Name = "setIDLabel";
            setIDLabel.Size = new System.Drawing.Size(40, 13);
            setIDLabel.TabIndex = 2;
            setIDLabel.Text = "Set ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(33, 65);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // cardAmountLabel
            // 
            cardAmountLabel.AutoSize = true;
            cardAmountLabel.Location = new System.Drawing.Point(277, 36);
            cardAmountLabel.Name = "cardAmountLabel";
            cardAmountLabel.Size = new System.Drawing.Size(71, 13);
            cardAmountLabel.TabIndex = 6;
            cardAmountLabel.Text = "Card Amount:";
            // 
            // collectionNameLabel
            // 
            collectionNameLabel.AutoSize = true;
            collectionNameLabel.Location = new System.Drawing.Point(277, 62);
            collectionNameLabel.Name = "collectionNameLabel";
            collectionNameLabel.Size = new System.Drawing.Size(87, 13);
            collectionNameLabel.TabIndex = 8;
            collectionNameLabel.Text = "Collection Name:";
            // 
            // collectionIDLabel
            // 
            collectionIDLabel.AutoSize = true;
            collectionIDLabel.Location = new System.Drawing.Point(277, 88);
            collectionIDLabel.Name = "collectionIDLabel";
            collectionIDLabel.Size = new System.Drawing.Size(70, 13);
            collectionIDLabel.TabIndex = 10;
            collectionIDLabel.Text = "Collection ID:";
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
            this.specifiedCardSetSelectBindingNavigator.Size = new System.Drawing.Size(556, 25);
            this.specifiedCardSetSelectBindingNavigator.TabIndex = 0;
            this.specifiedCardSetSelectBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // specifiedCardSetSelectBindingNavigatorSaveItem
            // 
            this.specifiedCardSetSelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specifiedCardSetSelectBindingNavigatorSaveItem.Image")));
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Name = "specifiedCardSetSelectBindingNavigatorSaveItem";
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Text = "Save Data";
            this.specifiedCardSetSelectBindingNavigatorSaveItem.Click += new System.EventHandler(this.specifiedCardSetSelectBindingNavigatorSaveItem_Click_1);
            // 
            // setIDTextBox
            // 
            this.setIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "SetID", true));
            this.setIDTextBox.Location = new System.Drawing.Point(126, 36);
            this.setIDTextBox.Name = "setIDTextBox";
            this.setIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.setIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(126, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // cardAmountTextBox
            // 
            this.cardAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CardAmount", true));
            this.cardAmountTextBox.Location = new System.Drawing.Point(370, 33);
            this.cardAmountTextBox.Name = "cardAmountTextBox";
            this.cardAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardAmountTextBox.TabIndex = 7;
            // 
            // collectionNameTextBox
            // 
            this.collectionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CollectionName", true));
            this.collectionNameTextBox.Location = new System.Drawing.Point(370, 59);
            this.collectionNameTextBox.Name = "collectionNameTextBox";
            this.collectionNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.collectionNameTextBox.TabIndex = 9;
            // 
            // collectionIDTextBox
            // 
            this.collectionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specifiedCardSetSelectBindingSource, "CollectionID", true));
            this.collectionIDTextBox.Location = new System.Drawing.Point(370, 85);
            this.collectionIDTextBox.Name = "collectionIDTextBox";
            this.collectionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.collectionIDTextBox.TabIndex = 11;
            // 
            // cardsBySetsSelectBindingSource
            // 
            this.cardsBySetsSelectBindingSource.DataMember = "CardsBySetsSelect";
            this.cardsBySetsSelectBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardsBySetsSelectTableAdapter
            // 
            this.cardsBySetsSelectTableAdapter.ClearBeforeFill = true;
            // 
            // cardsBySetsSelectDataGridView
            // 
            this.cardsBySetsSelectDataGridView.AutoGenerateColumns = false;
            this.cardsBySetsSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardsBySetsSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cardsBySetsSelectDataGridView.DataSource = this.cardsBySetsSelectBindingSource;
            this.cardsBySetsSelectDataGridView.Location = new System.Drawing.Point(12, 182);
            this.cardsBySetsSelectDataGridView.Name = "cardsBySetsSelectDataGridView";
            this.cardsBySetsSelectDataGridView.Size = new System.Drawing.Size(532, 297);
            this.cardsBySetsSelectDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CardID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CardID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lang";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lang";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rarity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rarity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SetName";
            this.dataGridViewTextBoxColumn7.HeaderText = "SetName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descr";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descr";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "New Card Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete Card Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SpecifiedCardSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardsBySetsSelectDataGridView);
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
            this.Name = "SpecifiedCardSet";
            this.Text = "SpecifiedCardSet";
            this.Load += new System.EventHandler(this.SpecifiedCardSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedCardSetSelectBindingNavigator)).EndInit();
            this.specifiedCardSetSelectBindingNavigator.ResumeLayout(false);
            this.specifiedCardSetSelectBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBySetsSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsBySetsSelectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.BindingSource cardsBySetsSelectBindingSource;
        private CardManagerDBDataSetTableAdapters.CardsBySetsSelectTableAdapter cardsBySetsSelectTableAdapter;
        private System.Windows.Forms.DataGridView cardsBySetsSelectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;





    }
}