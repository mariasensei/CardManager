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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.collectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateViewCollectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateViewSetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOneCopyInExistingCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUpdateCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.updateViewSetsToolStripMenuItem.Click += new System.EventHandler(this.updateViewSetsToolStripMenuItem_Click);
            // 
            // deleteSetToolStripMenuItem
            // 
            this.deleteSetToolStripMenuItem.Name = "deleteSetToolStripMenuItem";
            this.deleteSetToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.deleteSetToolStripMenuItem.Text = "Delete Set";
            this.deleteSetToolStripMenuItem.Click += new System.EventHandler(this.deleteSetToolStripMenuItem_Click);
            // 
            // cardsToolStripMenuItem
            // 
            this.cardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewCardToolStripMenuItem,
            this.addOneCopyInExistingCardToolStripMenuItem,
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
            this.insertNewCardToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.insertNewCardToolStripMenuItem.Text = "Insert New Card";
            this.insertNewCardToolStripMenuItem.Click += new System.EventHandler(this.insertNewCardToolStripMenuItem_Click);
            // 
            // addOneCopyInExistingCardToolStripMenuItem
            // 
            this.addOneCopyInExistingCardToolStripMenuItem.Name = "addOneCopyInExistingCardToolStripMenuItem";
            this.addOneCopyInExistingCardToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.addOneCopyInExistingCardToolStripMenuItem.Text = "Add A Copy of Existing Card";
            this.addOneCopyInExistingCardToolStripMenuItem.Click += new System.EventHandler(this.addOneCopyInExistingCardToolStripMenuItem_Click);
            // 
            // viewUpdateCardsToolStripMenuItem
            // 
            this.viewUpdateCardsToolStripMenuItem.Name = "viewUpdateCardsToolStripMenuItem";
            this.viewUpdateCardsToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.viewUpdateCardsToolStripMenuItem.Text = "View Update Cards";
            this.viewUpdateCardsToolStripMenuItem.Click += new System.EventHandler(this.viewUpdateCardsToolStripMenuItem_Click);
            // 
            // deleteCardsToolStripMenuItem
            // 
            this.deleteCardsToolStripMenuItem.Name = "deleteCardsToolStripMenuItem";
            this.deleteCardsToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.deleteCardsToolStripMenuItem.Text = "Delete Cards";
            this.deleteCardsToolStripMenuItem.Click += new System.EventHandler(this.deleteCardsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 502);
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
        private System.Windows.Forms.ToolStripMenuItem addOneCopyInExistingCardToolStripMenuItem;
    }
}

