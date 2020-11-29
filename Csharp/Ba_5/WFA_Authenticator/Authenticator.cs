using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Authenticator
{
    public partial class Authenticator : Form
    {
        #region Global Variables
        Random rnd = new Random();
        int life = 5;
        bool statusLock = false;
        

        #endregion

        public Authenticator()
        {
            InitializeComponent();
        }

        private void Authenticator_Load(object sender, EventArgs e)
        {
            Timer1.Stop();
            int n1 = rnd.Next(0, 10);
            int n2 = rnd.Next(0, 10);
            int n3 = rnd.Next(0, 10);
            int n4 = rnd.Next(0, 10);
            int n5 = rnd.Next(0, 10);
            int n6 = rnd.Next(0, 10);
            int n7 = rnd.Next(0, 10);
            int n8 = rnd.Next(0, 10);
            lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
        }

        private void B_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_tray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (tBox.Text == lblAuth.Text.Replace(" ", ""))
            {
                MessageBox.Show("Login Succesful!");
            }
            else if (life == 5)
            {
                tBox.Text = "";
                pStarR5.Visible = false;
                life--;
                MessageBox.Show("Try Again.");
                int n1 = rnd.Next(0, 10);
                int n2 = rnd.Next(0, 10);
                int n3 = rnd.Next(0, 10);
                int n4 = rnd.Next(0, 10);
                int n5 = rnd.Next(0, 10);
                int n6 = rnd.Next(0, 10);
                int n7 = rnd.Next(0, 10);
                int n8 = rnd.Next(0, 10);
                lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
            }
            else if (life == 4)
            {
                tBox.Text = "";
                pStarR4.Visible = false;
                life--;
                MessageBox.Show("Try Again.");
                int n1 = rnd.Next(0, 10);
                int n2 = rnd.Next(0, 10);
                int n3 = rnd.Next(0, 10);
                int n4 = rnd.Next(0, 10);
                int n5 = rnd.Next(0, 10);
                int n6 = rnd.Next(0, 10);
                int n7 = rnd.Next(0, 10);
                int n8 = rnd.Next(0, 10);
                lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
            }
            else if (life == 3)
            {
                tBox.Text = "";
                pStarR3.Visible = false;
                life--;
                MessageBox.Show("Try Again.");
                int n1 = rnd.Next(0, 10);
                int n2 = rnd.Next(0, 10);
                int n3 = rnd.Next(0, 10);
                int n4 = rnd.Next(0, 10);
                int n5 = rnd.Next(0, 10);
                int n6 = rnd.Next(0, 10);
                int n7 = rnd.Next(0, 10);
                int n8 = rnd.Next(0, 10);
                lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
            }
            else if (life == 2)
            {
                tBox.Text = "";
                pStarR2.Visible = false;
                life--;
                MessageBox.Show("Try Again.");
                int n1 = rnd.Next(0, 10);
                int n2 = rnd.Next(0, 10);
                int n3 = rnd.Next(0, 10);
                int n4 = rnd.Next(0, 10);
                int n5 = rnd.Next(0, 10);
                int n6 = rnd.Next(0, 10);
                int n7 = rnd.Next(0, 10);
                int n8 = rnd.Next(0, 10);
                lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
            }
            else if (life == 1)
            {
                lblAuth.Text = "* * * * * * * *";
                tBox.Text = "";
                pStarR1.Visible = false;
                btnEnter.Visible = false;
                MessageBox.Show("Your account has been locked.");
                statusLock = true;
                Timer1.Start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pStarR1.Visible == false)
            {
                pStarR1.Visible = true;
                label1.Text = "Your account has been locked for 5 seconds.";
            }
            else if(pStarR1.Visible == true && pStarR2.Visible == false)
            {
                pStarR2.Visible = true;
                label1.Text = "Your account has been locked for 4 seconds.";
            }
            else if (pStarR2.Visible == true && pStarR3.Visible == false)
            {
                pStarR3.Visible = true;
                label1.Text = "Your account has been locked for 3 seconds.";
            }
            else if (pStarR3.Visible == true && pStarR4.Visible == false)
            {
                pStarR4.Visible = true;
                label1.Text = "Your account has been locked for 2 seconds.";
            }
            else if (pStarR4.Visible == true && pStarR5.Visible == false)
            {
                pStarR5.Visible = true;
                label1.Text = "Your account has been locked for 1 seconds.";
            }
            else
            {
                statusLock = false;
                btnEnter.Visible = true;
                life = 5;
                Timer1.Stop();
                int n1 = rnd.Next(0, 10);
                int n2 = rnd.Next(0, 10);
                int n3 = rnd.Next(0, 10);
                int n4 = rnd.Next(0, 10);
                int n5 = rnd.Next(0, 10);
                int n6 = rnd.Next(0, 10);
                int n7 = rnd.Next(0, 10);
                int n8 = rnd.Next(0, 10);
                lblAuth.Text = string.Concat(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5 + " " + n6 + " " + n7 + " " + n8);
                label1.Text = "Please enter the numbers below.";
                MessageBox.Show("You can now try again.");
            }

        }
    }
}
