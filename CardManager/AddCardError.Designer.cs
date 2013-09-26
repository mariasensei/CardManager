namespace CardManager
{
    partial class AddCardError
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
            this.e_label1 = new System.Windows.Forms.Label();
            this.e2_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // e_label1
            // 
            this.e_label1.AutoSize = true;
            this.e_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.e_label1.Location = new System.Drawing.Point(13, 13);
            this.e_label1.Name = "e_label1";
            this.e_label1.Size = new System.Drawing.Size(0, 16);
            this.e_label1.TabIndex = 0;
            // 
            // e2_button1
            // 
            this.e2_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.e2_button1.Location = new System.Drawing.Point(146, 59);
            this.e2_button1.Name = "e2_button1";
            this.e2_button1.Size = new System.Drawing.Size(75, 28);
            this.e2_button1.TabIndex = 1;
            this.e2_button1.Text = "OK";
            this.e2_button1.UseVisualStyleBackColor = true;
            this.e2_button1.Click += new System.EventHandler(this.e_button1_Click);
            // 
            // AddCardError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 99);
            this.Controls.Add(this.e2_button1);
            this.Controls.Add(this.e_label1);
            this.Name = "AddCardError";
            this.Text = "Error!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label e_label1;
        private System.Windows.Forms.Button e2_button1;
    }
}