using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Enum_11.Models;

namespace WFA_Enum_11
{
    public partial class Enumerables : Form
    {
        public Enumerables()
        {
            InitializeComponent();
        }

        private void Enumerables_Load(object sender, EventArgs e)
        {
            Araba car = new Araba();


            car.Color       =    Models.Color.black;
            car.DoorCount   =    DoorCount.Two;
            car.Engine      =    Engine.e_2jz;
            car.Rims        =    Rims.Chrome;


        }
    }
}
