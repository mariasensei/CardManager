namespace CardManager
{
    partial class AddNewCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCard));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.collectionDropdownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardManagerDBDataSet = new CardManager.CardManagerDBDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cardSetDropdownCardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectionDropdownTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter();
            this.tableAdapterManager = new CardManager.CardManagerDBDataSetTableAdapters.TableAdapterManager();
            this.cardSetDropdownCardTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cardDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rarityComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.normalAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.follieAmountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.collectorNumeric = new System.Windows.Forms.NumericUpDown();
            this.totalSetLabel = new System.Windows.Forms.Label();
            this.subtypeTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.color2ComboBox = new System.Windows.Forms.ComboBox();
            this.color3ComboBox = new System.Windows.Forms.ComboBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.cardSetTotalAmountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardSetTotalAmountTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardSetTotalAmountTableAdapter();
            this.cardManagerInsertBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardManagerInsertTableAdapter = new CardManager.CardManagerDBDataSetTableAdapters.CardManagerInsertTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalAmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.follieAmountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetTotalAmountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerInsertBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBox1.DataSource = this.collectionDropdownBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Name";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.RefreshCombobox2);
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
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBox2.DataSource = this.cardSetDropdownCardBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(256, 109);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 26);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Name";
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.RefreshTotalSetLabel);
            // 
            // cardSetDropdownCardBindingSource
            // 
            this.cardSetDropdownCardBindingSource.DataMember = "CardSetDropdownCard";
            this.cardSetDropdownCardBindingSource.DataSource = this.cardManagerDBDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "*Collection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Card Set:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "*Name:";
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.cardNameTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cardNameTextBox.Location = new System.Drawing.Point(256, 165);
            this.cardNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(252, 24);
            this.cardNameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 441);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // cardDescription
            // 
            this.cardDescription.BackColor = System.Drawing.SystemColors.InfoText;
            this.cardDescription.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cardDescription.Location = new System.Drawing.Point(24, 465);
            this.cardDescription.Margin = new System.Windows.Forms.Padding(4);
            this.cardDescription.Multiline = true;
            this.cardDescription.Name = "cardDescription";
            this.cardDescription.Size = new System.Drawing.Size(484, 82);
            this.cardDescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(24, 367);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "*Language:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(24, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "*Rarity:";
            // 
            // rarityComboBox
            // 
            this.rarityComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.rarityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rarityComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rarityComboBox.FormattingEnabled = true;
            this.rarityComboBox.Items.AddRange(new object[] {
            "Mythic Rare",
            "Rare",
            "Common",
            "Uncommon"});
            this.rarityComboBox.Location = new System.Drawing.Point(256, 270);
            this.rarityComboBox.Name = "rarityComboBox";
            this.rarityComboBox.Size = new System.Drawing.Size(252, 26);
            this.rarityComboBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(24, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "*Color:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "White",
            "Gold",
            "Artifact",
            "Land"});
            this.colorComboBox.Location = new System.Drawing.Point(256, 317);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(80, 26);
            this.colorComboBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "*Card Type:";
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.cardTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cardTypeComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Items.AddRange(new object[] {
            "Artifact",
            "Creature",
            "Enchantment",
            "Instant",
            "Land",
            "Legendary",
            "Plainswalker",
            "Sorcery"});
            this.cardTypeComboBox.Location = new System.Drawing.Point(256, 217);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(141, 26);
            this.cardTypeComboBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(24, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "*Collector Number:";
            // 
            // normalAmountNumeric
            // 
            this.normalAmountNumeric.BackColor = System.Drawing.SystemColors.InfoText;
            this.normalAmountNumeric.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.normalAmountNumeric.Location = new System.Drawing.Point(183, 558);
            this.normalAmountNumeric.Name = "normalAmountNumeric";
            this.normalAmountNumeric.Size = new System.Drawing.Size(56, 24);
            this.normalAmountNumeric.TabIndex = 18;
            // 
            // follieAmountNumeric
            // 
            this.follieAmountNumeric.BackColor = System.Drawing.SystemColors.InfoText;
            this.follieAmountNumeric.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.follieAmountNumeric.Location = new System.Drawing.Point(394, 558);
            this.follieAmountNumeric.Name = "follieAmountNumeric";
            this.follieAmountNumeric.Size = new System.Drawing.Size(61, 24);
            this.follieAmountNumeric.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(59, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Normal Amount:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(273, 560);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Follie Amount:";
            // 
            // collectorNumeric
            // 
            this.collectorNumeric.BackColor = System.Drawing.SystemColors.InfoText;
            this.collectorNumeric.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.collectorNumeric.Location = new System.Drawing.Point(256, 409);
            this.collectorNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.collectorNumeric.Name = "collectorNumeric";
            this.collectorNumeric.Size = new System.Drawing.Size(51, 24);
            this.collectorNumeric.TabIndex = 22;
            // 
            // totalSetLabel
            // 
            this.totalSetLabel.AutoSize = true;
            this.totalSetLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalSetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSetLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalSetLabel.Location = new System.Drawing.Point(313, 411);
            this.totalSetLabel.Name = "totalSetLabel";
            this.totalSetLabel.Size = new System.Drawing.Size(56, 20);
            this.totalSetLabel.TabIndex = 23;
            this.totalSetLabel.Text = "label12";
            // 
            // subtypeTextbox
            // 
            this.subtypeTextbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.subtypeTextbox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.subtypeTextbox.Location = new System.Drawing.Point(410, 217);
            this.subtypeTextbox.Name = "subtypeTextbox";
            this.subtypeTextbox.Size = new System.Drawing.Size(98, 24);
            this.subtypeTextbox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(115, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "Give below the details of the new card:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add Card";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // languageComboBox
            // 
            this.languageComboBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageComboBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "German"});
            this.languageComboBox.Location = new System.Drawing.Point(256, 361);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(252, 26);
            this.languageComboBox.TabIndex = 28;
            // 
            // color2ComboBox
            // 
            this.color2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color2ComboBox.FormattingEnabled = true;
            this.color2ComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "White",
            "Gold",
            "Artifact",
            "Land"});
            this.color2ComboBox.Location = new System.Drawing.Point(342, 317);
            this.color2ComboBox.Name = "color2ComboBox";
            this.color2ComboBox.Size = new System.Drawing.Size(80, 26);
            this.color2ComboBox.TabIndex = 29;
            // 
            // color3ComboBox
            // 
            this.color3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color3ComboBox.FormattingEnabled = true;
            this.color3ComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red",
            "White",
            "Gold",
            "Artifact",
            "Land"});
            this.color3ComboBox.Location = new System.Drawing.Point(428, 317);
            this.color3ComboBox.Name = "color3ComboBox";
            this.color3ComboBox.Size = new System.Drawing.Size(80, 26);
            this.color3ComboBox.TabIndex = 30;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgLabel.ForeColor = System.Drawing.Color.Red;
            this.msgLabel.Location = new System.Drawing.Point(92, 596);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(56, 20);
            this.msgLabel.TabIndex = 31;
            this.msgLabel.Text = "label12";
            this.msgLabel.Visible = false;
            // 
            // cardSetTotalAmountBindingSource
            // 
            this.cardSetTotalAmountBindingSource.DataMember = "CardSetTotalAmount";
            this.cardSetTotalAmountBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardSetTotalAmountTableAdapter
            // 
            this.cardSetTotalAmountTableAdapter.ClearBeforeFill = true;
            // 
            // cardManagerInsertBindingSource
            // 
            this.cardManagerInsertBindingSource.DataMember = "CardManagerInsert";
            this.cardManagerInsertBindingSource.DataSource = this.cardManagerDBDataSet;
            // 
            // cardManagerInsertTableAdapter
            // 
            this.cardManagerInsertTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(36, 662);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Fields with asterisk (*) are required.";
            // 
            // AddNewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 687);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.color3ComboBox);
            this.Controls.Add(this.color2ComboBox);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.subtypeTextbox);
            this.Controls.Add(this.totalSetLabel);
            this.Controls.Add(this.collectorNumeric);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.follieAmountNumeric);
            this.Controls.Add(this.normalAmountNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rarityComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cardDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cardNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewCard";
            this.Text = "AddNewCard";
            this.Load += new System.EventHandler(this.AddNewCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectionDropdownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetDropdownCardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalAmountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.follieAmountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetTotalAmountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardManagerInsertBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private CardManagerDBDataSet cardManagerDBDataSet;
        private System.Windows.Forms.BindingSource collectionDropdownBindingSource;
        private CardManagerDBDataSetTableAdapters.CollectionDropdownTableAdapter collectionDropdownTableAdapter;
        private CardManagerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cardSetDropdownCardBindingSource;
        private CardManagerDBDataSetTableAdapters.CardSetDropdownCardTableAdapter cardSetDropdownCardTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rarityComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown normalAmountNumeric;
        private System.Windows.Forms.NumericUpDown follieAmountNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown collectorNumeric;
        private System.Windows.Forms.Label totalSetLabel;
        private System.Windows.Forms.TextBox subtypeTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.ComboBox color2ComboBox;
        private System.Windows.Forms.ComboBox color3ComboBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.BindingSource cardSetTotalAmountBindingSource;
        private CardManagerDBDataSetTableAdapters.CardSetTotalAmountTableAdapter cardSetTotalAmountTableAdapter;
        private System.Windows.Forms.BindingSource cardManagerInsertBindingSource;
        private CardManagerDBDataSetTableAdapters.CardManagerInsertTableAdapter cardManagerInsertTableAdapter;
        private System.Windows.Forms.Label label12;
    }
}