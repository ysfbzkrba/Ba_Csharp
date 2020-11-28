
namespace WFA_SwitchCase
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_months = new System.Windows.Forms.Button();
            this.btn_season = new System.Windows.Forms.Button();
            this.btn_season1 = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_months
            // 
            this.btn_months.Location = new System.Drawing.Point(12, 38);
            this.btn_months.Name = "btn_months";
            this.btn_months.Size = new System.Drawing.Size(360, 27);
            this.btn_months.TabIndex = 1;
            this.btn_months.Text = "Season";
            this.btn_months.UseVisualStyleBackColor = true;
            this.btn_months.Click += new System.EventHandler(this.btn_months_Click);
            // 
            // btn_season
            // 
            this.btn_season.Location = new System.Drawing.Point(12, 104);
            this.btn_season.Name = "btn_season";
            this.btn_season.Size = new System.Drawing.Size(360, 27);
            this.btn_season.TabIndex = 2;
            this.btn_season.Text = "Months";
            this.btn_season.UseVisualStyleBackColor = true;
            this.btn_season.Click += new System.EventHandler(this.btn_months2_Click);
            // 
            // btn_season1
            // 
            this.btn_season1.Location = new System.Drawing.Point(12, 71);
            this.btn_season1.Name = "btn_season1";
            this.btn_season1.Size = new System.Drawing.Size(360, 27);
            this.btn_season1.TabIndex = 3;
            this.btn_season1.Text = "Season (if)";
            this.btn_season1.UseVisualStyleBackColor = true;
            this.btn_season1.Click += new System.EventHandler(this.btn_season1_Click);
            // 
            // btn_score
            // 
            this.btn_score.Location = new System.Drawing.Point(12, 159);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(360, 27);
            this.btn_score.TabIndex = 4;
            this.btn_score.Text = "LetterScore";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_season1);
            this.Controls.Add(this.btn_season);
            this.Controls.Add(this.btn_months);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_months;
        private System.Windows.Forms.Button btn_season;
        private System.Windows.Forms.Button btn_season1;
        private System.Windows.Forms.Button btn_score;
    }
}

