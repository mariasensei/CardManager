namespace CardManager
{
    partial class DeleteCollection
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.deleteCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteCollectionTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.DeleteCollectionTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.collectionDropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDropdownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Collection that you want to delete:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(66, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete Collection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.Location = new System.Drawing.Point(206, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cardManagerDBDataSet
            // 
            this.cardManagerDBDataSet.DataSetName = "CardManagerDBDataSet";
            this.cardManagerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteCollectionBindingSource
            // 
            this.deleteCollectionBindingSource.DataMember = "DeleteCollection";
            this.deleteCollectionBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // deleteCollectionTableAdapter
            // 
            this.deleteCollectionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddNewCollectionTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardManagerInsertTableAdapter = null;
            this.tableAdapterManager.CardSetManagerInsertTableAdapter = null;
            this.tableAdapterManager.CollectionManagerSelectTableAdapter = null;
            this.tableAdapterManager.CollectionManagerTableAdapter = null;
            this.tableAdapterManager.DeleteCardSetTableAdapter = null;
            this.tableAdapterManager.DeleteCollectionTableAdapter = this.deleteCollectionTableAdapter;
            this.tableAdapterManager.SpecifiedCardSetSelectTableAdapter = null;
            this.tableAdapterManager.UpdateCollectionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.collectionDropdownBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "Name";
            // 
            // collectionDropdownBindingSource
            // 
            this.collectionDropdownBindingSource.DataMember = "CollectionDropdown";
            this.collectionDropdownBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // collectionDropdownTableAdapter
            // 
            this.collectionDropdownTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 539);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCollection";
            this.Text = "DeleteCollection";
            this.Load += new System.EventHandler(this.DeleteCollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CardManagerDBDataSet cardManagerDBDataSet;
        private System.Windows.Forms.BindingSource deleteCollectionBindingSource;
        private CardManagerDBDataSetTableAdapters.DeleteCollectionTableAdapter deleteCollectionTableAdapter;
        private CardManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource collectionDropdownBindingSource;
        private CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter collectionDropdownTableAdapter;
    }
}