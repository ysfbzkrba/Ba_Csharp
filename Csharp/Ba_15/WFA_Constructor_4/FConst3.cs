using System;
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
    public partial class FConst3 : Form
    {
        public FConst3()
        {
            InitializeComponent();
        }
        public FConst3(string text) : this()
        {
            label1.Text = text;
        }

        private void FConst3_Load(object sender, EventArgs e)
        {

        }
    }
}
