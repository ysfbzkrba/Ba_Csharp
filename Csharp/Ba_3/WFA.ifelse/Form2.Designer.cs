
namespace WFA.ifelse
{
    partial class Form2
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
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 567);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(260, 52);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "Password";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 509);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(260, 52);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "Aisle";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 451);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(260, 52);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Enter Score";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 393);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(260, 52);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Login";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 341);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(260, 20);
            this.txt1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA.ifelse.Properties.Resources.cartman;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(12, 367);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(260, 20);
            this.txt2.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 626);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt2;
    }
}