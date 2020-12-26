
namespace WFA_ReferenceandValueType_10
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
            this.btnRef = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(5, 12);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(220, 85);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "Reference";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(4, 103);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(221, 75);
            this.btnValue.TabIndex = 1;
            this.btnValue.Text = "btnValue";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(4, 184);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(221, 75);
            this.btnExample.TabIndex = 2;
            this.btnExample.Text = "Example";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 309);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnRef);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnExample;
    }
}

