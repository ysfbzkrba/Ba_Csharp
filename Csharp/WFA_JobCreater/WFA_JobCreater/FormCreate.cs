using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_JobCreater.Classes;
using System.IO;

namespace WFA_JobCreater
{

    //  yapılacaklar    \\
    
    // add plan notu
    // add (if:afprojesi) ölçüler, malikler, başvuru formu
    // add notes. to notes.txt
    // add mevcut işler??????
    // add edit selected iş.

    // add antet düzenleme ekranı
    // add bağımsız bölüm listesi ekranı


    public partial class NewProject : Form
    {
        #region Variables
        string savePath = @"F:\CurrentWork\Jobs";
        string mainPath = @"F:\CurrentWork";
        string createPath = "";
        string adaParsel = "";
        string rexport = "";
        string res = "";
        string tar = "";
        string istakip = "";
        string[] jobtypes = { "İmar Affı", "Uygulama", "Etüt", "Tadilat", "İç Mekan", "Render/Sunum", "Akustik", "EKB" };

        string sourceAcad = @"F:\Mimari Kütüphane\AutoCad Kütüphane\Antet - Gop Yeni Proje.dwg";
        string destAcad = "";

        string sourceRvt = "";
        string destRvt = "";

        string sourceCover = "";
        string destCover = "";

        string sourceTable = "";
        string destTable = "";
        #endregion

        #region Functions

        #endregion

        #region FormLoad
        public NewProject()
        {
            InitializeComponent();
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            txtProjectPath.Text = fbdProjectPath.SelectedPath;
            txtSavePath.Text = fbdSavePath.SelectedPath;

            grpSettings.Visible = false;
            lblDate.Text = DateTime.Now.ToString();
            cmbType.Items.AddRange(jobtypes);
        } 
        #endregion
        //  FormLoaded  //
        #region FormDefaults
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region NumericOnly
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // && (e.KeyChar != '.')
            {
                e.Handled = true;
                //txtISBN.Text.Replace('*', e.KeyChar);
                //string.Format("{0:###-#-##-######-#}");
            }

            #endregion
        }
        #region Move Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void lblFName_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        #endregion

        #endregion
        // exit button, tray button, moveform, accept numeric only

        #region Save Create
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            #region Project.Properties
            if (cmbType.SelectedItem != null)
            {
                Job project = new Job();
                project.Employer = txtEmployer.Text;
                project.JobType = cmbType.SelectedItem.ToString();
                createPath = System.IO.Path.Combine(mainPath, project.JobType);
                project.JobInit = DateTime.Now;

                if (!string.IsNullOrWhiteSpace(txtSehir.Text))
                {
                    project.City = txtSehir.Text.ToLower();
                    createPath = System.IO.Path.Combine(createPath, project.City);
                }
                if (!string.IsNullOrWhiteSpace(txtDistrict.Text))
                {
                    project.District = txtDistrict.Text.ToLower();
                    createPath = System.IO.Path.Combine(createPath, project.District);
                }
                if (!string.IsNullOrWhiteSpace(txtMahal.Text))
                {
                    project.Neighbor = txtMahal.Text.ToLower();
                    createPath = System.IO.Path.Combine(createPath, project.Neighbor);
                }
                if (!string.IsNullOrWhiteSpace(txtCadde.Text))
                {
                    project.Street = txtCadde.Text.ToLower();
                }
                if (!string.IsNullOrWhiteSpace(txtPafta.Text))
                {
                    project.Pafta = txtPafta.Text;
                }
                if (!string.IsNullOrWhiteSpace(txtAda.Text))
                {
                    project.Block = txtAda.Text;
                }
                if (!string.IsNullOrWhiteSpace(txtParsel.Text))
                {
                    project.Plot = txtParsel.Text;
                    adaParsel = $"{project.Block}_{project.Plot}";
                    createPath = System.IO.Path.Combine(createPath, adaParsel);
                }
                if (!string.IsNullOrWhiteSpace(txtYapiCinsi.Text))
                {
                    project.BuildingType = txtYapiCinsi.Text.ToLower();
                }
                if (!string.IsNullOrWhiteSpace(txtYapiSinifi.Text))
                {
                    project.BuildingClass = txtYapiSinifi.Text.ToLower();
                }

                project.StoriesUpper = Convert.ToInt16(nudUpper.Value);
                project.StoriesLower = Convert.ToInt16(nudLower.Value);


                project.OTT = dtpOTTarihi.Value;
                if (!string.IsNullOrWhiteSpace(txtUcret.Text))
                {
                    project.Pay = int.Parse(txtUcret.Text);
                }
                else
                {
                    MessageBox.Show("Make sure you know the pay.");
                }
            }
            else
            {
                MessageBox.Show("JobType cannot be empty.");
            }
            #endregion

            #region SetFileNames
            destAcad = adaParsel + ".acad";
            destRvt = adaParsel + ".rvt";
            destCover = adaParsel + ".pdf";
            destTable = adaParsel + "pdf";
            #endregion

            #region SetSubDirectoryNames
            rexport = $"rex_{adaParsel}";
            res = $"resim_{adaParsel}";
            tar = $"tarama_{adaParsel}";
            istakip = $"istakip_{adaParsel}";
            #endregion
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                #region CreateJobFolders

                // Determine whether the directory exists.
                if (Directory.Exists(createPath))
                {
                    MessageBox.Show("That path exists already.");
                    return;
                }

                #region CreateMainDirectory
                DirectoryInfo di = Directory.CreateDirectory(createPath); 
                #endregion

                #region CreateSubDirectories
                Directory.CreateDirectory(System.IO.Path.Combine(createPath, rexport));
                Directory.CreateDirectory(System.IO.Path.Combine(createPath, res));
                Directory.CreateDirectory(System.IO.Path.Combine(createPath, tar));
                Directory.CreateDirectory(System.IO.Path.Combine(createPath, istakip)); 
                #endregion

                #region CopyFiles
                System.IO.File.Copy(sourceAcad, System.IO.Path.Combine(createPath, destAcad), true);
                System.IO.File.Copy(sourceRvt, System.IO.Path.Combine(createPath, destRvt), true);

                if (checkCoverPDF.Checked)
                {
                    //create.pdf
                    System.IO.File.Copy(sourceCover, System.IO.Path.Combine(createPath, destCover), true);
                }
                if (checkApartList.Checked)
                {
                    //create.apartlist
                    System.IO.File.Copy(sourceTable, System.IO.Path.Combine(createPath, destTable), true);
                }
                #endregion

                MessageBox.Show($"The directory was created successfully at {Directory.GetCreationTime(createPath)}.");

                #endregion

                #region CreateLogFolder&Files
                Directory.CreateDirectory(System.IO.Path.Combine(savePath, adaParsel));



                #endregion
            }
            catch (Exception err)
            {
                MessageBox.Show($"The process failed: {err}");
            }
        }
        #endregion

        #region Settings
        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!grpSettings.Visible)
            {
                grpSettings.Visible = true;
            }
            else
            {
                grpSettings.Visible = false;
            }
        }
        private void btnSelectProjectPath_Click(object sender, EventArgs e)
        {
            fbdProjectPath.ShowDialog();
            txtProjectPath.Text = fbdProjectPath.SelectedPath;
        }
        private void btnSelectSavePath_Click(object sender, EventArgs e)
        {
            fbdSavePath.ShowDialog();
            txtSavePath.Text = fbdSavePath.SelectedPath;
        }
        private void cmbTheme_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //set theme colors.
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            mainPath = txtProjectPath.Text;
            savePath = txtSavePath.Text;
        }
        #endregion
    }
}
