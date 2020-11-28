
namespace WFA_HorseRacing
{
    partial class Hippodrome
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
            this.components = new System.ComponentModel.Container();
            this.LaneLine1 = new System.Windows.Forms.Label();
            this.LaneLine2 = new System.Windows.Forms.Label();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.Horsey1 = new System.Windows.Forms.PictureBox();
            this.Horsey2 = new System.Windows.Forms.PictureBox();
            this.Horsey3 = new System.Windows.Forms.PictureBox();
            this.LblFinish = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Horsey1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horsey2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horsey3)).BeginInit();
            this.SuspendLayout();
            // 
            // LaneLine1
            // 
            this.LaneLine1.BackColor = System.Drawing.Color.White;
            this.LaneLine1.Location = new System.Drawing.Point(12, 114);
            this.LaneLine1.Name = "LaneLine1";
            this.LaneLine1.Size = new System.Drawing.Size(1, 15);
            this.LaneLine1.TabIndex = 1;
            // 
            // LaneLine2
            // 
            this.LaneLine2.BackColor = System.Drawing.Color.White;
            this.LaneLine2.Location = new System.Drawing.Point(12, 218);
            this.LaneLine2.Name = "LaneLine2";
            this.LaneLine2.Size = new System.Drawing.Size(1, 15);
            this.LaneLine2.TabIndex = 2;
            // 
            // T1
            // 
            this.T1.Enabled = true;
            this.T1.Interval = 50;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // Horsey1
            // 
            this.Horsey1.Image = global::WFA_HorseRacing.Properties.Resources.h1;
            this.Horsey1.Location = new System.Drawing.Point(15, 27);
            this.Horsey1.Name = "Horsey1";
            this.Horsey1.Size = new System.Drawing.Size(121, 84);
            this.Horsey1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horsey1.TabIndex = 7;
            this.Horsey1.TabStop = false;
            // 
            // Horsey2
            // 
            this.Horsey2.Image = global::WFA_HorseRacing.Properties.Resources.h2;
            this.Horsey2.Location = new System.Drawing.Point(15, 131);
            this.Horsey2.Name = "Horsey2";
            this.Horsey2.Size = new System.Drawing.Size(121, 84);
            this.Horsey2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horsey2.TabIndex = 8;
            this.Horsey2.TabStop = false;
            // 
            // Horsey3
            // 
            this.Horsey3.Image = global::WFA_HorseRacing.Properties.Resources.h3;
            this.Horsey3.Location = new System.Drawing.Point(15, 236);
            this.Horsey3.Name = "Horsey3";
            this.Horsey3.Size = new System.Drawing.Size(121, 84);
            this.Horsey3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horsey3.TabIndex = 9;
            this.Horsey3.TabStop = false;
            // 
            // LblFinish
            // 
            this.LblFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFinish.BackColor = System.Drawing.Color.AntiqueWhite;
            this.LblFinish.Location = new System.Drawing.Point(1200, 426);
            this.LblFinish.Name = "LblFinish";
            this.LblFinish.Size = new System.Drawing.Size(15, 15);
            this.LblFinish.TabIndex = 10;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Wheat;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(15, 341);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 84);
            this.Start.TabIndex = 11;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 84);
            this.label1.TabIndex = 12;
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Wheat;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(142, 341);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(121, 84);
            this.Restart.TabIndex = 13;
            this.Restart.Text = "RESTART";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.Wheat;
            this.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.Location = new System.Drawing.Point(1073, 341);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(121, 84);
            this.Reload.TabIndex = 14;
            this.Reload.Text = "RELOAD";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // Hippodrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.LblFinish);
            this.Controls.Add(this.Horsey3);
            this.Controls.Add(this.Horsey2);
            this.Controls.Add(this.Horsey1);
            this.Controls.Add(this.LaneLine2);
            this.Controls.Add(this.LaneLine1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Hippodrome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hippodrome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Horsey1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horsey2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horsey3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LaneLine1;
        private System.Windows.Forms.Label LaneLine2;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.PictureBox Horsey1;
        private System.Windows.Forms.PictureBox Horsey2;
        private System.Windows.Forms.PictureBox Horsey3;
        private System.Windows.Forms.Label LblFinish;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Reload;
    }
}

