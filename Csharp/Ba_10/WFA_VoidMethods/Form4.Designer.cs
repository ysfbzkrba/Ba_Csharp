
namespace WFA_VoidMethods
{
    partial class Form4
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
            this.cmbSunucuAdlari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lstMailler = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSunucuAdlari
            // 
            this.cmbSunucuAdlari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSunucuAdlari.FormattingEnabled = true;
            this.cmbSunucuAdlari.Items.AddRange(new object[] {
            "hotmail.com",
            "hotmail.net",
            "hotmail.com.tr",
            "gmail.com",
            "outlook.com",
            "outlook.com.tr"});
            this.cmbSunucuAdlari.Location = new System.Drawing.Point(13, 14);
            this.cmbSunucuAdlari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSunucuAdlari.Name = "cmbSunucuAdlari";
            this.cmbSunucuAdlari.Size = new System.Drawing.Size(308, 28);
            this.cmbSunucuAdlari.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız : ";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(104, 50);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(217, 26);
            this.txtAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadınız : ";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(105, 82);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(217, 26);
            this.txtSoyadi.TabIndex = 2;
            // 
            // lstMailler
            // 
            this.lstMailler.FormattingEnabled = true;
            this.lstMailler.ItemHeight = 20;
            this.lstMailler.Location = new System.Drawing.Point(13, 158);
            this.lstMailler.Name = "lstMailler";
            this.lstMailler.Size = new System.Drawing.Size(309, 324);
            this.lstMailler.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(104, 114);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(217, 38);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 495);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstMailler);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSunucuAdlari);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSunucuAdlari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.ListBox lstMailler;
        private System.Windows.Forms.Button btnKaydet;
    }
}