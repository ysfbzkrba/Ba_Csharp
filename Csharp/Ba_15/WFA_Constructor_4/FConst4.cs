using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFA_Constructor_4
{
    public partial class FConst4 : Form
    {
        bool state = false;
        FConst5 window = new FConst5();

        public FConst4()
        {
            InitializeComponent();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = tbRed.Value.ToString();
            //int r = tbRed.Value;
            //int g = tbGreen.Value;
            //int b = tbBlue.Value;

            ////Application.OpenForms.Cast<Form>().Last().BackColor = Color.FromArgb(r, g, b);
            //Application.OpenForms[1].BackColor = Color.FromArgb(r, g, b);
        }     
        // show red value

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = tbGreen.Value.ToString();
            //int r = tbRed.Value;
            //int g = tbGreen.Value;
            //int b = tbBlue.Value;

            ////Application.OpenForms.Cast<Form>().Last().BackColor = Color.FromArgb(r, g, b);
            //Application.OpenForms[1].BackColor = Color.FromArgb(r, g, b);
        }   
        // show green value

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = tbBlue.Value.ToString();
            //int r = tbRed.Value;
            //int g = tbGreen.Value;
            //int b = tbBlue.Value;

            ////Application.OpenForms.Cast<Form>().Last().BackColor = Color.FromArgb(r, g, b);
            //Application.OpenForms[1].BackColor = Color.FromArgb(r, g, b);
        }    
        // show blue value

        

        private void btnChangeBColor_Click(object sender, EventArgs e)
        {
            //FConst5 window = new FConst5(tbRed.Value,tbGreen.Value,tbBlue.Value);
            //window.Show();
            int r = tbRed.Value;
            int g = tbGreen.Value;
            int b = tbBlue.Value;

            //Application.OpenForms.Cast<Form>().Last().BackColor=Color.FromArgb(r,g,b);
            window.BackColor = Color.FromArgb(r, g, b);

        }
        //  change new windows color

        private void btnFinit_Click(object sender, EventArgs e)
        {
            if (!state)
            {
                window.Show();
                state = true;
            }else
            {
                window.Hide();
                state = false;
            }
        }   
        // show hide new window

        private void FConst4_Load(object sender, EventArgs e)
        {
            tbRed.Scroll += btnChangeBColor_Click;
            tbGreen.Scroll += btnChangeBColor_Click;
            tbBlue.Scroll += btnChangeBColor_Click;
        }
        // update new windows color with each trackbar scroll
    }
}
