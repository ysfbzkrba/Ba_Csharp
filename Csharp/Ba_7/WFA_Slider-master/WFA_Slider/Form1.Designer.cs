namespace WFA_Slider
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLast = new MetroFramework.Controls.MetroTile();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new MetroFramework.Controls.MetroTrackBar();
            this.btnNext = new MetroFramework.Controls.MetroTile();
            this.btnStartStop = new MetroFramework.Controls.MetroTile();
            this.btnFirst = new MetroFramework.Controls.MetroTile();
            this.btnBack = new MetroFramework.Controls.MetroTile();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLast
            // 
            this.btnLast.ActiveControl = null;
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLast.Location = new System.Drawing.Point(770, 409);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(99, 91);
            this.btnLast.TabIndex = 6;
            this.btnLast.TileImage = global::WFA_Slider.Properties.Resources.icon_right;
            this.btnLast.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLast.UseCustomBackColor = true;
            this.btnLast.UseSelectable = true;
            this.btnLast.UseTileImage = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "r1.jpg");
            this.imageList.Images.SetKeyName(1, "r2.jpg");
            this.imageList.Images.SetKeyName(2, "r3.jpg");
            this.imageList.Images.SetKeyName(3, "r4.png");
            this.imageList.Images.SetKeyName(4, "r5.png");
            this.imageList.Images.SetKeyName(5, "r6.jpg");
            this.imageList.Images.SetKeyName(6, "r7.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.Location = new System.Drawing.Point(233, 477);
            this.trackBar.Maximum = 1000;
            this.trackBar.Minimum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(426, 23);
            this.trackBar.TabIndex = 9;
            this.trackBar.Text = "metroTrackBar1";
            this.trackBar.Value = 100;
            this.trackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.ActiveControl = null;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNext.Location = new System.Drawing.Point(665, 409);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 91);
            this.btnNext.TabIndex = 4;
            this.btnNext.TileImage = global::WFA_Slider.Properties.Resources.icon_next;
            this.btnNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.UseCustomBackColor = true;
            this.btnNext.UseSelectable = true;
            this.btnNext.UseTileImage = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.ActiveControl = null;
            this.btnStartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStartStop.Location = new System.Drawing.Point(233, 409);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(426, 62);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.TileImage = global::WFA_Slider.Properties.Resources.icon_start;
            this.btnStartStop.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartStop.UseCustomBackColor = true;
            this.btnStartStop.UseSelectable = true;
            this.btnStartStop.UseTileImage = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.ActiveControl = null;
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnFirst.Location = new System.Drawing.Point(23, 409);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(99, 91);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.TileImage = global::WFA_Slider.Properties.Resources.icon_left;
            this.btnFirst.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFirst.UseCustomBackColor = true;
            this.btnFirst.UseSelectable = true;
            this.btnFirst.UseTileImage = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveControl = null;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnBack.Location = new System.Drawing.Point(128, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 91);
            this.btnBack.TabIndex = 8;
            this.btnBack.TileImage = global::WFA_Slider.Properties.Resources.icon_back;
            this.btnBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseTileImage = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.pcbImage.Location = new System.Drawing.Point(23, 63);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(846, 340);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 3;
            this.pcbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 519);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.trackBar);
            this.Name = "Form1";
            this.Text = "Slider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnNext;
        private MetroFramework.Controls.MetroTile btnStartStop;
        private MetroFramework.Controls.MetroTile btnLast;
        private MetroFramework.Controls.MetroTile btnFirst;
        private MetroFramework.Controls.MetroTile btnBack;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTrackBar trackBar;
    }
}

