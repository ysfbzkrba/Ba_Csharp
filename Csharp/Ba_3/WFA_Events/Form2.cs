using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Events
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_box1_TextChanged(object sender, EventArgs e)
        {
            int length = txt_box1.Text.Length;

            if (txt_box1.Text.Length >500)
            {
                lbl_remaining.ForeColor = System.Drawing.Color.Red;
                lbl_remaining.Text = (500 - txt_box1.Text.Length).ToString() + " too many characters.";
            } else 
            {
                lbl_remaining.ForeColor = System.Drawing.Color.Black;
                lbl_remaining.Text = (500 - txt_box1.Text.Length).ToString();
            }
            

        }
    }
}
