using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MineSweeper
{
    public partial class Field : Form
    {
        #region Variables
        Random rnd = new Random();
        bool result = true;
        int i = 0;

        #endregion


        public Field()
        {
            InitializeComponent();


        }

        #region FieldLoad
        private void Field_Load(object sender, EventArgs e)
        {
            #region SimpleSamples

            //int[] mines = new int[25];
            //for (int i = 0; i < 25; i++)
            //{
            //    int mines = rnd.Next(1, 226);
            //    if (!mines.Contains(mine))
            //        mines[i] = mine; 
            //    else
            //        i--;
            //}
            //Array.Sort(mines);

            //List<int> mines = new List<int>();
            //while (mines.Count() < 25)
            //{
            //    int mine = rnd.Next(1, 226);
            //    if (!mines.Contains(mine))
            //        mines.Add(mine);
            //}
            //mines.Sort();

            //HashSet<int> mines = new HashSet<int>();
            //while (true)
            //{
            //    mines.Add(rnd.Next(1, 226));

            //    if (mines.Count == 25)
            //    {
            //        break;
            //    }
            //} 
            #endregion

            Game.Stop();

        } 
        #endregion

        #region Click
        private void Pcb_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
            if (Convert.ToBoolean(pcb.Tag))
            {
                //Game.Stop();
                //EndGame.Start();
                result = false;
                pcbState.Image = Image.FromFile("../../resources/sad.png");


                pcbEndgame.BringToFront();

                
            }
            //else
            //{
            //    code nonmine clicks here
            //}
        } 
        #endregion

        #region FormDefault

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void lblTopbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void Game_Tick(object sender, EventArgs e)
        {
            if (result == true)
            {
                foreach (Control ctrl in flowLayoutPanel1.Controls)
                {
                    ctrl.BackColor = Color.FromArgb(rnd.Next(200, 256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
            else
            {
                if (i < flowLayoutPanel1.Controls.Count)
                {
                    PictureBox pcb = (PictureBox)flowLayoutPanel1.Controls[i];
                    pcb.BackColor = (bool)pcb.Tag ? Color.Tomato : Color.FromArgb(255, 30, 30, 30);
                    i++;
                }else
                {
                    i = 0;
                    btnStart.Visible = btnScore.Visible = pcbEndgame.Visible = true;
                }
            }

        } // bound by result status

        private void EndGame_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            //{
            //    PictureBox pcb = (PictureBox)flowLayoutPanel1.Controls[i];
            //    pcb.BackColor = (bool)pcb.Tag ? Color.Tomato : Color.FromArgb(255, 30, 30, 30);
            //}

            
            //if (i < flowLayoutPanel1.Controls.Count)
            //{
            //    PictureBox pcb = (PictureBox)flowLayoutPanel1.Controls[i];
            //    pcb.BackColor = (bool)pcb.Tag ? Color.Tomato : Color.FromArgb(255, 30, 30, 30);
            //    i++;
            //}

            //else
            //{
            //    EndGame.Stop();
            //    Game.Start();
            //}

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            int[] mines = Enumerable.Range(1, 225).OrderBy(x => Guid.NewGuid()).Take(25).ToArray(); // set 25 distinct int values in mines array.

            for (int n = 1; n <= 225; n++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Name = $"pcb{n}";
                pcb.Width = 50;
                pcb.Height = 50;
                pcb.Margin = new Padding(1);
                pcb.Tag = mines.Contains(n) ? true : false;
                pcb.Click += Pcb_Click; // pcb.Click tab tab == creates the pcbclick action.
                flowLayoutPanel1.Controls.Add(pcb);

            }

            result = true;

            pcbState.Image = Image.FromFile("../../resources/neut.png");

            Game.Start();

            btnStart.Visible = btnScore.Visible = pcbEndgame.Visible = false;    
        }
    }
}
