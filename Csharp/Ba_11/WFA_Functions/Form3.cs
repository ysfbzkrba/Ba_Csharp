using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Functions
{
    public partial class Form3 : Form
    {

        void ClearForm(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                switch (ctrl)
                {
                    case Control c when c is TextBox:
                        {
                            TextBox txt = (TextBox)c;
                            txt.Clear();
                            break;
                        }
                    case Control c when c is NumericUpDown nmr:
                        {
                            nmr.Value = nmr.Minimum;
                            break;
                        }
                    case Control c when c is DateTimePicker dtp:
                        {
                            dtp.Value = DateTime.Today;
                            break;
                        }
                    case Control c when c is ComboBox cmb:
                        {
                            cmb.SelectedItem = default;
                            break;
                        }
                    case Control c when c is GroupBox grb:
                        {
                            ClearForm(grb);
                            break;
                        }
                    case Control c when c is Panel pnl:
                        {
                            ClearForm(pnl);
                            break;
                        }


                    default:
                        break;

                }
            }
        }





        public Form3()
        {
            InitializeComponent();
        }




        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ClearForm(this);
        }
    }
}
