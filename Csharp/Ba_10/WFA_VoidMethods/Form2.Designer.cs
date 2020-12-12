
namespace WFA_VoidMethods
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
            this.components = new System.ComponentModel.Container();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.btn_Repair = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Counter
            // 
            this.btn_Counter.Location = new System.Drawing.Point(12, 12);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(221, 53);
            this.btn_Counter.TabIndex = 0;
            this.btn_Counter.Text = "Counter";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.btn_Counter_Click);
            // 
            // btn_Repair
            // 
            this.btn_Repair.Location = new System.Drawing.Point(12, 71);
            this.btn_Repair.Name = "btn_Repair";
            this.btn_Repair.Size = new System.Drawing.Size(221, 53);
            this.btn_Repair.TabIndex = 1;
            this.btn_Repair.Text = "Repair";
            this.btn_Repair.UseVisualStyleBackColor = true;
            this.btn_Repair.Click += new System.EventHandler(this.btn_Repair_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(239, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 277);
            this.listBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 130);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(221, 53);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 303);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Repair);
            this.Controls.Add(this.btn_Counter);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Counter;
        private System.Windows.Forms.Button btn_Repair;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
    }
}