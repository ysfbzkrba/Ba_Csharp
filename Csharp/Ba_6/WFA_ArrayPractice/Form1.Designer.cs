
namespace WFA_ArrayPractice
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.lstElemanlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(13, 14);
            this.btnOrnek1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(304, 35);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Örnek 1";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(13, 59);
            this.txtB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(304, 26);
            this.txtB1.TabIndex = 1;
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(13, 95);
            this.btnOrnek2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(304, 35);
            this.btnOrnek2.TabIndex = 2;
            this.btnOrnek2.Text = "Örnek 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // lstElemanlar
            // 
            this.lstElemanlar.FormattingEnabled = true;
            this.lstElemanlar.ItemHeight = 20;
            this.lstElemanlar.Location = new System.Drawing.Point(13, 140);
            this.lstElemanlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstElemanlar.Name = "lstElemanlar";
            this.lstElemanlar.Size = new System.Drawing.Size(304, 264);
            this.lstElemanlar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 419);
            this.Controls.Add(this.lstElemanlar);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.btnOrnek1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.ListBox lstElemanlar;
    }
}