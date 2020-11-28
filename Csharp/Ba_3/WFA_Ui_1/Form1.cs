using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Ui_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Please Enter Name...")
            {
                txtName.ForeColor = Color.Black;
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                txtName.ForeColor = Color.BlueViolet;
                txtName.Text = "Please Enter Name...";
            }
        }
    }
}
