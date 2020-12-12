using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_VoidMethods
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }


        void Clear()
        {
            textBox1.Text = string.Empty;
            textBox2.Clear();
            textBox3.Text = default;
            textBox4.Text = null;
            textBox5.Text = "";
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
