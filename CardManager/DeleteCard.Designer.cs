namespace CardManager
{
    partial class DeleteCard
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
            this.d_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.collectionComboBox = new System.Windows.Forms.ComboBox();
            this.collectionDropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.setComboBox = new System.Windows.Forms.ComboBox();
            this.cardSetDropdownCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardComboBox = new System.Windows.Forms.ComboBox();
            this.cardDropDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDropdownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.cardSetDropdownCardTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter();
            this.cardDropDownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardDropDownTableAdapter();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.cardManagerDeleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardManagerDeleteTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardManagerDeleteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDropDownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDeleteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // d_label1
            // 
            this.d_label1.AutoSize = true;
            this.d_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_label1.Location = new System.Drawing.Point(88, 38);
            this.d_label1.Name = "d_label1";
            this.d_label1.Size = new System.Drawing.Size(325, 20);
            this.d_label1.TabIndex = 0;
            this.d_label1.Text = "Select the card that you want to delete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(65, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "CardSet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(65, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Card";
            // 
            // collectionComboBox
            // 
            this.collectionComboBox.DataSource = this.collectionDropdownBindingSource;
            this.collectionComboBox.DisplayMember = "Name";
            this.collectionComboBox.FormattingEnabled = true;
            this.collectionComboBox.Location = new System.Drawing.Point(220, 91);
            this.collectionComboBox.Name = "collectionComboBox";
            this.collectionComboBox.Size = new System.Drawing.Size(173, 21);
            this.collectionComboBox.TabIndex = 4;
            this.collectionComboBox.ValueMember = "Name";
            this.collectionComboBox.SelectedValueChanged += new System.EventHandler(this.setComboBoxRefresh);
            this.collectionComboBox.VisibleChanged += new System.EventHandler(this.setComboBoxRefresh);
            // 
            // collectionDropdownBindingSource
            // 
            this.collectionDropdownBindingSource.DataMember = "CollectionDropdown";
            this.collectionDropdownBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardManagerDBDataSet
            // 
            this.cardManagerDBDataSet.DataSetName = "CardManagerDBDataSet";
            this.cardManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setComboBox
            // 
            this.setComboBox.DataSource = this.cardSetDropdownCardBindingSource;
            this.setComboBox.DisplayMember = "Name";
            this.setComboBox.FormattingEnabled = true;
            this.setComboBox.Location = new System.Drawing.Point(220, 151);
            this.setComboBox.Name = "setComboBox";
            this.setComboBox.Size = new System.Drawing.Size(173, 21);
            this.setComboBox.TabIndex = 5;
            this.setComboBox.ValueMember = "Name";
            this.setComboBox.SelectedValueChanged += new System.EventHandler(this.cardComboBoxRefresh);
            this.setComboBox.VisibleChanged += new System.EventHandler(this.cardComboBoxRefresh);
            // 
            // cardSetDropdownCardBindingSource
            // 
            this.cardSetDropdownCardBindingSource.DataMember = "CardSetDropdownCard";
            this.cardSetDropdownCardBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardComboBox
            // 
            this.cardComboBox.DataSource = this.cardDropDownBindingSource;
            this.cardComboBox.DisplayMember = "Name";
            this.cardComboBox.FormattingEnabled = true;
            this.cardComboBox.Location = new System.Drawing.Point(220, 211);
            this.cardComboBox.Name = "cardComboBox";
            this.cardComboBox.Size = new System.Drawing.Size(173, 21);
            this.cardComboBox.TabIndex = 6;
            this.cardComboBox.ValueMember = "Name";
            // 
            // cardDropDownBindingSource
            // 
            this.cardDropDownBindingSource.DataMember = "CardDropDown";
            this.cardDropDownBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // collectionDropdownTableAdapter
            // 
            this.collectionDropdownTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddCardCopyTableAdapter = null;
            this.tableAdapterManager.AddNewCollectionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardManagerDeleteTableAdapter = null;
            this.tableAdapterManager.CardManagerInsertTableAdapter = null;
            this.tableAdapterManager.CardSetManagerInsertTableAdapter = null;
            this.tableAdapterManager.CollectionManagerSelectTableAdapter = null;
            this.tableAdapterManager.CollectionManagerTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DeleteCardSetTableAdapter = null;
            this.tableAdapterManager.DeleteCollectionTableAdapter = null;
            this.tableAdapterManager.SpecifiedCardSetSelectTableAdapter = null;
            this.tableAdapterManager.UpdateCollectionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cardSetDropdownCardTableAdapter
            // 
            this.cardSetDropdownCardTableAdapter.ClearBeforeFill = true;
            // 
            // cardDropDownTableAdapter
            // 
            this.cardDropDownTableAdapter.ClearBeforeFill = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(92, 318);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 28);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete this card";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cancelButton.Location = new System.Drawing.Point(298, 318);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // cardManagerDeleteBindingSource
            // 
            this.cardManagerDeleteBindingSource.DataMember = "CardManagerDelete";
            this.cardManagerDeleteBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardManagerDeleteTableAdapter
            // 
            this.cardManagerDeleteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(89, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // DeleteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(500, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cardComboBox);
            this.Controls.Add(this.setComboBox);
            this.Controls.Add(this.collectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d_label1);
            this.Name = "DeleteCard";
            this.Text = "Delete Card ...";
            this.Load += new System.EventHandler(this.DeleteCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDropDownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDeleteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox collectionComboBox;
        private System.Windows.Forms.ComboBox setComboBox;
        private System.Windows.Forms.ComboBox cardComboBox;
        private CardManagerDBDataSet cardManagerDBDataSet;
        private System.Windows.Forms.BindingSource collectionDropdownBindingSource;
        private CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter collectionDropdownTableAdapter;
        private CardManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cardSetDropdownCardBindingSource;
        private CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter cardSetDropdownCardTableAdapter;
        private System.Windows.Forms.BindingSource cardDropDownBindingSource;
        private CardManagerDBDataSetTableAdapters.CardDropDownTableAdapter cardDropDownTableAdapter;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource cardManagerDeleteBindingSource;
        private CardManagerDBDataSetTableAdapters.CardManagerDeleteTableAdapter cardManagerDeleteTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}