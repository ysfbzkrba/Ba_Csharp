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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            // yan yana 5 adet X yazdırınız => X X X X X (label'a)
            //int n = int.Parse(textBox1.Text);

            int sideLength = 5;
            char[] x;
            for (int i = 1; i < sideLength; i++)
            {
                
            }

            //for (int row = 1; row <= sideLength; row++)
            //{

            //}
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // alt alta 5 adet X yazdırınız =>
            /*
            X
            X
            X
            X
            X
            */


            lblYaziAlani.Text = "X\nX\nX\nX\nX\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verilen değere göre Kare çizdiriniz.
            /*
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X
            X X X X X X X X X X

            */

            int sideLength = 5; //int.Parse(textBox1.Text);
            for (int row = 1; row <= sideLength; row++)
            {

                for (int col = 1; col <= sideLength; col++)
                {



                        
                }

            }
            lblYaziAlani.Text = "X ";
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            // X ile dik kenar üçgen çiziniz
            /*
            X
            X X
            X X X
            X X X X
            X X X X X
            X X X X X X
            X X X X X X X
            X X X X X X X X
            */

        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            // ListBox'a eklenecek

            // Çarpım Tablosu 1 ile 10 (dahil)
            // Format => 1 X 1 = 1
            // Format => 1 X 2 = 2
            // ------------------------
            // 10 X 10 = 100
            
            for (int i = 1; i <= 10; i++)
            {


                for (int n = 1; n <= 10; n++)
                {
                    string table = i.ToString() + " x " + n.ToString() + " = " + (i * n).ToString();
                    listBox1.Items.Add(table);
                    n = n++;
                }
                   

            }
            

            
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            /*
            X X X X X X X X X X X X X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X                       X
            X X X X X X X X X X X X X */

            // isteyen bu örnekleri console üzerinde yapabilir.
        }
    }
}