
namespace WFA_Global
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
            this.ADD = new System.Windows.Forms.Button();
            this.SUB = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(21, 12);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(200, 150);
            this.ADD.TabIndex = 0;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // SUB
            // 
            this.SUB.Location = new System.Drawing.Point(462, 12);
            this.SUB.Name = "SUB";
            this.SUB.Size = new System.Drawing.Size(200, 150);
            this.SUB.TabIndex = 1;
            this.SUB.Text = "SUBTRACT";
            this.SUB.UseVisualStyleBackColor = true;
            this.SUB.Click += new System.EventHandler(this.SUB_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 108F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(227, 12);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(229, 163);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 177);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.SUB);
            this.Controls.Add(this.ADD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button SUB;
        private System.Windows.Forms.Label lblCount;
    }
}

