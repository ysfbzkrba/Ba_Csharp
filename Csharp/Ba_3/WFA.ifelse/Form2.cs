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
    public partial class Form2 : Form
    {
        #region
        /*
         * 
         *  Logical Operators:
         *  
         *  && and
         *  
         *  || or
         * 
        */
        #endregion
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string username = txt1.Text.ToLower();
            string password = txt2.Text;
            string result = "";
            #region
            /*
            if (username == "admin")
            {
                if (password=="123")
                {
                    result = "Access Granted!";
                }else
                {
                    result = "Password is wrong.";
                }
            } else
            {
                result = "Username is wrong. Didn't check for password";
            }
            MessageBox.Show(result);
            */
            #endregion

            if (username == "admin" && password == "123")
            {
                result = "Access Granted";
            }
            else
            {
                result = "Please make sure your username and password is correct." ;
            }
            MessageBox.Show(result);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            #region
            /*
               try
               {
                   txt1.Text = txt2.Text;
                   int score = int.Parse(txt1.Text);
                   string lscore;
                   if (score >= 0 && score <= 30)
                   {
                       lscore = "Your letter score is : FF";
                   }
                   else if (score >= 31 && score <= 50)
                   {
                       lscore = "Your letter score is : DD";
                   }
                   else if (score >= 51 && score <= 70)
                   {
                       lscore = "Your letter score is : CC";
                   }
                   else if (score >= 71 && score <= 85)
                   {
                       lscore = "Your letter score is : BB";
                   }
                   else if (score >=86 && score <=100)
                   {
                       lscore = "Your letter score is : AA";
                   }
                   else
                   {
                       lscore = "Please enter  a value between 0-100";
                   }
                   MessageBox.Show("Your letter score is : " + lscore);
               }
               catch
               {
                   MessageBox.Show("please make sure you have entered a number between 0 - 100");
               }
            */
            #endregion
            try
            {
                txt1.Text = txt2.Text;
                int score = int.Parse(txt1.Text);
                string lscore="";
                if (score > 0 && score < 100)
                {
                    if (score <= 30) lscore += "FF";
                    else if (score <= 50) lscore += "DD";
                    else if (score <= 70) lscore += "CC";
                    else if (score <= 85) lscore += "BB";
                    else lscore += "AA";
                    MessageBox.Show(lscore);
                }
                else lscore += "Please make sure score is between 0 -100";
                MessageBox.Show(lscore);
            }            
            catch
            {
                MessageBox.Show("Please make sure you entered a value between 0 - 100");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            string prod = txt1.Text.Trim().ToLower().Replace("ş","s").Replace("ı","i").Replace("ü","u");
            string emp = " is in {0} aisle.";
            if (!string.IsNullOrWhiteSpace(prod))
            {
                if (prod == "domates" || prod == "biber" || prod == "patlican")
                {
                    emp = string.Format(emp, "vegetables");
                }
                else if (prod == "dis macunu" || prod == "parfum" || prod == "sampuan")
                {
                    emp = string.Format(emp, "cosmetics");
                }
                else if (prod == "cep telefonu" || prod == "bilgisayar" || prod == "ses sistemi")
                {
                    emp = string.Format(emp, "technologics");
                }
                else emp = ".. Sorry but we dont have that in stock.";
                MessageBox.Show(txt1.Text + emp);
            }
            else emp = "Sorry I didn't catch that.";

        }
    }
}
