
namespace WFA_TernaryIF
{
    partial class Form1
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
            this.tBox = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(12, 12);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(222, 20);
            this.tBox.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(221, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1st Button";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(13, 68);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(221, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2nd Button";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 111);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

