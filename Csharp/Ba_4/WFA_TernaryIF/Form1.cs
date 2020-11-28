using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TernaryIF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(? "":"");
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            MessageBox.Show(tBox.Text.Trim().Length > 0 ? tBox.Text : "no input.");
          //MessageBox.Show(string.IsNullOrWhiteSpace(tBox.Text) ? tBox.Text : "no input.");
        }
    }
}
