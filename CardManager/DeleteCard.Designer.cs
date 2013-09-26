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
            this.d_label1 = new System.Windows.Forms.Label();
            this.d_label2 = new System.Windows.Forms.Label();
            this.d_label3 = new System.Windows.Forms.Label();
            this.d_comboBox1 = new System.Windows.Forms.ComboBox();
            this.d_textBox1 = new System.Windows.Forms.TextBox();
            this.d_textBox2 = new System.Windows.Forms.TextBox();
            this.d_label4 = new System.Windows.Forms.Label();
            this.d_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d_label1
            // 
            this.d_label1.AutoSize = true;
            this.d_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_label1.Location = new System.Drawing.Point(41, 39);
            this.d_label1.Name = "d_label1";
            this.d_label1.Size = new System.Drawing.Size(420, 20);
            this.d_label1.TabIndex = 0;
            this.d_label1.Text = "PLease add in the details of the card to be deleted:";
            // 
            // d_label2
            // 
            this.d_label2.AutoSize = true;
            this.d_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_label2.Location = new System.Drawing.Point(130, 101);
            this.d_label2.Name = "d_label2";
            this.d_label2.Size = new System.Drawing.Size(67, 17);
            this.d_label2.TabIndex = 1;
            this.d_label2.Text = "*Number:";
            // 
            // d_label3
            // 
            this.d_label3.AutoSize = true;
            this.d_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_label3.Location = new System.Drawing.Point(130, 160);
            this.d_label3.Name = "d_label3";
            this.d_label3.Size = new System.Drawing.Size(54, 17);
            this.d_label3.TabIndex = 2;
            this.d_label3.Text = "*Name:";
            // 
            // d_comboBox1
            // 
            this.d_comboBox1.FormattingEnabled = true;
            this.d_comboBox1.Location = new System.Drawing.Point(256, 231);
            this.d_comboBox1.Name = "d_comboBox1";
            this.d_comboBox1.Size = new System.Drawing.Size(127, 21);
            this.d_comboBox1.TabIndex = 3;
            // 
            // d_textBox1
            // 
            this.d_textBox1.Location = new System.Drawing.Point(256, 98);
            this.d_textBox1.Name = "d_textBox1";
            this.d_textBox1.Size = new System.Drawing.Size(127, 20);
            this.d_textBox1.TabIndex = 4;
            // 
            // d_textBox2
            // 
            this.d_textBox2.Location = new System.Drawing.Point(256, 157);
            this.d_textBox2.Name = "d_textBox2";
            this.d_textBox2.Size = new System.Drawing.Size(127, 20);
            this.d_textBox2.TabIndex = 5;
            // 
            // d_label4
            // 
            this.d_label4.AutoSize = true;
            this.d_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_label4.Location = new System.Drawing.Point(130, 238);
            this.d_label4.Name = "d_label4";
            this.d_label4.Size = new System.Drawing.Size(51, 17);
            this.d_label4.TabIndex = 6;
            this.d_label4.Text = "*Block:";
            // 
            // d_button1
            // 
            this.d_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.d_button1.Location = new System.Drawing.Point(189, 336);
            this.d_button1.Name = "d_button1";
            this.d_button1.Size = new System.Drawing.Size(216, 26);
            this.d_button1.TabIndex = 7;
            this.d_button1.Text = "Proceed with the card deletion";
            this.d_button1.UseVisualStyleBackColor = true;
            this.d_button1.Click += new System.EventHandler(this.d_button1_Click);
            // 
            // DeleteCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(639, 502);
            this.Controls.Add(this.d_button1);
            this.Controls.Add(this.d_label4);
            this.Controls.Add(this.d_textBox2);
            this.Controls.Add(this.d_textBox1);
            this.Controls.Add(this.d_comboBox1);
            this.Controls.Add(this.d_label3);
            this.Controls.Add(this.d_label2);
            this.Controls.Add(this.d_label1);
            this.Name = "DeleteCard";
            this.Text = "Delete Card ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label d_label1;
        private System.Windows.Forms.Label d_label2;
        private System.Windows.Forms.Label d_label3;
        private System.Windows.Forms.ComboBox d_comboBox1;
        private System.Windows.Forms.TextBox d_textBox1;
        private System.Windows.Forms.TextBox d_textBox2;
        private System.Windows.Forms.Label d_label4;
        private System.Windows.Forms.Button d_button1;
    }
}