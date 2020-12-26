
namespace WFA_GenericTypes_14
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShipperSave = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "button1";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShipperSave
            // 
            this.btnShipperSave.Location = new System.Drawing.Point(12, 167);
            this.btnShipperSave.Name = "btnShipperSave";
            this.btnShipperSave.Size = new System.Drawing.Size(180, 23);
            this.btnShipperSave.TabIndex = 1;
            this.btnShipperSave.Text = "button2";
            this.btnShipperSave.UseVisualStyleBackColor = true;
            this.btnShipperSave.Click += new System.EventHandler(this.btnShipperSave_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(13, 55);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(180, 20);
            this.Description.TabIndex = 2;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(12, 141);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(180, 20);
            this.Phone.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(199, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CategoryName
            // 
            this.CategoryName.Location = new System.Drawing.Point(13, 29);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(180, 20);
            this.CategoryName.TabIndex = 5;
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(13, 115);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(180, 20);
            this.CompanyName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 220);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.btnShipperSave);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShipperSave;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.TextBox CompanyName;
    }
}

