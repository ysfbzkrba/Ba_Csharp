using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Functions
{
    public partial class Form1 : Form
    {


        #region Variables

        Random rnd = new Random();
        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));

        #endregion


        public Form1()
        {
            InitializeComponent();
        }



        int calcSum(int n1, int n2)
        {
            int sum = n1 + n2;

            return sum;
        }
        int EvenOdd(int n)
        {
            if (n == 0)
            {
                return 0;
            }else if (n % 2 == 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }

            //{
            //    int evenodd = 0;
            //    if (n % 2 == 0 && n != 0)
            //    {
            //        evenodd = -1;
            //    }
            //    else if (n % 2 != 0)
            //    {
            //        evenodd = 1;
            //    }
            //    else evenodd = 0;
            //    return evenodd;
            //}
        }

        string textedit (string text)
        {
           
            string[] parts = text.Split(' ');
            string ftl = parts[0].Substring(0, 2).ToUpper();
            ftl += parts[0].Substring(2).ToLower();
            string mail = ftl + "." + parts[1].Replace("a", "e").Replace("A", "E") + "@hotmail.com";
            return mail;
        }
        double SqrRoot (int[] numbers)
        {
            double sum = Enumerable.Sum(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            double sqrt = Math.Sqrt(sum);
            return sqrt;
        }
        Color Ctrl (Control control)
        {

            //string color = control.BackColor.ToString();
            //control.BackColor = Color.FromArgb(rnd.Next(200, 256), rnd.Next(256), rnd.Next(256), rnd.Next(256));

            KnownColor randomColorName = names[rnd.Next(names.Length)];
            control.BackColor = Color.FromKnownColor(randomColorName);

            return control.BackColor;
        }




        private void btnToplamaYap_Click_1(object sender, EventArgs e)
        {
            int calc = calcSum(20, 10);
            MessageBox.Show(calc.ToString());
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // if number is even = -1, if odd = 1 if 0 = 0;
            int answer = EvenOdd(int.Parse(txtOrnekIki.Text));
            MessageBox.Show(answer.ToString());


        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            string mail = textedit(txtOrnekIki.Text);
            MessageBox.Show(mail);

        }

        private void btnDiziIsleme_Click(object sender, EventArgs e)
        {
            string[] n = textBox1.Text.Split(',');
            int[] numbers = { } ;
            
            for (int i = 0; i < n.Length; i++)
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[i] = int.Parse(n[i]);
            }
            
            double result = SqrRoot(numbers);
            MessageBox.Show(result.ToString());

        }

        private void btnRenkYakalayici_Click(object sender, EventArgs e)
        {

           string color = Ctrl(btnRenkYakalayici).ToString();
            MessageBox.Show(color);
            
        }
    }
}
