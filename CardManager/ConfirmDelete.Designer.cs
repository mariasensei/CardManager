namespace CardManager
{
    partial class ConfirmDelete
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
            this.dc_label1 = new System.Windows.Forms.Label();
            this.dc_label2 = new System.Windows.Forms.Label();
            this.dc_label3 = new System.Windows.Forms.Label();
            this.dc_label4 = new System.Windows.Forms.Label();
            this.dc_label6 = new System.Windows.Forms.Label();
            this.dc_label7 = new System.Windows.Forms.Label();
            this.dc_label8 = new System.Windows.Forms.Label();
            this.dc_label5 = new System.Windows.Forms.Label();
            this.dc_label9 = new System.Windows.Forms.Label();
            this.dc_label10 = new System.Windows.Forms.Label();
            this.dc_button1 = new System.Windows.Forms.Button();
            this.dc_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dc_label1
            // 
            this.dc_label1.AutoSize = true;
            this.dc_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dc_label1.Location = new System.Drawing.Point(13, 13);
            this.dc_label1.Name = "dc_label1";
            this.dc_label1.Size = new System.Drawing.Size(288, 17);
            this.dc_label1.TabIndex = 0;
            this.dc_label1.Text = "A card with the following details found:";
            // 
            // dc_label2
            // 
            this.dc_label2.AutoSize = true;
            this.dc_label2.Location = new System.Drawing.Point(16, 53);
            this.dc_label2.Name = "dc_label2";
            this.dc_label2.Size = new System.Drawing.Size(47, 13);
            this.dc_label2.TabIndex = 1;
            this.dc_label2.Text = "Number:";
            // 
            // dc_label3
            // 
            this.dc_label3.AutoSize = true;
            this.dc_label3.Location = new System.Drawing.Point(16, 89);
            this.dc_label3.Name = "dc_label3";
            this.dc_label3.Size = new System.Drawing.Size(38, 13);
            this.dc_label3.TabIndex = 2;
            this.dc_label3.Text = "Name:";
            // 
            // dc_label4
            // 
            this.dc_label4.AutoSize = true;
            this.dc_label4.Location = new System.Drawing.Point(16, 126);
            this.dc_label4.Name = "dc_label4";
            this.dc_label4.Size = new System.Drawing.Size(37, 13);
            this.dc_label4.TabIndex = 3;
            this.dc_label4.Text = "Block:";
            // 
            // dc_label6
            // 
            this.dc_label6.AutoSize = true;
            this.dc_label6.Location = new System.Drawing.Point(82, 53);
            this.dc_label6.Name = "dc_label6";
            this.dc_label6.Size = new System.Drawing.Size(0, 13);
            this.dc_label6.TabIndex = 4;
            // 
            // dc_label7
            // 
            this.dc_label7.AutoSize = true;
            this.dc_label7.Location = new System.Drawing.Point(82, 89);
            this.dc_label7.Name = "dc_label7";
            this.dc_label7.Size = new System.Drawing.Size(0, 13);
            this.dc_label7.TabIndex = 5;
            // 
            // dc_label8
            // 
            this.dc_label8.AutoSize = true;
            this.dc_label8.Location = new System.Drawing.Point(82, 126);
            this.dc_label8.Name = "dc_label8";
            this.dc_label8.Size = new System.Drawing.Size(0, 13);
            this.dc_label8.TabIndex = 6;
            // 
            // dc_label5
            // 
            this.dc_label5.AutoSize = true;
            this.dc_label5.Location = new System.Drawing.Point(16, 161);
            this.dc_label5.Name = "dc_label5";
            this.dc_label5.Size = new System.Drawing.Size(63, 13);
            this.dc_label5.TabIndex = 7;
            this.dc_label5.Text = "Description:";
            // 
            // dc_label9
            // 
            this.dc_label9.AutoSize = true;
            this.dc_label9.Location = new System.Drawing.Point(105, 161);
            this.dc_label9.Name = "dc_label9";
            this.dc_label9.Size = new System.Drawing.Size(0, 13);
            this.dc_label9.TabIndex = 8;
            // 
            // dc_label10
            // 
            this.dc_label10.AutoSize = true;
            this.dc_label10.Location = new System.Drawing.Point(82, 189);
            this.dc_label10.Name = "dc_label10";
            this.dc_label10.Size = new System.Drawing.Size(160, 13);
            this.dc_label10.TabIndex = 9;
            this.dc_label10.Text = "Do you want to delete this card?";
            // 
            // dc_button1
            // 
            this.dc_button1.Location = new System.Drawing.Point(63, 221);
            this.dc_button1.Name = "dc_button1";
            this.dc_button1.Size = new System.Drawing.Size(75, 23);
            this.dc_button1.TabIndex = 10;
            this.dc_button1.Text = "OK";
            this.dc_button1.UseVisualStyleBackColor = true;
            this.dc_button1.Click += new System.EventHandler(this.dc_button1_Click);
            // 
            // dc_button2
            // 
            this.dc_button2.Location = new System.Drawing.Point(176, 221);
            this.dc_button2.Name = "dc_button2";
            this.dc_button2.Size = new System.Drawing.Size(75, 23);
            this.dc_button2.TabIndex = 11;
            this.dc_button2.Text = "Cancel";
            this.dc_button2.UseVisualStyleBackColor = true;
            this.dc_button2.Click += new System.EventHandler(this.dc_button2_Click);
            // 
            // ConfirmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 266);
            this.Controls.Add(this.dc_button2);
            this.Controls.Add(this.dc_button1);
            this.Controls.Add(this.dc_label10);
            this.Controls.Add(this.dc_label9);
            this.Controls.Add(this.dc_label5);
            this.Controls.Add(this.dc_label8);
            this.Controls.Add(this.dc_label7);
            this.Controls.Add(this.dc_label6);
            this.Controls.Add(this.dc_label4);
            this.Controls.Add(this.dc_label3);
            this.Controls.Add(this.dc_label2);
            this.Controls.Add(this.dc_label1);
            this.Name = "ConfirmDelete";
            this.Text = "ConfirmDelete";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dc_label1;
        private System.Windows.Forms.Label dc_label2;
        private System.Windows.Forms.Label dc_label3;
        private System.Windows.Forms.Label dc_label4;
        private System.Windows.Forms.Label dc_label6;
        private System.Windows.Forms.Label dc_label7;
        private System.Windows.Forms.Label dc_label8;
        private System.Windows.Forms.Label dc_label5;
        private System.Windows.Forms.Label dc_label9;
        private System.Windows.Forms.Label dc_label10;
        private System.Windows.Forms.Button dc_button1;
        private System.Windows.Forms.Button dc_button2;
    }
}