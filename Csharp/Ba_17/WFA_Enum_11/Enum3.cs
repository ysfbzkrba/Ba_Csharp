using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Enum_11
{
    public partial class Enum3 : Form
    {


        string mesaj = "bu değermawmaw";
        public Enum3()
        {
            InitializeComponent();
        }



        enum Status
        {
            none    = 0,
            active  = 1,
            deleted = 2,
            updated = 3
        }

        enum cities
        {
     // enum values      index values
            Ankara,        //   0
            Edirne,        //   1
            Istanbul,      //   2
            Sivas,         //   3
            Malatya,       //   4
            Adana,         //   5
            Tokyo,         //   6
            New_York       //   7
        }                  


        private void Enum3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            int city_index = int.Parse(textBox1.Text);
            byte cities_index = byte.Parse(textBox1.Text);
            if (Enum.IsDefined(typeof(cities), cities_index)) 
            {
                MessageBox.Show(Enum.GetName(typeof(cities), cities_index));
            }
            else
            {
                textBox1.Text = mesaj;
            }
            


        }
    }
}
