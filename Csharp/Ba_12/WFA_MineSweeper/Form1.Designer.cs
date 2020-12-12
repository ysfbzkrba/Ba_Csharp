
namespace WFA_MineSweeper
{
    partial class Field
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
            this.lblTopbar = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.EndGame = new System.Windows.Forms.Timer(this.components);
            this.pcbState = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pcbEndgame = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEndgame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopbar
            // 
            this.lblTopbar.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblTopbar.Location = new System.Drawing.Point(0, 0);
            this.lblTopbar.Name = "lblTopbar";
            this.lblTopbar.Size = new System.Drawing.Size(780, 20);
            this.lblTopbar.TabIndex = 0;
            this.lblTopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTopbar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(760, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 780);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Game
            // 
            this.Game.Enabled = true;
            this.Game.Interval = 30;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // EndGame
            // 
            this.EndGame.Enabled = true;
            this.EndGame.Interval = 10;
            this.EndGame.Tick += new System.EventHandler(this.EndGame_Tick);
            // 
            // pcbState
            // 
            this.pcbState.Image = global::WFA_MineSweeper.Properties.Resources.neut;
            this.pcbState.Location = new System.Drawing.Point(380, 0);
            this.pcbState.Name = "pcbState";
            this.pcbState.Size = new System.Drawing.Size(20, 20);
            this.pcbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbState.TabIndex = 4;
            this.pcbState.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WFA_MineSweeper.Properties.Resources.Tray;
            this.button1.Location = new System.Drawing.Point(740, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbEndgame
            // 
            this.pcbEndgame.BackColor = System.Drawing.Color.Transparent;
            this.pcbEndgame.BackgroundImage = global::WFA_MineSweeper.Properties.Resources.GameOver;
            this.pcbEndgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbEndgame.Location = new System.Drawing.Point(-35, 250);
            this.pcbEndgame.Name = "pcbEndgame";
            this.pcbEndgame.Size = new System.Drawing.Size(850, 308);
            this.pcbEndgame.TabIndex = 5;
            this.pcbEndgame.TabStop = false;
            this.pcbEndgame.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(240, 600);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 50);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "S T A R T";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(440, 600);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(100, 50);
            this.btnScore.TabIndex = 7;
            this.btnScore.Text = "S C O R E";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 800);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbEndgame);
            this.Controls.Add(this.pcbState);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Field";
            this.Text = "Field";
            this.Load += new System.EventHandler(this.Field_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEndgame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTopbar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.Timer EndGame;
        private System.Windows.Forms.PictureBox pcbState;
        private System.Windows.Forms.PictureBox pcbEndgame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnScore;
    }
}

