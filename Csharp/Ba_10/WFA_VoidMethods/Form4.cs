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
    public partial class Form4 : Form
    {


        public Form4()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Creates a mail address by user name and last name
        /// </summary>
        /// <param name="firstName">Enter users name</param>
        /// <param name="lastName">Enter users last name</param>
        /// <param name="domain">Enter domain</param>
        void Mail(string firstName, string lastName, string domain) // string domain = "hotmail.com" is possible and sets the default value for domain.
        {
            string mail = $"{firstName}.{lastName}@{domain}";
            MessageBox.Show(mail);
        }


        /// <summary>
        /// Creates a hotmail.com address by user name and last name
        /// </summary>
        /// <param name="name">Enter users name</param>
        /// <param name="lastname">Enter users last name</param>
        void Mail(string name, string lastname)
        {
            string mail = $"{name}.{lastname}@hotmail.com";
            MessageBox.Show(mail);
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (cmbSunucuAdlari.SelectedIndex==-1)
            {
                Mail(txtAdi.Text, txtSoyadi.Text);
            }
            else
            {
                Mail(txtAdi.Text, txtSoyadi.Text, cmbSunucuAdlari.Text);
            }

            txtAdi.Clear();
            txtSoyadi.Clear();
            txtAdi.Focus();
            cmbSunucuAdlari.SelectedIndex = -1; // -1 == unselect since index numbers start from 0.
        }


    }
}
