using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_GenericTypes_14.Models;
using WLA_Helpers.Clear;




namespace WFA_GenericTypes_14
{
    public partial class Form1 : Form
    {
        //GenericType = T LoadClass<T>(Type entity)
        T LoadClass<T>(Type entity) // where T : class \\ ==> accepts only class type
        {
            var retVal = Activator.CreateInstance(entity);

            foreach (System.Reflection.PropertyInfo property in retVal.GetType().GetProperties())
            {
                Control[] controls = this.Controls.Find(property.Name, true);
                if (controls.Length>0)
                {
                    #region ÖRnek
                    //var value = controls[0].Text;
                    //property.SetValue(retVal, value);

                    //StringClear clear = new StringClear(); 
                    //string text = clear.Mail(value); 
                    //property.SetValue(retVal, text);

                    //StringClear clear = new StringClear();
                    //string text = clear.Mail(value);

                    //string text = StringClear.Mail(value);
                    //property.SetValue(retVal, text);

                    // property.SetValue(retVal, StringClear.ClearText(value));

                    //string t = Convert.ToString(123);
                    //string g = 1234.ToString();

                    //int res = 10.ClearText();
                    //MessageBox.Show(res.ToString()); 
                    #endregion

                    var value = controls[0].Text;
                    string text = StringClear.Mail(value);
                    property.SetValue(retVal, text);
                }
            }
            // var a = LoadClass<int>(typeof(int));
            return (T)retVal;
        }
        void LoadControl<T>(T entity)
        {
            foreach (System.Reflection.PropertyInfo info in entity.GetType().GetProperties())
            {
                Control ctrl = this.Controls.Find(info.Name, true)[0];
                ctrl.Text = info.GetValue(entity).ToString();
            }
        }

        #region Orn1
        /// <summary>
        /// Creates a new Category instance
        /// </summary>
        /// <returns></returns>
        Category ReturnCategory()
        {
            var category = new Category();
            category.CategoryName = CategoryName.Text;
            category.Description = Description.Text;
            return category;
        }
        /// <summary>
        /// Creates a new Shipper instance
        /// </summary>
        /// <returns></returns>
        Shipper ReturnShipper()
        {
            var shipper = new Shipper();
            shipper.CompanyName = CompanyName.Text;
            shipper.Phone = Phone.Text;
            return shipper;
        }

        /// <summary>
        /// Creates a new category with given object value
        /// </summary>
        /// <param name="value"></param>
        void ReturnCategory(object value)
        {
            Category category = (Category)value;
            CategoryName.Text = category.CategoryName;
            Description.Text = category.Description;
        }
        /// <summary>
        /// Creates a new shipper with given object value
        /// </summary>
        /// <param name="value"></param>
        void ReturnShipper(object value)
        {
            Shipper shipper = (Shipper)value;
            CompanyName.Text = shipper.CompanyName;
            Phone.Text = shipper.Phone;
        }
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = LoadClass<Category>(typeof(Category));
            listBox1.Items.Add(category);
            this.ClearForm();
        }

        private void btnShipperSave_Click(object sender, EventArgs e)
        {
            var shipper = LoadClass<Shipper>(typeof(Shipper));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadControl(listBox1.SelectedItem);
            #region Örnek 1
            //var item = listBox1.SelectedItem;

            //switch (item)
            //{
            //    case Category c when item is Category:
            //        {
            //            CategoryName.Text = c.CategoryName;
            //            Description.Text = c.Description;
            //            break;
            //        }

            //    case Shipper s when item is Shipper:
            //        {
            //            CompanyName.Text = s.CompanyName;
            //            Phone.Text = s.Phone;
            //            break;
            //        }
            //    default:
            //        break;
            //}



            //if (item is Category)
            //{
            //    Category c = (Category)item;
            //    CategoryName.Text = c.CategoryName;
            //    Description.Text = c.Description;
            //}
            //else if (item is Shipper shipper)
            //{
            //    CompanyName.Text = shipper.CompanyName;
            //    Phone.Text = shipper.Phone;
            //}


            //if (item is Category)
            //{
            //    ReturnCategory(item);
            //}
            //else if (item is Shipper)
            //{
            //    ReturnShipper(item);
            //} 
            #endregion
        }
    }
}





// https://www.youtube.com/watch?v=b5qYJcLL-XA
// https://github.com/Teknolot/dotnetconf-2020-demo

// https://www.youtube.com/watch?v=_yvY2wQ6NJY
// https://www.youtube.com/watch?v=2m9nUP-e8Co
