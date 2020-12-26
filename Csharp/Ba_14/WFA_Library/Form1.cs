using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Library.Models;


namespace WFA_Library
{
    public partial class Form1 : Form
    {
        #region topbarmover
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion

        #region Variables
        Books edit;
        string[] genres = { "Horror", "Encyclopedia", "Biography", "Action", "Adventure", "Fantasy", "Detective", "Mistery", "Historical Fiction", "Literary Fiction", "Romance", "Sci-Fi", "Short", "Suspense", "Cooking", "Poetry", "True-Crime", "Memoir" };
        int[] ids=new int[0];
        Random rnd = new Random();
        int index = -1;
        int id;
        #endregion
        void Clear()
        {
            foreach (Control ctrl in grpCreate.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Text = "";
                }
                dtpPrintYear.Value = DateTime.Now;
            }
        }

        public Form1()
        {
            InitializeComponent();
        } //Forminit

        #region FormManagement

        private void Form1_Load(object sender, EventArgs e)
        {
                cmbGenres.Items.AddRange(genres);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            id = rnd.Next(1000, 10000);
            do
            {
                id = rnd.Next(1000, 10000);
            } while (ids.Contains(id));

            Array.Resize(ref ids, ids.Length + 1);
            ids[ids.Length-1] = id;



            Books book = new Books();

            book.Id = id;
            book.BName = txtBookName.Text;
            book.Auth = txtAuth.Text;
            book.PubCount = Convert.ToInt32(printUpDown.Value);
            book.PageCount = Convert.ToInt32(pageUpDown.Value);
            book.PublishDate = dtpPrintYear.Value;

            if (!string.IsNullOrEmpty(txtISBN.Text)&&txtISBN.Text.Replace("-", "").Replace(" ", "").Length==13)
            {
                book.isbn = double.Parse(txtISBN.Text.Replace("-","").Replace(" ",""));
                //string isbn = txtISBN.Text.Substring(0, 3) + " - " + txtISBN.Text.Substring(3, 1) + " - " + txtISBN.Text.Substring(4, 2) + " - " + txtISBN.Text.Substring(6, 6) + " - " + txtISBN.Text.Substring(13);
                book.isbntxt = txtISBN.Text.Substring(0, 3) + " - " + txtISBN.Text.Substring(3, 1) + " - " + txtISBN.Text.Substring(4, 2) + " - " + txtISBN.Text.Substring(6, 6) + " - " + txtISBN.Text.Substring(13);

                listBooks.Items.Add(book);
            }
            else
            {
                errorP1.SetError(txtISBN, "Please make sure the ISBN number is correct.");
            }

            



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Books book = new Books();

            edit.Id = id;
            edit.BName = txtBookName.Text;
            edit.Auth = txtAuth.Text;
            edit.PubCount = Convert.ToInt32(printUpDown.Value);
            edit.PageCount = Convert.ToInt32(pageUpDown.Value);
            edit.PublishDate = dtpPrintYear.Value;

            if (!string.IsNullOrEmpty(txtISBN.Text) && txtISBN.Text.Replace("-", "").Replace(" ", "").Length == 13)
            {
                edit.isbn = double.Parse(txtISBN.Text.Replace("-", "").Replace(" ", ""));
                //string isbn = txtISBN.Text.Substring(0, 3) + " - " + txtISBN.Text.Substring(3, 1) + " - " + txtISBN.Text.Substring(4, 2) + " - " + txtISBN.Text.Substring(6, 6) + " - " + txtISBN.Text.Substring(13);
                edit.isbntxt = txtISBN.Text.Substring(0, 3) + " - " + txtISBN.Text.Substring(3, 1) + " - " + txtISBN.Text.Substring(4, 2) + " - " + txtISBN.Text.Substring(6, 6) + " - " + txtISBN.Text.Substring(13);
                listBooks.Items.RemoveAt(listBooks.SelectedIndex);
                listBooks.Items.Insert(listBooks.SelectedIndex,edit);

            }
            else
            {
                errorP1.SetError(txtISBN, "Please make sure the ISBN number is correct.");
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region NumericOnly
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // && (e.KeyChar != '.')
            {
                e.Handled = true;
                //txtISBN.Text.Replace('*', e.KeyChar);
                //string.Format("{0:###-#-##-######-#}");
            }
            
            #endregion

        }
        private void txtISBN_KeyUp(object sender, KeyEventArgs e)
        {
            txtISBN.Text = txtISBN.Text.Replace("-", "").Replace(" ", "");
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            index = listBooks.SelectedIndex;

            if (index > -1)
            {
            //    id                  = edit.Id;
                txtBookName.Text    = edit.BName;
                txtAuth.Text        = edit.Auth;
                txtPub.Text         = edit.Publisher;
                printUpDown.Value   = edit.PubCount;
                pageUpDown.Value    = edit.PageCount;
                dtpPrintYear.Value  = edit.PublishDate;
                txtISBN.Text        = edit.isbntxt.Replace("-","");
            }
            else
            {
                MessageBox.Show("no item was selected.");
            }

            index = -1;
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select the item you want to delete first.");
                return; // cancels click operation.
            }
            listBooks.Items.Remove(listBooks.SelectedItem);
        }
    }
}
