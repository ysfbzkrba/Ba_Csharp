
namespace WFA_Functions
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnKopya = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek1.Location = new System.Drawing.Point(12, 12);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(345, 57);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "Out Metot 1";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek2.Location = new System.Drawing.Point(12, 75);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(345, 57);
            this.btnOrnek2.TabIndex = 0;
            this.btnOrnek2.Text = "Out Metot 2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek3.Location = new System.Drawing.Point(12, 138);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(345, 57);
            this.btnOrnek3.TabIndex = 0;
            this.btnOrnek3.Text = "Params";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnKopya
            // 
            this.btnKopya.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKopya.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKopya.Location = new System.Drawing.Point(12, 201);
            this.btnKopya.Name = "btnKopya";
            this.btnKopya.Size = new System.Drawing.Size(349, 98);
            this.btnKopya.TabIndex = 25;
            this.btnKopya.Text = "EKSTRAAAAAAAAA";
            this.btnKopya.UseVisualStyleBackColor = false;
            this.btnKopya.Click += new System.EventHandler(this.btnKopya_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 309);
            this.Controls.Add(this.btnKopya);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Name = "Form2";
            this.Text = "Form 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnKopya;
    }
}