using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.ifelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            {
                /*                      *
                 *                      *
                 *  1)  ==              *
                 *  2)  !=              *
                 *  3)  >               *
                 *  4)  <               *
                 *  5)  >=              *
                 *  6)  <=              *
                 *  7)  ! (not)         *
                 *                      *
                 *                      */
            }
            // user entry
            string username = "admin";// user in database
            string user_name = txt1.Text.ToLower().Trim();

            if (username == user_name) // always use entry modifications.
            {
                txt1.Text = user_name;
                MessageBox.Show("Access Granted.");
            }
            else
            {
                MessageBox.Show("Access Denied.");
            }

        } 

        private void btn2_Click(object sender, EventArgs e)
        {
            
            try {

            string txtScore = txt1.Text.ToLower().Replace("[a-z]","");
                
            int score = Convert.ToInt32(txtScore);

            if (score < 0)
            {
                MessageBox.Show("Can't enter score below 0.");
            }
            else if (score > 100)
            {
                MessageBox.Show("Can't enter score above 100.");
            }
            else
            {
                MessageBox.Show("The score is " + score);
            }
            }
            catch
            {
                MessageBox.Show(txt1+" i not a number between 0 and 100.");
            }

            
            // if score < 0 say " cant enter score below 0 "
            // else if score > 100 say "cant enter a score above 100"
            // else go
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // if number is odd (x%2 = 1) say number is odd
            // else say number is even.
           
            try { 
                 int number = Convert.ToInt32(txt1.Text);
            if (number%2==1)
            {
                MessageBox.Show("The number is odd.");
            } 
            else
            {
                MessageBox.Show("The number is even.");
            }
            }
            catch
            {
                MessageBox.Show(txt1 + " is not a number.");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //if text.length >= 8 accept password  
            //else say "password is too short."
            if (txt1.TextLength >= 8)
            {
                MessageBox.Show("Password Accepted.");
            }
            else
            {
                MessageBox.Show("Password is too short.");
            }
        }
    }
}
