
namespace WFA_Authenticator
{
    partial class Authenticator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authenticator));
            this.TopBar = new System.Windows.Forms.Label();
            this.B_exit = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuth = new System.Windows.Forms.Label();
            this.tBox = new System.Windows.Forms.TextBox();
            this.lblTry = new System.Windows.Forms.Label();
            this.btnShut = new System.Windows.Forms.Button();
            this.pStarR1 = new System.Windows.Forms.PictureBox();
            this.pStarR2 = new System.Windows.Forms.PictureBox();
            this.pStarR3 = new System.Windows.Forms.PictureBox();
            this.pStarR4 = new System.Windows.Forms.PictureBox();
            this.pStarR5 = new System.Windows.Forms.PictureBox();
            this.pStar5 = new System.Windows.Forms.PictureBox();
            this.pStar4 = new System.Windows.Forms.PictureBox();
            this.pStar3 = new System.Windows.Forms.PictureBox();
            this.pStar2 = new System.Windows.Forms.PictureBox();
            this.pStar1 = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.B_tray = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pStarR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(560, 10);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // B_exit
            // 
            this.B_exit.BackColor = System.Drawing.SystemColors.Control;
            this.B_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.B_exit.FlatAppearance.BorderSize = 0;
            this.B_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.B_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_exit.Location = new System.Drawing.Point(537, 13);
            this.B_exit.Name = "B_exit";
            this.B_exit.Size = new System.Drawing.Size(20, 20);
            this.B_exit.TabIndex = 1;
            this.B_exit.Text = "X";
            this.B_exit.UseVisualStyleBackColor = false;
            this.B_exit.Click += new System.EventHandler(this.B_exit_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin.Location = new System.Drawing.Point(15, 40);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(116, 30);
            this.UserLogin.TabIndex = 4;
            this.UserLogin.Text = "User Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please enter the numbers below.";
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuth.Location = new System.Drawing.Point(16, 110);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(89, 19);
            this.lblAuth.TabIndex = 6;
            this.lblAuth.Text = " * * * * * * * *";
            // 
            // tBox
            // 
            this.tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBox.Location = new System.Drawing.Point(15, 135);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(530, 29);
            this.tBox.TabIndex = 7;
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTry.Location = new System.Drawing.Point(15, 260);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(122, 21);
            this.lblTry.TabIndex = 9;
            this.lblTry.Text = "Remaining tries:";
            // 
            // btnShut
            // 
            this.btnShut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShut.BackgroundImage = global::WFA_Authenticator.Properties.Resources.icons8_keepass_32px;
            this.btnShut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShut.FlatAppearance.BorderSize = 0;
            this.btnShut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShut.Location = new System.Drawing.Point(15, 170);
            this.btnShut.Name = "btnShut";
            this.btnShut.Size = new System.Drawing.Size(530, 60);
            this.btnShut.TabIndex = 8;
            this.btnShut.UseVisualStyleBackColor = false;
            // 
            // pStarR1
            // 
            this.pStarR1.Image = global::WFA_Authenticator.Properties.Resources.icons8_star_30px_3;
            this.pStarR1.Location = new System.Drawing.Point(143, 255);
            this.pStarR1.Name = "pStarR1";
            this.pStarR1.Size = new System.Drawing.Size(30, 30);
            this.pStarR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStarR1.TabIndex = 10;
            this.pStarR1.TabStop = false;
            // 
            // pStarR2
            // 
            this.pStarR2.Image = global::WFA_Authenticator.Properties.Resources.icons8_star_30px_3;
            this.pStarR2.Location = new System.Drawing.Point(179, 255);
            this.pStarR2.Name = "pStarR2";
            this.pStarR2.Size = new System.Drawing.Size(30, 30);
            this.pStarR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStarR2.TabIndex = 11;
            this.pStarR2.TabStop = false;
            // 
            // pStarR3
            // 
            this.pStarR3.Image = global::WFA_Authenticator.Properties.Resources.icons8_star_30px_3;
            this.pStarR3.Location = new System.Drawing.Point(215, 255);
            this.pStarR3.Name = "pStarR3";
            this.pStarR3.Size = new System.Drawing.Size(30, 30);
            this.pStarR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStarR3.TabIndex = 12;
            this.pStarR3.TabStop = false;
            // 
            // pStarR4
            // 
            this.pStarR4.Image = global::WFA_Authenticator.Properties.Resources.icons8_star_30px_3;
            this.pStarR4.Location = new System.Drawing.Point(251, 255);
            this.pStarR4.Name = "pStarR4";
            this.pStarR4.Size = new System.Drawing.Size(30, 30);
            this.pStarR4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStarR4.TabIndex = 13;
            this.pStarR4.TabStop = false;
            // 
            // pStarR5
            // 
            this.pStarR5.Image = global::WFA_Authenticator.Properties.Resources.icons8_star_30px_3;
            this.pStarR5.Location = new System.Drawing.Point(287, 255);
            this.pStarR5.Name = "pStarR5";
            this.pStarR5.Size = new System.Drawing.Size(30, 30);
            this.pStarR5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStarR5.TabIndex = 14;
            this.pStarR5.TabStop = false;
            // 
            // pStar5
            // 
            this.pStar5.Image = ((System.Drawing.Image)(resources.GetObject("pStar5.Image")));
            this.pStar5.Location = new System.Drawing.Point(287, 255);
            this.pStar5.Name = "pStar5";
            this.pStar5.Size = new System.Drawing.Size(30, 30);
            this.pStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStar5.TabIndex = 19;
            this.pStar5.TabStop = false;
            // 
            // pStar4
            // 
            this.pStar4.Image = ((System.Drawing.Image)(resources.GetObject("pStar4.Image")));
            this.pStar4.Location = new System.Drawing.Point(251, 255);
            this.pStar4.Name = "pStar4";
            this.pStar4.Size = new System.Drawing.Size(30, 30);
            this.pStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStar4.TabIndex = 18;
            this.pStar4.TabStop = false;
            // 
            // pStar3
            // 
            this.pStar3.Image = ((System.Drawing.Image)(resources.GetObject("pStar3.Image")));
            this.pStar3.Location = new System.Drawing.Point(215, 255);
            this.pStar3.Name = "pStar3";
            this.pStar3.Size = new System.Drawing.Size(30, 30);
            this.pStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStar3.TabIndex = 17;
            this.pStar3.TabStop = false;
            // 
            // pStar2
            // 
            this.pStar2.Image = ((System.Drawing.Image)(resources.GetObject("pStar2.Image")));
            this.pStar2.Location = new System.Drawing.Point(179, 255);
            this.pStar2.Name = "pStar2";
            this.pStar2.Size = new System.Drawing.Size(30, 30);
            this.pStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStar2.TabIndex = 16;
            this.pStar2.TabStop = false;
            // 
            // pStar1
            // 
            this.pStar1.Image = ((System.Drawing.Image)(resources.GetObject("pStar1.Image")));
            this.pStar1.Location = new System.Drawing.Point(143, 255);
            this.pStar1.Name = "pStar1";
            this.pStar1.Size = new System.Drawing.Size(30, 30);
            this.pStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pStar1.TabIndex = 15;
            this.pStar1.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(182)))), ((int)(((byte)(208)))));
            this.btnEnter.BackgroundImage = global::WFA_Authenticator.Properties.Resources.icons8_approved_unlock_50px;
            this.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnter.Location = new System.Drawing.Point(15, 170);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(530, 60);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // B_tray
            // 
            this.B_tray.BackColor = System.Drawing.SystemColors.Control;
            this.B_tray.BackgroundImage = global::WFA_Authenticator.Properties.Resources.Tray1;
            this.B_tray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.B_tray.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.B_tray.FlatAppearance.BorderSize = 0;
            this.B_tray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.B_tray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.B_tray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_tray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_tray.Location = new System.Drawing.Point(514, 13);
            this.B_tray.Name = "B_tray";
            this.B_tray.Size = new System.Drawing.Size(20, 20);
            this.B_tray.TabIndex = 3;
            this.B_tray.UseVisualStyleBackColor = false;
            this.B_tray.Click += new System.EventHandler(this.B_tray_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Authenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.pStarR5);
            this.Controls.Add(this.pStarR4);
            this.Controls.Add(this.pStarR3);
            this.Controls.Add(this.pStarR2);
            this.Controls.Add(this.pStarR1);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.B_tray);
            this.Controls.Add(this.B_exit);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.pStar5);
            this.Controls.Add(this.pStar4);
            this.Controls.Add(this.pStar3);
            this.Controls.Add(this.pStar2);
            this.Controls.Add(this.pStar1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnShut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authenticator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Authenticator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pStarR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStarR5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopBar;
        private System.Windows.Forms.Button B_exit;
        private System.Windows.Forms.Label UserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button btnShut;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.PictureBox pStarR1;
        private System.Windows.Forms.PictureBox pStarR2;
        private System.Windows.Forms.PictureBox pStarR3;
        private System.Windows.Forms.PictureBox pStarR4;
        private System.Windows.Forms.PictureBox pStarR5;
        private System.Windows.Forms.PictureBox pStar5;
        private System.Windows.Forms.PictureBox pStar4;
        private System.Windows.Forms.PictureBox pStar3;
        private System.Windows.Forms.PictureBox pStar2;
        private System.Windows.Forms.PictureBox pStar1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button B_tray;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

