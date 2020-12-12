using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_VoidMethods
{
    public partial class Form2 : Form
    {
        
        Random rnd = new Random();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        void Counter()
        {
            for (int i = 1; i < 1000; i++)
            {
                listBox1.Items.Add(i);
            }
        }


        void Repair()
        {
            this.BackColor = Color.FromArgb(rnd.Next(200,256),rnd.Next(256),rnd.Next(256));
            this.Size = new System.Drawing.Size(rnd.Next(500, 1280), rnd.Next(350, 720)); //can also be size=new size();
        }


        private void btn_Counter_Click(object sender, EventArgs e)
        {
            Counter();
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //change forms background color and size.
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Repair();

        }


    }
}
