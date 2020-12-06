using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_array_lab
{
    public partial class AddtoListForm : Form
    {

        string[] kayitlar = new string[0];
        int lenght = 0;

        public AddtoListForm()
        {
            InitializeComponent();
        }

        private void AddtoListForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                string metin = textBox1.Text;
                int length = kayitlar.Length;
                Array.Resize(ref kayitlar, kayitlar.Length + 1);

                kayitlar[length - 1] = metin;
                listBox1.Items.Add($"{metin} - {length + 1}");
            
        }
    }
}
