
namespace WFA_Library
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
            this.lblTopbar = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.dtpPrintYear = new System.Windows.Forms.DateTimePicker();
            this.pageUpDown = new System.Windows.Forms.NumericUpDown();
            this.printUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPYear = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblPrintCount = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.txtPub = new System.Windows.Forms.TextBox();
            this.lblAuth = new System.Windows.Forms.Label();
            this.txtAuth = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.grpBooks = new System.Windows.Forms.GroupBox();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.cmsBookList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorP1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printUpDown)).BeginInit();
            this.grpBooks.SuspendLayout();
            this.cmsBookList.SuspendLayout();
            this.grpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopbar
            // 
            this.lblTopbar.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTopbar.Location = new System.Drawing.Point(0, 0);
            this.lblTopbar.Name = "lblTopbar";
            this.lblTopbar.Size = new System.Drawing.Size(760, 10);
            this.lblTopbar.TabIndex = 0;
            this.lblTopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTopbar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(740, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(720, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.cmbGenres);
            this.grpCreate.Controls.Add(this.dtpPrintYear);
            this.grpCreate.Controls.Add(this.pageUpDown);
            this.grpCreate.Controls.Add(this.printUpDown);
            this.grpCreate.Controls.Add(this.lblISBN);
            this.grpCreate.Controls.Add(this.lblGenre);
            this.grpCreate.Controls.Add(this.lblPYear);
            this.grpCreate.Controls.Add(this.lblPageCount);
            this.grpCreate.Controls.Add(this.lblPrintCount);
            this.grpCreate.Controls.Add(this.lblPub);
            this.grpCreate.Controls.Add(this.txtPub);
            this.grpCreate.Controls.Add(this.lblAuth);
            this.grpCreate.Controls.Add(this.txtAuth);
            this.grpCreate.Controls.Add(this.lblBookName);
            this.grpCreate.Controls.Add(this.txtBookName);
            this.grpCreate.Controls.Add(this.txtISBN);
            this.grpCreate.Font = new System.Drawing.Font("Calibri", 16F);
            this.grpCreate.Location = new System.Drawing.Point(12, 52);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(450, 320);
            this.grpCreate.TabIndex = 3;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "New Book";
            // 
            // cmbGenres
            // 
            this.cmbGenres.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(120, 224);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(324, 27);
            this.cmbGenres.TabIndex = 18;
            // 
            // dtpPrintYear
            // 
            this.dtpPrintYear.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpPrintYear.Location = new System.Drawing.Point(120, 192);
            this.dtpPrintYear.Name = "dtpPrintYear";
            this.dtpPrintYear.Size = new System.Drawing.Size(324, 27);
            this.dtpPrintYear.TabIndex = 17;
            // 
            // pageUpDown
            // 
            this.pageUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.pageUpDown.Location = new System.Drawing.Point(120, 159);
            this.pageUpDown.Name = "pageUpDown";
            this.pageUpDown.Size = new System.Drawing.Size(324, 27);
            this.pageUpDown.TabIndex = 16;
            // 
            // printUpDown
            // 
            this.printUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.printUpDown.Location = new System.Drawing.Point(120, 126);
            this.printUpDown.Name = "printUpDown";
            this.printUpDown.Size = new System.Drawing.Size(324, 27);
            this.printUpDown.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblISBN.Location = new System.Drawing.Point(6, 258);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(108, 26);
            this.lblISBN.TabIndex = 15;
            this.lblISBN.Text = "ISBN No. :";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtISBN.Location = new System.Drawing.Point(120, 257);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(324, 27);
            this.txtISBN.TabIndex = 14;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            this.txtISBN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtISBN_KeyUp);
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblGenre.Location = new System.Drawing.Point(6, 225);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(108, 26);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Genre :";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPYear
            // 
            this.lblPYear.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblPYear.Location = new System.Drawing.Point(6, 192);
            this.lblPYear.Name = "lblPYear";
            this.lblPYear.Size = new System.Drawing.Size(108, 26);
            this.lblPYear.TabIndex = 11;
            this.lblPYear.Text = "Print Year :";
            this.lblPYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblPageCount.Location = new System.Drawing.Point(6, 159);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(108, 26);
            this.lblPageCount.TabIndex = 9;
            this.lblPageCount.Text = "Page Count :";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrintCount
            // 
            this.lblPrintCount.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblPrintCount.Location = new System.Drawing.Point(6, 126);
            this.lblPrintCount.Name = "lblPrintCount";
            this.lblPrintCount.Size = new System.Drawing.Size(108, 26);
            this.lblPrintCount.TabIndex = 7;
            this.lblPrintCount.Text = "Print Count :";
            this.lblPrintCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPub
            // 
            this.lblPub.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblPub.Location = new System.Drawing.Point(6, 93);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(108, 26);
            this.lblPub.TabIndex = 5;
            this.lblPub.Text = "Publisher :";
            this.lblPub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPub
            // 
            this.txtPub.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPub.Location = new System.Drawing.Point(120, 92);
            this.txtPub.Name = "txtPub";
            this.txtPub.Size = new System.Drawing.Size(324, 27);
            this.txtPub.TabIndex = 4;
            // 
            // lblAuth
            // 
            this.lblAuth.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblAuth.Location = new System.Drawing.Point(6, 60);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(108, 26);
            this.lblAuth.TabIndex = 3;
            this.lblAuth.Text = "Author :";
            this.lblAuth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAuth
            // 
            this.txtAuth.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAuth.Location = new System.Drawing.Point(120, 59);
            this.txtAuth.Name = "txtAuth";
            this.txtAuth.Size = new System.Drawing.Size(324, 27);
            this.txtAuth.TabIndex = 2;
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Calibri", 14F);
            this.lblBookName.Location = new System.Drawing.Point(6, 27);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(108, 26);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "Book Name :";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBookName.Location = new System.Drawing.Point(120, 26);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(324, 27);
            this.txtBookName.TabIndex = 0;
            // 
            // grpBooks
            // 
            this.grpBooks.Controls.Add(this.listBooks);
            this.grpBooks.Font = new System.Drawing.Font("Calibri", 16F);
            this.grpBooks.Location = new System.Drawing.Point(468, 52);
            this.grpBooks.Name = "grpBooks";
            this.grpBooks.Size = new System.Drawing.Size(280, 320);
            this.grpBooks.TabIndex = 4;
            this.grpBooks.TabStop = false;
            this.grpBooks.Text = "Book List";
            // 
            // listBooks
            // 
            this.listBooks.ContextMenuStrip = this.cmsBookList;
            this.listBooks.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBooks.FormattingEnabled = true;
            this.listBooks.ItemHeight = 19;
            this.listBooks.Location = new System.Drawing.Point(6, 27);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(266, 270);
            this.listBooks.TabIndex = 0;
            // 
            // cmsBookList
            // 
            this.cmsBookList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmDelete});
            this.cmsBookList.Name = "cmsBookList";
            this.cmsBookList.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(180, 22);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnUpdate);
            this.grpControl.Controls.Add(this.btnSave);
            this.grpControl.Font = new System.Drawing.Font("Calibri", 16F);
            this.grpControl.Location = new System.Drawing.Point(12, 378);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(736, 100);
            this.grpControl.TabIndex = 5;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Control Panel";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(266, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(462, 60);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "U P D A T E";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 60);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "S A V E";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(104, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Library";
            // 
            // errorP1
            // 
            this.errorP1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpControl);
            this.Controls.Add(this.grpBooks);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printUpDown)).EndInit();
            this.grpBooks.ResumeLayout(false);
            this.cmsBookList.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopbar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.GroupBox grpBooks;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPYear;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblPrintCount;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.TextBox txtPub;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.TextBox txtAuth;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.DateTimePicker dtpPrintYear;
        private System.Windows.Forms.NumericUpDown pageUpDown;
        private System.Windows.Forms.NumericUpDown printUpDown;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip cmsBookList;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ErrorProvider errorP1;
        private System.Windows.Forms.ComboBox cmbGenres;
    }
}

