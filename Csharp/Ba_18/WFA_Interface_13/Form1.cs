using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Interface_13.Models;

namespace WFA_Interface_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Forvette forvet = new Forvette()
            {
                Name = "sabri",
                LastName = "sarıoğlu",
                Team = "galatasaray",
                National = true,
                Number = "55",
                Aggro = 100,
                Pos = "unknown",
                Control = 0
            };
            GoalKeeper GK = new GoalKeeper()
            {
                Name = "Tafarel",
                LastName = "Tefal",
                Control = 100,
                Aggro = 0,
                HandGrab = 100,
                Pos = "Goal",
                Number = "01",
                National = false,
                Team = "galatasaray"
            };

            listBox1.Items.Add(forvet);
            listBox1.Items.Add(GK);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) 
            {
                return;
            }
            flowLayoutPanel1.Controls.Clear();


            #region FirstWay
            //if (listBox1.SelectedItem is GoalKeeper)
            //{
            //    GoalKeeper keeper = (GoalKeeper)listBox1.SelectedItem;

            //    Label lblName = new Label();
            //    lblName.Text = "Name : " + keeper.Name;
            //    lblName.Width = flowLayoutPanel1.Width;

            //    Label lblName = new Label();
            //    lblName.Text = "LastName : " + forvet.Name;
            //    lblName.Width = flowLayoutPanel1.Width;

            //    flowLayoutPanel1.Controls.Add(lblName);
            //    flowLayoutPanel1.Controls.Add(lblLastName);

            //}else if (listBox1.SelectedItem is Forvette)
            //{
            //    Forvette forvet = (Forvette)listBox1.SelectedItem;

            //    Label lblName = new Label();
            //    lblName.Text = "Name : " + forvet.Name;
            //    lblName.Width = flowLayoutPanel1.Width;

            //    Label lblName = new Label();
            //    lblName.Text = "LastName : " + forvet.Name;
            //    lblName.Width = flowLayoutPanel1.Width;

            //    flowLayoutPanel1.Controls.Add(lblName);
            //    flowLayoutPanel1.Controls.Add(lblLastName);
            //} 
            #endregion

            #region SecondWay
            //if (listBox1.SelectedItem is GoalKeeper)
            //{
            //    GoalKeeper gk = (GoalKeeper)listBox1.SelectedItem;
            //    foreach (var prop in gk.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = prop.Name + " : " + prop.GetValue(gk);
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}
            //else if (listBox1.SelectedItem is Forvette)
            //{
            //    Forvette forvet = (Forvette)listBox1.SelectedItem;
            //    foreach (var prop in forvet.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = prop.Name + " : " + prop.GetValue(forvet);
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //} 
            #endregion


            #region BestWay
            if (listBox1.SelectedItem.GetType().GetInterface("IFootballer") != null)
            {

                IFootballer footballer = (IFootballer)listBox1.SelectedItem;

                foreach (PropertyInfo prop in footballer.GetType().GetProperties())
                {
                    Label lblName = new Label();
                    lblName.Text = prop.Name + " : " + prop.GetValue(footballer);
                    lblName.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lblName);
                }
            } 
            #endregion




        }
    }
}
