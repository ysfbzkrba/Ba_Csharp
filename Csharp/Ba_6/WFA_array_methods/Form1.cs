using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_array_methods
{
    public partial class Form1 : Form
    {
        string[] sehirler = { 
           // Eleman değeri    index no       eleman no
            "ankara",          // 0            1
            "edirne",          // 1            2
            "eskişehir",       // 2            3
            "bursa",           // 3            4
            "denizli",         // 4            5
            "kastamonu",       // 5            6
            "eskişehir",       // 6            7
            "artvin",          // 7            8
            "malatya",         // 8            9
            "süvas"            // 9            10
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmBsehirler.Items.AddRange(sehirler); // .AddRange
        }       // listbox.Items.AddRange(array); ==> adds array to the listbox

        private void button1_Click(object sender, EventArgs e)
        {
            // Array.Clear() => (  array, int index, int lenght  )
            Array.Clear(sehirler, 0, 5);
            //array clear all
            Array.Clear(sehirler, 0, sehirler.Length);
        }   // .clear(array, index, length)

        private void button2_Click(object sender, EventArgs e)
        {
            string[] cities = new string[5];
            Array.Copy(sehirler, cities, sehirler.Length); // wont work if you did't click button1 first. sehirler[10] => cities[5] wont fit.



            string[] nCities = new string[5];
            Array.Copy(sehirler, 2, nCities, 2,3);
            // mainindex, fromwichaddress, newindex, towhatindex, howmanyitems //

        }   // .copy(array, indexnumber, newarray, toindex, howmanyitems)

        private void button3_Click(object sender, EventArgs e)
        {

            string sehir = "eskişehir";

            int index = Array.IndexOf(sehirler, sehir);
            MessageBox.Show($"dizi içerisinde aradığınız elemanın index numarası : {index}");
            //MessageBox.Show("dizi içerisinde aradığınız elemanın index numarası : " + index);
            //MessageBox.Show(string.Format("dizi içerisinde aradığınız elemanın index numarası {0}" + index));


            // string[] quote = { "bulunmaktadır.", "bulunmamaktadır." };
            // MessageBox.Show(string.Format("dizi içerisinde aradığınız {0} değeri dizi içerisinde {1}" + sehirler[index] + quote[0]));

            MessageBox.Show($"dizi içerisinde aradığınız \"{sehir}\" değeri dizi içerisinde geçme{(index > -1 ? "" : "me")}ktedir.");


        }   //.indexof(array, string); ==> returns "string" s first occurance address in array. from 0 to strings address. -1 == not found.

        private void button4_Click(object sender, EventArgs e)
        {
            string sehir = cmBsehirler.Text;
            int index = Array.LastIndexOf(sehirler, sehir);
            //MessageBox.Show(index.ToString());
            //MessageBox.Show($"dizi içerisinde aradığınız \"{sehir}\" değeri dizi içerisinde geçme{(index > -1 ? "":"me")}ktedir.");

            //x elemanı dizi içerisinde birden fazla geçmektedir.
            //x elemanı dizi içerisinde birden fazla geçmemektedir.
            MessageBox.Show($"{sehir} elemanı, dizi içerisinde birden fazla geçme{(Array.IndexOf(sehirler,sehir) == Array.LastIndexOf(sehirler,sehir) ? "":"me")}ktedir.");
        }   // .LastIndexOf(array, index); 

        private void button5_Click(object sender, EventArgs e)
        {
            Array.Resize(ref sehirler, 100);
        }   // .Resize("ref" array, length)

        private void button6_Click(object sender, EventArgs e)
        {
            //Array.Sort(sehirler); Adan Z ye sıralar

            Array.Sort(sehirler, 5,4); // 5.den itibaren 4 elemanı A dan Z ye sıralar.
        }   // .Sort(array, index, length)  alphabetic array of 4 items starting from 5th in array.

        private void button7_Click(object sender, EventArgs e)
        {
            Array.Reverse(sehirler);
        }   // .Reverse(array)

        private void button8_Click(object sender, EventArgs e)
        {
            string sehir = "eskişehir";
            //if (Array.IndexOf(sehirler) != -1)
            //{
            //    MessageBox.Show("dizi içerisinde geçmektedir");
            //}
            //else MessageBox.Show("dizi içerisinde geçmemektedir.");

            bool result = Array.Exists(sehirler, s => s == sehir); // sehirler s = sehirleri s ye kısalttık
            MessageBox.Show(
                $"dizi içerisinde yer alma{(result ? "":"ma")}ktadır", //messagebox 
                "Kullanıcı bildirim ekranı",    //messagebox title
                MessageBoxButtons.OK,   //messagebox buttons.
                (result ? MessageBoxIcon.Information : MessageBoxIcon.Error)); // message box title.
            
        }   //ternary (value ? if true : if false)
    }


    //
}
