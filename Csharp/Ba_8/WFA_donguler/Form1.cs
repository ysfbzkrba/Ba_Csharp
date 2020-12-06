using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_donguler
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

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            //  for     ==
            //  while   ==
            //  foreach ==
            //  dowhile ==
            listBox1.Items.Clear();
            for (int i = 1; i<=1000; i++)
            {
               
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            
            for (int i = 1000; i >= 1; i--)
            {
                
                listBox1.Items.Add(i);
            }
        }
        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i <= 1000; i++) 
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);

                }
            }
                
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (char kar = 'a'; kar<='z'; kar++)
            {
                listBox1.Items.Add(kar);
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sum = 0;
            for (int x = 1; x <= 100; x++)
            {
                sum += x;
            }
            listBox1.Items.Add(sum);
        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int sum = 0;
            int sumodd = 0;
            int calc = (sum - sumodd) * (sum - sumodd);
            for (int i = 0; i <= 100; i++)
            {
                if(i%2==1)
                
                {
                    sumodd += i;
                }else 
                {
                    sum += i;
                }
                
                
            }
            MessageBox.Show(calc.ToString());
        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int year = 1945; year <= DateTime.Now.Year ; year++)
            {
                //if (year != 1990 && year != 1992)
                //listBox1.Items.Add(year);


                //switch (year)
                //{
                //    case int x when x != 1990 && x != 1992:
                //        {
                //            listBox1.Items.Add(x);
                //            break;
                //        }
                //}

                listBox1.Items.Add((year != 1990 && year != 1992) ? year : 0); //ternary if
            }

        }

    }
}
