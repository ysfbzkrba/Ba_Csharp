using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ForEach
{
    public partial class Form1 : Form
    {

        #region Variables
        string[] sehirler = {
"Adana",
"Adıyaman",
"Afyonkarahis",
"Ağrı",
"Aksaray",
"Amasya",
"Ankara",
"Antalya",
"Ardahan",
"Artvin",
"Aydın",
"Balıkesir",
"Bartın",
"Batman",
"Bayburt",
"Bilecik",
"Bingöl",
"Bitlis",
"Bolu",
"Burdur",
"Bursa",
"Çanakkale",
"Çankırı",
"Çorum",
"Denizli",
"Diyarbakır",
"Düzce",
"Edirne",
"Elazığ",
"Erzincan",
"Erzurum",
"Eskişehir",
"Gaziantep",
"Giresun",
"Gümüşhane",
"Hakkâri",
"Hatay",
"Iğdır",
"Isparta",
"İstanbul",
"İzmir",
"Kahramanmara",
"Karabük",
"Karaman",
"Kars",
"Kastamonu",
"Kayseri",
"Kırıkkale",
"Kırklareli",
"Kırşehir",
"Kilis",
"Kocaeli",
"Konya",
"Kütahya",
"Malatya",
"Manisa",
"Mardin",
"Mersin",
"Muğla",
"Muş",
"Nevşehir",
"Niğde",
"Ordu",
"Osmaniye",
"Rize",
"Sakarya",
"Samsun",
"Siirt",
"Sinop",
"Sivas",
"Şanlıurfa",
"Şırnak",
"Tekirdağ",
"Tokat",
"Trabzon",
"Tunceli",
"Uşak",
"Van",
"Yalova",
"Yozgat",
"Zonguldak" };

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    string sehir = sehirler[i];
            //    listBox1.Items.Add(sehir);
            //}


            //int i = 0;
            //while (i< sehirler.Length)
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //    i++;
            //}


            //int i = 0;
            //do
            //{
            //    listBox1.Items.Add(sehirler[i]);
            //    i++;

            //} while (i<sehirler.Length);

            foreach (string sehir in sehirler)
            {
                listBox1.Items.Add(sehir);
            }


        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.Tomato;
                }
                
            }


        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 6, 7, 12, 9, 18 };
            int[] count = new int[0];
            int sum = 0;

            foreach (int n in numbers)
            {

                if (n % 2 == 0 && n % 3 == 0)
                {
                    sum++;
                    Array.Resize(ref count, count.Length + 1);
                    count[count.Length - 1] = n;
                }
                if (n % 2 == 0)
                {
                    listBox1.Items.Add(n);
                }
                else listBox2.Items.Add(n);
            }
            MessageBox.Show("The numbers :" + string.Join("-",count) + " can be divided by both 2 and 3.");
            MessageBox.Show("there are " + sum + " numbers that can be divided by bot 2 and 3.");
        }




        // Move selected items from one ListBox to another.
        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (var city in listBox1.SelectedItems)
            {
                listBox2.Items.Add(city);
                //listBox2.Items.Remove(city);
            }
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Remove(item);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (var city in listBox2.SelectedItems)
            {
                listBox1.Items.Add(city);
                //listBox2.Items.Remove(city);
            }
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Remove(item);
            }
        }
    }
}
