using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_Slider
{
    public partial class Form1 : MetroForm
    {

        Random rnd = new Random();
        int index = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }else
            {
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            index = rnd.Next(imageList.Images.Count); // listenin içerisindeki resimlerin adedini teslim alıyoruz.. 
            pcbImage.Image = imageList.Images[index];
        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = trackBar.Value;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbImage.Image = imageList.Images[0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbImage.Image = imageList.Images[imageList.Images.Count - 1];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index--;
            if (index == -1)
            {
                index = imageList.Images.Count - 1;
            }
            pcbImage.Image = imageList.Images[index];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            index++;
            if (index == imageList.Images.Count)
            {
                index = 0;
            }
            pcbImage.Image = imageList.Images[index];
        }
    }
}
