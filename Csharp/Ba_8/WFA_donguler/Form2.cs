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
    public partial class Form2 : Form
    {
        #region Variables

        int[] numbers = { 1, 4, 3, 5, 7, 9, 2, 123, 4, 6, 8, 90, 55, 33, 22 };
        Random rnd = new Random();
        int index = 0;

        #endregion

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   // Application.Exit()

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            string[] teams = { "beşiktaş", "fenerbahçe", "galatasaray", "trabzonspor", "ankaragücü", "süvasspor" };

            if (index < teams.Length)
            {
                string team = teams[index];
                listBox1.Items.Add(team);
                index++;
            }
            else
            {
                listBox1.Items.Clear();
                index = 0;
            }

        }   // adds items one by one from array to listbox 

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            // declare a numerical array.  pick the largest and smallest numbers accordingly into messagebox without using the array class

           
            int smallest = int.MaxValue, largest = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (largest < number) 
                {
                    largest = number;
                }
                if (smallest > number) 
                {
                    smallest = number; 
                }
            }
            MessageBox.Show($"largest number in array : {largest}\nsmallest number in array : {smallest}");
        }   //int.MinValue() , int.MaxValue() give largest and smallest values in array

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //declare a numarical array and msgboxshow total odds and evens
            int odd = 0; int even = 0 ;
            string odds = "odd numbers are : ", evens = "even numbers are : ";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even++;
                    evens +="'" + numbers[i].ToString() + "', ";
                }
                else
                {
                    odd++;
                    odds += "'" + numbers[i].ToString() + "', ";
                }

            }
            MessageBox.Show($"sum of odd numbers :{odd}\nsum of even numbers : {even}\n{odds}\n{evens}");
        }   //gives odds and evens with count of each.

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //revers the text in textbox
            string name = "bilge adam";
            string newname = "";
            for (int i = name.Length - 1 ; i >=0 ; i--)
            {
                newname += name[i];
            }
            MessageBox.Show(newname);

        }   // name.Length - 1 to 0  =  STRING.REVERSE() 

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next());
            }
        }   //add 10 random numbers into list

      
        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //change button colors ass you wish
              for (int i = 0; i < this.Controls.Count; i++)
              {
                  Control ctrl = this.Controls[i];
                //    if (ctrl is Button)
                //    {
                //        ctrl.BackColor = Color.Tomato;
                //    }

                //    switch (ctrl)
                //    {
                //        case Control c when c is Button:
                //            ctrl.BackColor = Color.Tomato;
                //            break;
                //    }
                ctrl.BackColor = (ctrl is Button) ? Color.FromArgb(rnd.Next(200,256), rnd.Next(256), rnd.Next(256), rnd.Next(256)) : default;
              }

        }   // randomize button colors ==> control ctrl = this.controls[i]  Color.FromArgb(alpha, red, green, blue)


        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //take numbers from text box and put out sum of integers. 123 = 1+2+3 = 6

            int sum = 0;
            for (int i = 0; i < txtGirisAlani.TextLength; i++)
            {
                sum += Convert.ToInt32(txtGirisAlani.Text[i].ToString());
            }
            MessageBox.Show("Sum of value : " + sum);
        }   // sum += Convert.ToInt32(txtGirisAlani.Text[i].ToString())


    }
}
