namespace CardManager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.m_button1 = new System.Windows.Forms.Button();
            this.m_button2 = new System.Windows.Forms.Button();
            this.m_button3 = new System.Windows.Forms.Button();
            this.m_button5 = new System.Windows.Forms.Button();
            this.m_button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.collectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateViewCollectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateViewSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_button1
            // 
            this.m_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.m_button1.Location = new System.Drawing.Point(0, 474);
            this.m_button1.Name = "m_button1";
            this.m_button1.Size = new System.Drawing.Size(118, 26);
            this.m_button1.TabIndex = 2;
            this.m_button1.Text = "Add a card to your list";
            this.m_button1.UseVisualStyleBackColor = true;
            this.m_button1.Click += new System.EventHandler(this.m_button1_Click);
            // 
            // m_button2
            // 
            this.m_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.m_button2.Location = new System.Drawing.Point(235, 474);
            this.m_button2.Name = "m_button2";
            this.m_button2.Size = new System.Drawing.Size(140, 26);
            this.m_button2.TabIndex = 3;
            this.m_button2.Text = "Delete a card from your list";
            this.m_button2.UseVisualStyleBackColor = true;
            this.m_button2.Click += new System.EventHandler(this.m_button2_Click);
            // 
            // m_button3
            // 
            this.m_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.m_button3.Location = new System.Drawing.Point(381, 473);
            this.m_button3.Name = "m_button3";
            this.m_button3.Size = new System.Drawing.Size(146, 27);
            this.m_button3.TabIndex = 4;
            this.m_button3.Text = "Display the cards in your list";
            this.m_button3.UseVisualStyleBackColor = true;
            // 
            // m_button5
            // 
            this.m_button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.m_button5.Location = new System.Drawing.Point(533, 472);
            this.m_button5.Name = "m_button5";
            this.m_button5.Size = new System.Drawing.Size(108, 28);
            this.m_button5.TabIndex = 6;
            this.m_button5.Text = "Manage Collections";
            this.m_button5.UseVisualStyleBackColor = true;
            this.m_button5.Click += new System.EventHandler(this.m_button5_Click);
            // 
            // m_button6
            // 
            this.m_button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.m_button6.Location = new System.Drawing.Point(124, 474);
            this.m_button6.Name = "m_button6";
            this.m_button6.Size = new System.Drawing.Size(105, 27);
            this.m_button6.TabIndex = 7;
            this.m_button6.Text = "Manage Card Sets";
            this.m_button6.UseVisualStyleBackColor = true;
            this.m_button6.Click += new System.EventHandler(this.m_button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionsToolStripMenuItem,
            this.setsToolStripMenuItem,
            this.cardsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // collectionsToolStripMenuItem
            // 
            this.collectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewCollectionToolStripMenuItem,
            this.updateViewCollectionsToolStripMenuItem,
            this.deleteCollectionToolStripMenuItem});
            this.collectionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.collectionsToolStripMenuItem.Name = "collectionsToolStripMenuItem";
            this.collectionsToolStripMenuItem.Size = new System.Drawing.Size(94, 23);
            this.collectionsToolStripMenuItem.Text = "Collections";
            // 
            // insertNewCollectionToolStripMenuItem
            // 
            this.insertNewCollectionToolStripMenuItem.Name = "insertNewCollectionToolStripMenuItem";
            this.insertNewCollectionToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.insertNewCollectionToolStripMenuItem.Text = "Insert New Collection";
            this.insertNewCollectionToolStripMenuItem.Click += new System.EventHandler(this.insertNewCollectionToolStripMenuItem_Click);
            // 
            // updateViewCollectionsToolStripMenuItem
            // 
            this.updateViewCollectionsToolStripMenuItem.Name = "updateViewCollectionsToolStripMenuItem";
            this.updateViewCollectionsToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.updateViewCollectionsToolStripMenuItem.Text = "Update / View Collections";
            this.updateViewCollectionsToolStripMenuItem.Click += new System.EventHandler(this.updateViewCollectionsToolStripMenuItem_Click);
            // 
            // deleteCollectionToolStripMenuItem
            // 
            this.deleteCollectionToolStripMenuItem.Name = "deleteCollectionToolStripMenuItem";
            this.deleteCollectionToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.deleteCollectionToolStripMenuItem.Text = "Delete Collection";
            this.deleteCollectionToolStripMenuItem.Click += new System.EventHandler(this.deleteCollectionToolStripMenuItem_Click);
            // 
            // setsToolStripMenuItem
            // 
            this.setsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewSetToolStripMenuItem,
            this.updateViewSetsToolStripMenuItem,
            this.deleteSetToolStripMenuItem});
            this.setsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.setsToolStripMenuItem.Name = "setsToolStripMenuItem";
            this.setsToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.setsToolStripMenuItem.Text = "Sets";
            // 
            // insertNewSetToolStripMenuItem
            // 
            this.insertNewSetToolStripMenuItem.Name = "insertNewSetToolStripMenuItem";
            this.insertNewSetToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.insertNewSetToolStripMenuItem.Text = "Insert New Set";
            this.insertNewSetToolStripMenuItem.Click += new System.EventHandler(this.insertNewSetToolStripMenuItem_Click);
            // 
            // updateViewSetsToolStripMenuItem
            // 
            this.updateViewSetsToolStripMenuItem.Name = "updateViewSetsToolStripMenuItem";
            this.updateViewSetsToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.updateViewSetsToolStripMenuItem.Text = "Update / View Sets";
            // 
            // deleteSetToolStripMenuItem
            // 
            this.deleteSetToolStripMenuItem.Name = "deleteSetToolStripMenuItem";
            this.deleteSetToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.deleteSetToolStripMenuItem.Text = "Delete Set";
            this.deleteSetToolStripMenuItem.Click += new System.EventHandler(this.deleteSetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewCardToolStripMenuItem,
            this.viewUpdateCardsToolStripMenuItem,
            this.deleteCardsToolStripMenuItem});
            this.cardsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cardsToolStripMenuItem.Name = "cardsToolStripMenuItem";
            this.cardsToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.cardsToolStripMenuItem.Text = "Cards";
            // 
            // insertNewCardToolStripMenuItem
            // 
            this.insertNewCardToolStripMenuItem.Name = "insertNewCardToolStripMenuItem";
            this.insertNewCardToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.insertNewCardToolStripMenuItem.Text = "Insert New Card";
            this.insertNewCardToolStripMenuItem.Click += new System.EventHandler(this.insertNewCardToolStripMenuItem_Click);
            // 
            // viewUpdateCardsToolStripMenuItem
            // 
            this.viewUpdateCardsToolStripMenuItem.Name = "viewUpdateCardsToolStripMenuItem";
            this.viewUpdateCardsToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.viewUpdateCardsToolStripMenuItem.Text = "View Update Cards";
            // 
            // deleteCardsToolStripMenuItem
            // 
            this.deleteCardsToolStripMenuItem.Name = "deleteCardsToolStripMenuItem";
            this.deleteCardsToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.deleteCardsToolStripMenuItem.Text = "Delete Cards";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 502);
            this.Controls.Add(this.m_button6);
            this.Controls.Add(this.m_button5);
            this.Controls.Add(this.m_button3);
            this.Controls.Add(this.m_button2);
            this.Controls.Add(this.m_button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Card Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_button1;
        private System.Windows.Forms.Button m_button2;
        private System.Windows.Forms.Button m_button3;
        private System.Windows.Forms.Button m_button5;
        private System.Windows.Forms.Button m_button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem collectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateViewCollectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateViewSetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUpdateCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCardsToolStripMenuItem;
    }
}

