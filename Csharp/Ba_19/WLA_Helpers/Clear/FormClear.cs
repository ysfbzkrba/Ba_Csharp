using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WLA_Helpers.Clear
{
    public static class FormClear
    {
        //public static void ClearForm(this Form form)
        public static void ClearForm(this Control form)
        {
            foreach (Control ctrl in form.Controls)
            {
                switch (ctrl)
                {
                    case TextBox c when c is TextBox:
                        {
                            c.Clear();
                            break;
                        }

                    case NumericUpDown n when n is NumericUpDown:
                        {
                            n.Value = n.Minimum;
                            break;
                        }

                    case GroupBox g when g is GroupBox:
                        {
                            ClearForm(g);
                            break;
                        }
                }
            }
        }
    }
}