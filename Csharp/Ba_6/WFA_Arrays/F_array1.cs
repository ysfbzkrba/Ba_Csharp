using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Arrays
{
    public partial class Arrays : Form
    {
        #region Variables
        string[] cars = { "Mercedes", "Ferrari", "Bugatti", "Audi", "Tofaş", "Toyota", "Ford" };
        Random rnd = new Random();
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;
        int address = 0;
        #endregion


        public Arrays()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string lastItem = cars[cars.Length - 1];
            MessageBox.Show(lastItem);
        }   // array[array.length -1];

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cars[rnd.Next(cars.Length)]);
        }   // array[array[random(array.length)]]

        private void btn3_Click(object sender, EventArgs e)
        {
            //lBx1.Items.Add("metin");


            if (address < numbers.Length)
            {

                lBx1.Items.Add(numbers[address]);   //
                sum += numbers[address];      // 
                textBox1.Text = sum.ToString();
                address++;
            }
            else 
            {
                address = 0;
                sum = 0;
            }
            
        }   //  listbox.items.add(array[index]); type += array[index];
    }
}
