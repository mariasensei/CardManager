﻿namespace CardManager
{
    partial class AddCopyOfCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.collectionComboBox = new System.Windows.Forms.ComboBox();
            this.collectionDropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.setComboBox = new System.Windows.Forms.ComboBox();
            this.cardSetDropdownCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cardComboBox = new System.Windows.Forms.ComboBox();
            this.cardDropDownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.follieNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddCards = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.collectionDropdownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.cardSetDropdownCardTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter();
            this.cardDropDownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardDropDownTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.addCardCopyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addCardCopyTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.AddCardCopyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDropDownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.follieNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCardCopyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Collection";
            // 
            // collectionComboBox
            // 
            this.collectionComboBox.DataSource = this.collectionDropdownBindingSource;
            this.collectionComboBox.DisplayMember = "Name";
            this.collectionComboBox.FormattingEnabled = true;
            this.collectionComboBox.Location = new System.Drawing.Point(261, 61);
            this.collectionComboBox.Name = "collectionComboBox";
            this.collectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.collectionComboBox.TabIndex = 2;
            this.collectionComboBox.ValueMember = "Name";
            this.collectionComboBox.SelectedValueChanged += new System.EventHandler(this.RefreshSetComboBox);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set";
            // 
            // setComboBox
            // 
            this.setComboBox.DataSource = this.cardSetDropdownCardBindingSource;
            this.setComboBox.DisplayMember = "Name";
            this.setComboBox.FormattingEnabled = true;
            this.setComboBox.Location = new System.Drawing.Point(261, 125);
            this.setComboBox.Name = "setComboBox";
            this.setComboBox.Size = new System.Drawing.Size(121, 21);
            this.setComboBox.TabIndex = 4;
            this.setComboBox.ValueMember = "Name";
            this.setComboBox.SelectedValueChanged += new System.EventHandler(this.RefreshCardComboBox);
            this.setComboBox.VisibleChanged += new System.EventHandler(this.RefreshCardComboBox);
            // 
            // cardSetDropdownCardBindingSource
            // 
            this.cardSetDropdownCardBindingSource.DataMember = "CardSetDropdownCard";
            this.cardSetDropdownCardBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(53, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Card";
            // 
            // cardComboBox
            // 
            this.cardComboBox.DataSource = this.cardDropDownBindingSource;
            this.cardComboBox.DisplayMember = "Name";
            this.cardComboBox.FormattingEnabled = true;
            this.cardComboBox.Location = new System.Drawing.Point(261, 180);
            this.cardComboBox.Name = "cardComboBox";
            this.cardComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardComboBox.TabIndex = 6;
            this.cardComboBox.ValueMember = "Name";
            // 
            // cardDropDownBindingSource
            // 
            this.cardDropDownBindingSource.DataMember = "CardDropDown";
            this.cardDropDownBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // normalNumeric
            // 
            this.normalNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.normalNumeric.Location = new System.Drawing.Point(138, 282);
            this.normalNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.normalNumeric.Name = "normalNumeric";
            this.normalNumeric.Size = new System.Drawing.Size(66, 24);
            this.normalNumeric.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(22, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Normal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(278, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Follie:";
            // 
            // follieNumeric
            // 
            this.follieNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.follieNumeric.Location = new System.Drawing.Point(357, 282);
            this.follieNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.follieNumeric.Name = "follieNumeric";
            this.follieNumeric.Size = new System.Drawing.Size(66, 24);
            this.follieNumeric.TabIndex = 10;
            // 
            // AddCards
            // 
            this.AddCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddCards.Location = new System.Drawing.Point(84, 377);
            this.AddCards.Name = "AddCards";
            this.AddCards.Size = new System.Drawing.Size(95, 28);
            this.AddCards.TabIndex = 11;
            this.AddCards.Text = "Add Cards";
            this.AddCards.UseVisualStyleBackColor = true;
            this.AddCards.Click += new System.EventHandler(this.AddCards_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Cancel.Location = new System.Drawing.Point(261, 377);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 28);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(91, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "How many cards do you want to add?";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(56, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // addCardCopyBindingSource
            // 
            this.addCardCopyBindingSource.DataMember = "AddCardCopy";
            this.addCardCopyBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // addCardCopyTableAdapter
            // 
            this.addCardCopyTableAdapter.ClearBeforeFill = true;
            // 
            // AddCopyOfCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddCards);
            this.Controls.Add(this.follieNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.normalNumeric);
            this.Controls.Add(this.cardComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.collectionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCopyOfCard";
            this.Text = "AddCopyOfCard";
            this.Load += new System.EventHandler(this.AddCopyOfCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDropDownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.follieNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCardCopyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox collectionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox setComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cardComboBox;
        private System.Windows.Forms.NumericUpDown normalNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown follieNumeric;
        private System.Windows.Forms.Button AddCards;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label7;
        private CardManagerDBDataSet cardManagerDBDataSet;
        private System.Windows.Forms.BindingSource collectionDropdownBindingSource;
        private CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter collectionDropdownTableAdapter;
        private CardManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cardSetDropdownCardBindingSource;
        private CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter cardSetDropdownCardTableAdapter;
        private System.Windows.Forms.BindingSource cardDropDownBindingSource;
        private CardManagerDBDataSetTableAdapters.CardDropDownTableAdapter cardDropDownTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource addCardCopyBindingSource;
        private CardManagerDBDataSetTableAdapters.AddCardCopyTableAdapter addCardCopyTableAdapter;
    }
}