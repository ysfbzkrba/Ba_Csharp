using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Global
{// A
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
        }


        int count = 15; // int count is declared


        private void ADD_Click(object sender, EventArgs e)
        {
            
            // count = count + 1; 
            // count += 1;
            count++; 
            lblCount.Text = count.ToString();
        } // add to count

        private void SUB_Click(object sender, EventArgs e)
        {
            
            // count = count - 1; 
            // count -= 1;
            count--;
            lblCount.Text = count.ToString();

        } // sub from count

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
 // Z
}
