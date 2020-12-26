using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Classes_2.Models;

namespace WFA_Classes_2
{
    public partial class FormEmployees : Form
    {
        Employee edit;
        int index=-1;
        void Clear()
        {
            foreach (Control ctrl in gB_addemp.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Text = "";
                }
                dtBirth.Value = DateTime.Now;
            }
        }


        public FormEmployees()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employ = new Employee();

            employ.FirstName = txtName.Text;
            employ.LastName = txtLName.Text;
            employ.Phone = txtPhone.Text;
            employ.Mail = txtMail.Text;
            employ.Birth = dtBirth.Value;

            lBoxEmp.Items.Add(employ);
            
        }   //add new item to list

        private void lBoxEmp_DoubleClick(object sender, EventArgs e)
        {
            Clear();
            if (lBoxEmp.SelectedItem == null)
            {
                MessageBox.Show("pls select a value first!");
                return;
            }

            index = lBoxEmp.SelectedIndex;
            edit = (Employee)lBoxEmp.SelectedItem;

            txtName.Text = edit.FirstName;
            txtLName.Text = edit.LastName;
            txtPhone.Text = edit.Phone;
            txtMail.Text = edit.Mail;
            dtBirth.Value = edit.Birth;
        
        }   // select item from list
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index >-1)
            {

                edit = (Employee)lBoxEmp.SelectedItem;
                edit.FirstName = txtName.Text;
                edit.LastName = txtLName.Text;
                edit.Phone = txtPhone.Text;
                edit.Mail = txtMail.Text;
                edit.Birth = dtBirth.Value;


                lBoxEmp.Items.RemoveAt(index);
                lBoxEmp.Items.Insert(index, edit);

            }
            else
            {
                MessageBox.Show("no item is selected.");
            }

            index = -1;
            Clear();

        }   // update selected item


        private void txtName_DoubleClick(object sender, EventArgs e)
        {
            txtName.Text = FakeData.NameData.GetFirstName();
            txtLName.Text = FakeData.NameData.GetSurname();
            txtMail.Text = FakeData.NetworkData.GetEmail();
            txtPhone.Text = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
            dtBirth.Value = FakeData.DateTimeData.GetDatetime();
        }   //generate random new values.


        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lBoxEmp.SelectedItem == null)
            {
                MessageBox.Show("Please select the item you want to delete.");
                return; // cancels click operation.
            }
            lBoxEmp.Items.Remove(lBoxEmp.SelectedItem);
        }   //right click menu delete item.
        private void tsmSelect_Click(object sender, EventArgs e)
        {
            Clear();
            if (lBoxEmp.SelectedItem == null)
            {
                MessageBox.Show("Can't select null object.");
                return; // cancels click operation.
            }

            index = lBoxEmp.SelectedIndex;
            edit = (Employee)lBoxEmp.SelectedItem;

            txtName.Text = edit.FirstName;
            txtLName.Text = edit.LastName;
            txtPhone.Text = edit.Phone;
            txtMail.Text = edit.Mail;
            dtBirth.Value = edit.Birth;

        }   //right click menu select item.

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            index = lBoxEmp.SelectedIndex;
            if (index > -1)
            {

                edit = (Employee)lBoxEmp.SelectedItem;
                edit.FirstName = txtName.Text;
                edit.LastName = txtLName.Text;
                edit.Phone = txtPhone.Text;
                edit.Mail = txtMail.Text;
                edit.Birth = dtBirth.Value;


                lBoxEmp.Items.RemoveAt(index);
                lBoxEmp.Items.Insert(index, edit);

            }
            else
            {
                MessageBox.Show("no item is selected.");
            }

            index = -1;
        }
    }
}
