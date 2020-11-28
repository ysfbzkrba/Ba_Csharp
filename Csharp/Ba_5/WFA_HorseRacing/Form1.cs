using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HorseRacing
{
    public partial class Hippodrome : Form
    {
        #region GlobalVariables
        bool IsSetup = false;
        int len = 1;
        int height = 1;
        int location = 460;
        Random rnd = new Random();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        #endregion

        public Hippodrome()
        {
            InitializeComponent();


        }

        private void Hippodrome_Load(object sender, EventArgs e)
        {

            //#region SoundPlayer
            ////this.Text = DateTime.Now.ToString(); // 
            //using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
            ////stack                                     heap  => ram parts.

            //{

                // Current Directory ==> S:\Files\SE\Csharp\Ba_5\WFA_HorseRacing\bin\Debug (where .exe file is kept)
                //
                player.SoundLocation = Environment.CurrentDirectory + @"\..\..\Content\music.wav"; //related path
                //  \.. => cd .. => upper directory.
                //player.SoundLocation = @"S:\Files\SE\Csharp\Ba_5\WFA_HorseRacing\Content\music.wav"; //direct path
                player.Play();

            //}

            //#endregion

            location = LblFinish.Location.Y;
            Horsey1.Visible = Horsey2.Visible = Horsey3.Visible = Start.Visible = label1.Visible = Restart.Visible = Reload.Visible = false;
            
        } // music

        private void T1_Tick(object sender, EventArgs e)
        {

            #region RandomGenerators
            int pos1 = rnd.Next(1, 11);
            int pos2 = rnd.Next(3, 9);
            int pos3 = rnd.Next(5, 7);
            #endregion

            #region Setup
            if (!IsSetup)
            {
                if (LaneLine1.Right < LblFinish.Left)
                {

                    LaneLine1.Width = len;
                    LaneLine2.Width = len;

                    len += 25;
                } // lane.length
                else
                {
                    Horsey1.Visible = Horsey2.Visible = Horsey3.Visible = Start.Visible = label1.Visible = Restart.Visible = Reload.Visible = true;
                }//visibility
                if (LblFinish.Height <= 420)
                {
                    LblFinish.Location = new System.Drawing.Point(LblFinish.Location.X, (location - height));
                    LblFinish.Height = height;
                    height += 10;
                }//finish.height
            }
            #endregion //race setup

            #region Winner&Run
            else if (Horsey1.Right > LblFinish.Left)
            {
                T1.Stop();
                MessageBox.Show("Horse1 wins!");
            } //horse1win
            else if (Horsey2.Right > LblFinish.Left)
            {
                T1.Stop();
                MessageBox.Show("Horse2 wins!");

            } //horse2win
            else if (Horsey3.Right > LblFinish.Left)
            {
                T1.Stop();
                MessageBox.Show("Horse3 wins!");

            } //horse3win
            else
            {
                Horsey1.Left += pos1;
                Horsey2.Left += pos2;
                Horsey3.Left += pos3;
            } // run 
            #endregion

            #region Pos
            if (Horsey1.Right > Horsey2.Right && Horsey1.Right > Horsey3.Right)
            {
                label1.Text = "Horse1 is going in front.!";

            }        //h1 is in front
            else if (Horsey2.Right > Horsey1.Right && Horsey2.Right > Horsey3.Right)
            {
                label1.Text = "Horse2 is going in front.!";

            }   //h2 is in front
            else if (Horsey3.Right > Horsey1.Right && Horsey3.Right > Horsey2.Right)
            {
                label1.Text = "Horse3 is going in front.!";
            }   //h3 is in front 
            #endregion

        }

        private void Start_Click(object sender, EventArgs e)
        {   
            IsSetup = true;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            IsSetup = false;
            Horsey1.Left = Horsey2.Left = Horsey3.Left = 0;
            label1.Text = "";
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            Horsey1.Left = Horsey2.Left = Horsey3.Left = 0;
            IsSetup = false;

            len = 1;
            height = 1;

            LaneLine1.Width = len;
            LaneLine2.Width = len;

            LblFinish.Location = new System.Drawing.Point(LblFinish.Location.X, (location - height));
            LblFinish.Height = height;

            Horsey1.Visible = Horsey2.Visible = Horsey3.Visible = Start.Visible = label1.Visible = Restart.Visible = Reload.Visible = false;


            label1.Text = "";
            player.Stop();
            player.Play();

        }
    }

}
