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
    public partial class Form3 : Form
    {

        Random rnd = new Random();
        char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        public Form3()
        {
            InitializeComponent();
        }

        #region VoidFunctions

        void Counter(int n)
        {
            //for (int i = 1; i < n; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            foreach (int i in Enumerable.Range(1, n))
            {
                listBox1.Items.Add(i);
            }
        }   // foreach Enumerable.Range(value, tovalue)
        void Cubed(int x, int y)
        {
            //int cube = (x + y) * (x + y) * (x + y);

            int sum = x + y;
            double cube = Math.Pow(sum, 3);

            listBox1.Items.Add(cube);
        }   // Math.Pow(value, powvalue);
        void Scissor(string text)
        {
            //if (text.Length > 3)
            //{
            //    //string answer = text.Remove(0,text.Length - 3);
            //    string answer = text.Substring(text.Length - 3);
            //    listBox1.Items.Add(answer);
            //}
            //else listBox1.Items.Add(text);


            //switch (text.Length)
            //{
            //    case int l when l > 3:
            //        text = text.Substring(text.Length - 3);
            //        break;
            //}
            //listBox1.Items.Add(text);

            MessageBox.Show(text.Length > 3 ? text.Substring(text.Length - 3) : text);

            #region .NET CORE 5.0 C#9
            // .net core 5.0 C#9
            //text = text.Length switch
            //{
            //    > 3 => text.Substring(text.Length -3),
            //    _=> text
            //} 
            #endregion

        }   // .net core 5 c#9
        void MailDigestor(string mail)
        {
           string[] digest = mail.Replace(" ","").Split(';', ',', '+');
            for (int i = 0; i < digest.Length; i++)
            {
                listBox1.Items.Add(digest[i]);
            }
        }   //



        void Vowels (string text)
        {
            

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text.ToLower().ToCharArray()[i]))
                {
                    listBox1.Items.Add(text.ToCharArray()[i]);
                } else listBox2.Items.Add(text.ToCharArray()[i]);
            }

        }   // String.ToCharArray()
        void Vowels1(string text)
        {
            char[] chars = text.ToLower().ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
            char char1 = chars[i];
                switch (char1)
                {
                    case char c when c == 'a' || c == 'e' || c == 'ı' || c == 'i' || c == 'o' || c == 'ö' || c == 'u' || c == 'ü':
                        {
                            listBox1.Items.Add(char1);
                            break;
                        }
                    default:
                        listBox2.Items.Add(char1);
                        break;
                }
            }

        }   // switch case vowels
        void Vowels2(string text)
        {
            foreach (char character in txtDeger1.Text.ToCharArray())
            {
                #region Array.IndexOf
                //if (Array.IndexOf(vowels, character) > -1)
                //{
                //    listBox1.Items.Add(character);
                //}
                //else
                //{
                //    listBox2.Items.Add(character);
                //}
                #endregion

                #region Array.Exists
                //if (Array.Exists(vowels, x => x == character))
                //{
                //    listBox1.Items.Add(character);
                //}
                //else
                //{
                //    listBox2.Items.Add(character);
                //} 
                #endregion

                ListBox lst = Array.Exists(vowels, x => x == character) ? listBox1 : listBox2;
                lst.Items.Add(character);

            }
        }   //  foreach

        void ColorChange (string color)
        {
            this.BackColor = Color.FromName(color);
        }


        #endregion
        // VARIABLES SET    //

        private void Form3_Load(object sender, EventArgs e)
        {

            
        }
        //  FORMLOAD    INITIATED    //


        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Counter(int.Parse(txtDeger1.Text));
        }   // Counter Button

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Cubed(int.Parse(txtDeger1.Text), Convert.ToInt32(txtDeger2.Text));
        }   // Cubed Button

        private void btnKirp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Scissor(txtDeger1.Text);
        }   // Scissors Button

        private void btnListBoxaDoldur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MailDigestor(txtDeger1.Text);

        }   // Mail Digestor Button

        private void btnSesliKontrolu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Vowels(txtDeger1.Text);
            Vowels1(txtDeger1.Text);

            MessageBox.Show($"Total number of vowels in string is : {listBox1.Items.Count}\nTotal number of consonants in string is : {listBox2.Items.Count}");
        } // vowels and consonants

        private void btnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            ColorChange(cmbRenkler.SelectedItem.ToString());
        }
    }
}
