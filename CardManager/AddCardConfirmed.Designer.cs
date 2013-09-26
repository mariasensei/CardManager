namespace CardManager
{
    partial class AddCardConfirmed
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
            this.cc_button1 = new System.Windows.Forms.Button();
            this.cc_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cc_button1
            // 
            this.cc_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cc_button1.Location = new System.Drawing.Point(87, 52);
            this.cc_button1.Name = "cc_button1";
            this.cc_button1.Size = new System.Drawing.Size(75, 26);
            this.cc_button1.TabIndex = 0;
            this.cc_button1.Text = "OK";
            this.cc_button1.UseVisualStyleBackColor = true;
            this.cc_button1.Click += new System.EventHandler(this.cc_button1_Click);
            // 
            // cc_label1
            // 
            this.cc_label1.AutoSize = true;
            this.cc_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cc_label1.Location = new System.Drawing.Point(53, 18);
            this.cc_label1.Name = "cc_label1";
            this.cc_label1.Size = new System.Drawing.Size(144, 17);
            this.cc_label1.TabIndex = 1;
            this.cc_label1.Text = "The card is added!";
            // 
            // AddCardConfirmed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 99);
            this.Controls.Add(this.cc_label1);
            this.Controls.Add(this.cc_button1);
            this.Name = "AddCardConfirmed";
            this.Text = "Card Added!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cc_button1;
        private System.Windows.Forms.Label cc_label1;
    }
}