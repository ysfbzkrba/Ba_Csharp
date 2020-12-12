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
    public partial class Form2 : Form
    {

        #region Variables
        //int _sum;



        #endregion

        public Form2()
        {
            InitializeComponent();
        }

        #region Methods

        //void Calc(int n1,int n2)
        //{
        //    int sum = n1 + n2;
        //    _sum = sum;
        //}

        void Calc(int n1, int n2, out int result)
        {
            int sum = n1 + n2;
            result = sum;
        }
        int Oper(int n1, int n2, out int subr, out int prodr, out double divr, out int modr)
        {
            int sum = n1 + n2;
             subr = n1 - n2;
             prodr = n1 * n2;
             divr = Convert.ToDouble(n1) / Convert.ToDouble(n2);
             modr = n1 % n2;
            return sum;

            
        }
        #endregion


        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            int sumr;
            Calc(10,20,out sumr);
            MessageBox.Show(sumr.ToString());
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            
           int sum = Oper(10, 20, out int sub, out int prod, out double div, out int mod);

            MessageBox.Show("the sum is : "          +   sum.ToString()  +
                            "\nthe subtraction is :" +   sub.ToString()  + 
                            "\nthe production is :"  +   prod.ToString() + 
                            "\nthe division is :"    +   div.ToString()  + 
                            "\nthe mod is :"         +   mod.ToString()   );
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {

        }

        private void btnKopya_Click(object sender, EventArgs e)
        {

        }
    }
}
