using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            //do
            //{
            //    listBox1.Items.Add(i);
            //    i++;
            //} while (i<=100);

            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < this.Controls.Count)
            {
                Control ctrl = this.Controls[i];
                
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Tomato;
                }
                i++;
            }
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    Control ctrl = this.Controls[i];
            //    if (ctrl is Button)
            //    {
            //        ctrl.BackColor = Color.Tomato;
            //    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control ctrl = this.Controls[i];
                this.Controls[i].BackColor = (this.Controls[i] is Button) ? Color.Tomato : default;
            }
         }
    }
}
