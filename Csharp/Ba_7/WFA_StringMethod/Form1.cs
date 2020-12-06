using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_StringMethod
{
    public partial class Form1 : Form
    {

        string ornekMetin = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCOMPARETO_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani2.Text;
            int result = ornekMetin.CompareTo(txtGirisAlani1.Text); // dictionary sort
            string mesaj = "";
            switch (result)
            {
                case -1:
                    {
                        mesaj = "girilen metin, diğer metinden öndedir.";
                        break;
                    }
                case 0:
                    {
                        mesaj = "girilen metin, diğer metinle eşittir.";
                        break;
                    }
                case 1:
                    {
                        mesaj = "girilen metin, diğer metinden sonradır.";
                        break;
                    }

            }
            MessageBox.Show(mesaj);
        }

        private void btnCONTAINS_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            bool result = ornekMetin.Contains(txtGirisAlani2.Text);
            MessageBox.Show($"aradığınız \"{txtGirisAlani2.Text}\" değeri, \"{ornekMetin}\" içerisinde geçme{(result ? "" : "me")}ktedir.", "kullanıcı bilgilendirme alanı", MessageBoxButtons.OK, result ? MessageBoxIcon.Information: MessageBoxIcon.Error);
        
        
        }

        private void btnSTARTSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            bool result = ornekMetin.StartsWith(txtGirisAlani2.Text);
            MessageBox.Show($"\"{ornekMetin}\" değeri, \"{txtGirisAlani2.Text}\" ile başlama{(result ? "" : "ma")}ktadır.", "kullanıcı bilgilendirme alanı", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);


        }

        private void btnENDSWITH_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            bool result = ornekMetin.EndsWith(txtGirisAlani2.Text);
            MessageBox.Show($"\"{ornekMetin}\" değeri, \"{txtGirisAlani2.Text}\" ile bitme{(result ? "" : "me")}ktedir.", "kullanıcı bilgilendirme alanı", MessageBoxButtons.OK, result ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        }

        private void btnINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            int result = ornekMetin.IndexOf('a');
            MessageBox.Show(result != -1 ? $"dizi içerisinde aradığınız elemanın index değeri {result}": "dizi içerisinde aradığınız değer yer almamaktadır.", "kullanıcı bilgilendirme alanı");

        }

        private void btnLASTINDEXOF_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            int result = ornekMetin.LastIndexOf('a');
            MessageBox.Show(result != -1 ? $"dizi içerisinde aradığınız elemanın index değeri {result}" : "dizi içerisinde aradığınız değer yer almamaktadır.");
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            ornekMetin = ornekMetin.Remove(5);
            MessageBox.Show(ornekMetin);

            ornekMetin = txtGirisAlani1.Text;
            ornekMetin = ornekMetin.Remove(5, 2);
            MessageBox.Show(ornekMetin);
        }

        private void btnREPLACE_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            ornekMetin = ornekMetin.Replace("ı", "i").Replace("ö","o").Replace("ü", "u").Replace("ç", "c").Replace("ş", "s").Replace("ğ", "g").Replace("İ", "I").Replace("Ç", "C").Replace("Ş", "S").Replace("Ğ", "G").Replace("Ü", "U").Replace("Ö", "O");
            MessageBox.Show(ornekMetin);

        } 

        private void btnSPLIT_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            string[] altmetinler = ornekMetin.Split(',');//virgülden böler string type array atar.

            string[] altmetinler2 = ornekMetin.Split('+', '-', '?', ',', '.', ';','/');
            MessageBox.Show(altmetinler[0]+"  "+altmetinler[1]);


        }//1den fazla karakter için??

        private void btnINSERT_Click(object sender, EventArgs e)
        {

        }

        private void btnTOLOWERTOUPPER_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            ornekMetin = ornekMetin.ToLower();
            MessageBox.Show(ornekMetin);
            ornekMetin = ornekMetin.ToUpper();
            MessageBox.Show(ornekMetin);
        }

        private void btnSUBSTRING_Click(object sender, EventArgs e)
        {
            ornekMetin = txtGirisAlani1.Text;
            string mesaj = "";
            ornekMetin = ornekMetin.Substring(0, 5);// bilge adam => bilge 0dan 5e
            mesaj = "substring => " + ornekMetin;
            ornekMetin = txtGirisAlani1.Text;
            ornekMetin = ornekMetin.Remove(0,5);
            mesaj += "\nRemove => " + ornekMetin;
            MessageBox.Show(mesaj);
        }

        private void btnTOCHARARRAY_Click(object sender, EventArgs e)
        {
           char[] karakterler = txtGirisAlani1.Text.ToCharArray();
            string quote = "";
            for (int i = 0; i < karakterler.Length; i++)
            {
                quote += "'" + karakterler[i] + "', ";
            }
            MessageBox.Show(quote);

        } 

        private void btnTRIM_Click(object sender, EventArgs e)
        {
            ornekMetin = "@@yusuf.bozkir@hotmail.com@@";
            string s1 = txtGirisAlani1.Text.Trim('@');
            string s2 = txtGirisAlani1.Text.TrimStart('@');
            string s3 = txtGirisAlani1.Text.TrimEnd('@');
            string s4 = txtGirisAlani1.Text.Replace("@", "");

            string answer = @"
            TrimStart   =>  {0}
            TrimEnd     =>  {1}
            Trim        =>  {2}
            Replace     =>  {3}
               ";
            MessageBox.Show(string.Format(answer, s1, s2, s3, s4));
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            char[] characters = txtGirisAlani1.Text.Replace(" ","").ToCharArray();

            char[] karakterler = txtGirisAlani1.Text.ToCharArray().Where(x => !char.IsWhiteSpace(x)).ToArray();

            string text = string.Join("-", characters) + "\n"+string.Join("-", characters) ;
            MessageBox.Show(text);

        }
    }
}
