
namespace WFA_Events
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
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.lbl_tag = new System.Windows.Forms.Label();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_box1
            // 
            this.txt_box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box1.Location = new System.Drawing.Point(12, 12);
            this.txt_box1.Multiline = true;
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(360, 208);
            this.txt_box1.TabIndex = 0;
            this.txt_box1.TextChanged += new System.EventHandler(this.txt_box1_TextChanged);
            // 
            // lbl_tag
            // 
            this.lbl_tag.AutoSize = true;
            this.lbl_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag.Location = new System.Drawing.Point(12, 232);
            this.lbl_tag.Name = "lbl_tag";
            this.lbl_tag.Size = new System.Drawing.Size(175, 20);
            this.lbl_tag.TabIndex = 1;
            this.lbl_tag.Text = "Remaining Characters :";
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.AutoSize = true;
            this.lbl_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_remaining.Location = new System.Drawing.Point(193, 232);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(36, 20);
            this.lbl_remaining.TabIndex = 2;
            this.lbl_remaining.Text = "500";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lbl_remaining);
            this.Controls.Add(this.lbl_tag);
            this.Controls.Add(this.txt_box1);
            this.Name = "Form2";
            this.Text = "MessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.Label lbl_tag;
        private System.Windows.Forms.Label lbl_remaining;
    }
}