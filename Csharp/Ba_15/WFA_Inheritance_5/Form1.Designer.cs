
namespace WFA_Inheritance_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMobile = new System.Windows.Forms.Button();
            this.btnSmart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Base Phone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMobile
            // 
            this.btnMobile.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnMobile.Location = new System.Drawing.Point(12, 68);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(150, 50);
            this.btnMobile.TabIndex = 1;
            this.btnMobile.Text = "Mobile";
            this.btnMobile.UseVisualStyleBackColor = true;
            this.btnMobile.Click += new System.EventHandler(this.btnMobile_Click);
            // 
            // btnSmart
            // 
            this.btnSmart.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnSmart.Location = new System.Drawing.Point(12, 124);
            this.btnSmart.Name = "btnSmart";
            this.btnSmart.Size = new System.Drawing.Size(150, 50);
            this.btnSmart.TabIndex = 2;
            this.btnSmart.Text = "SmartPhone";
            this.btnSmart.UseVisualStyleBackColor = true;
            this.btnSmart.Click += new System.EventHandler(this.btnSmart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 185);
            this.Controls.Add(this.btnSmart);
            this.Controls.Add(this.btnMobile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMobile;
        private System.Windows.Forms.Button btnSmart;
    }
}

