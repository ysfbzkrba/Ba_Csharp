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
using System.Reflection;

namespace WFA_Enum_11
{
    public partial class Enum2 : Form
    {
 
        public Enum2()
        {
            InitializeComponent();
        }

        private void Enum2_Load(object sender, EventArgs e)
        {
            //foreach (string item in Enum.GetNames(typeof(Department)))
            //{
            //    cmbDepart.Items.Add(item);
            //}

            cmbDepart.Items.AddRange(Enum.GetNames(typeof(Department)));
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Personnel person = new Personnel();

            person.Name     = txtName.Text;
            person.Lname    = txtLName.Text;
            person.Phone    = txtPhone.Text;
            person.Mail     = txtMail.Text;
            person.department =(Department)Enum.Parse(typeof(Department),cmbDepart.Text);

            string mesaj = "";
            foreach (PropertyInfo property in person.GetType().GetProperties())
            {
                mesaj += $"{property.Name} : {property.GetValue(person)}\n";
            }
            MessageBox.Show(mesaj);
        }


    }
}
