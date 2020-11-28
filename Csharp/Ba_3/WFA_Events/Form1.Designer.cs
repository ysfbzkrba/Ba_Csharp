
namespace WFA_Events
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
            this.txt_namespace = new System.Windows.Forms.TextBox();
            this.lbl_writespace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_namespace
            // 
            this.txt_namespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namespace.Location = new System.Drawing.Point(12, 12);
            this.txt_namespace.Name = "txt_namespace";
            this.txt_namespace.Size = new System.Drawing.Size(460, 26);
            this.txt_namespace.TabIndex = 0;
            this.txt_namespace.TextChanged += new System.EventHandler(this.txt_namespace_TextChanged);
            // 
            // lbl_writespace
            // 
            this.lbl_writespace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_writespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_writespace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_writespace.Location = new System.Drawing.Point(12, 41);
            this.lbl_writespace.Name = "lbl_writespace";
            this.lbl_writespace.Size = new System.Drawing.Size(460, 411);
            this.lbl_writespace.TabIndex = 1;
            this.lbl_writespace.Text = "Write Something..";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lbl_writespace);
            this.Controls.Add(this.txt_namespace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_namespace;
        private System.Windows.Forms.Label lbl_writespace;
    }
}

