
namespace WFA_Arrays
{
    partial class Arrays
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lBx1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 69);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Sample1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 125);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 50);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Sample1";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 181);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 50);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Add";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lBx1
            // 
            this.lBx1.FormattingEnabled = true;
            this.lBx1.ItemHeight = 16;
            this.lBx1.Location = new System.Drawing.Point(219, 24);
            this.lBx1.Name = "lBx1";
            this.lBx1.Size = new System.Drawing.Size(120, 212);
            this.lBx1.TabIndex = 4;
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 251);
            this.Controls.Add(this.lBx1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Arrays";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lBx1;
    }
}

