using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ArrayPractice
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int index = 0;
        string[] records = new string[0];

        public Form1()
        {
            InitializeComponent();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            // create a numbers array and project largest and smallest numbers on to messagebox.

            int[] numbers = { rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256) };
            string sequence = numbers[0].ToString() + ", "+ numbers[1].ToString() + ", "+ numbers[2].ToString() + ", "+ numbers[3].ToString();

            int nmax = numbers.Max();
            int nmin = numbers.Min();
            MessageBox.Show("The generated sequence is : "+ sequence +".\nThe largest number in array is : " + nmax + ".\nThe smallest number in array is : " + nmin);
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //  add the value in textbox to a string array. resize the length of array with each new value. project the newly added item into listbox with its index number.


            string text = txtB1.Text;
            int length = records.Length;
            Array.Resize(ref records, length + 1);
            records[length - 1] = text;
            lstElemanlar.Items.Add($"{text} -   {length - 1}");
        }
    }
}
