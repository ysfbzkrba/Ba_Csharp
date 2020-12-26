
namespace WFA_Constructor_4
{
    partial class FConst4
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
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.btnFinit = new System.Windows.Forms.Button();
            this.btnChangeBColor = new System.Windows.Forms.Button();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(77, 53);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(150, 45);
            this.tbRed.TabIndex = 0;
            this.tbRed.Scroll += new System.EventHandler(this.tbRed_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(77, 104);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(150, 45);
            this.tbGreen.TabIndex = 1;
            this.tbGreen.Scroll += new System.EventHandler(this.tbGreen_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(77, 155);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(150, 45);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.Scroll += new System.EventHandler(this.tbBlue_Scroll);
            // 
            // btnFinit
            // 
            this.btnFinit.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnFinit.Location = new System.Drawing.Point(12, 12);
            this.btnFinit.Name = "btnFinit";
            this.btnFinit.Size = new System.Drawing.Size(215, 35);
            this.btnFinit.TabIndex = 3;
            this.btnFinit.Text = "Open/Close";
            this.btnFinit.UseVisualStyleBackColor = true;
            this.btnFinit.Click += new System.EventHandler(this.btnFinit_Click);
            // 
            // btnChangeBColor
            // 
            this.btnChangeBColor.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnChangeBColor.Location = new System.Drawing.Point(12, 206);
            this.btnChangeBColor.Name = "btnChangeBColor";
            this.btnChangeBColor.Size = new System.Drawing.Size(215, 35);
            this.btnChangeBColor.TabIndex = 4;
            this.btnChangeBColor.Text = "Set Color";
            this.btnChangeBColor.UseVisualStyleBackColor = true;
            this.btnChangeBColor.Click += new System.EventHandler(this.btnChangeBColor_Click);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblRed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRed.Location = new System.Drawing.Point(12, 53);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(20, 23);
            this.lblRed.TabIndex = 5;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblGreen.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblGreen.Location = new System.Drawing.Point(12, 104);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(20, 23);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblBlue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBlue.Location = new System.Drawing.Point(12, 155);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(20, 23);
            this.lblBlue.TabIndex = 7;
            this.lblBlue.Text = "0";
            // 
            // FConst4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 256);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.btnChangeBColor);
            this.Controls.Add(this.btnFinit);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Name = "FConst4";
            this.Text = "FConst4";
            this.Load += new System.EventHandler(this.FConst4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Button btnFinit;
        private System.Windows.Forms.Button btnChangeBColor;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
    }
}