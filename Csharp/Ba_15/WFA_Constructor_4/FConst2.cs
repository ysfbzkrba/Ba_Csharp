﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor_4
{
    public partial class FConst2 : Form
    {
        public FConst2()
        {
            InitializeComponent();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            FConst3 frm = new FConst3(textBox1.Text);

            //frm.label1.Text = textBox1.Text;
            frm.Show();
        }
    }
}
