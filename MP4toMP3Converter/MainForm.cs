using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class MainForm : Form
    {
        #region GlobalVars
        public static string filepathMode = "publish";

        private Form activeForm = null;
        string SetupFile = "preferences.txt";
        public static byte[] ColorScheme = new byte[27];
        #endregion

        #region PrimaryMethods

        public MainForm()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            //read setup file here

            InitializeComponent();

            sub1panel.Visible = false;
            sub2panel.Visible = false;

            if (File.Exists(SetupFile) == true && GetLine(SetupFile, 5).Substring(11, 7) != "Default")
            {
                ColorScheme[0] = Convert.ToByte(GetLine(SetupFile, 6).Substring(14, 3));
                ColorScheme[1] = Convert.ToByte(GetLine(SetupFile, 6).Substring(18, 3));
                ColorScheme[2] = Convert.ToByte(GetLine(SetupFile, 6).Substring(22, 3));

                Debug.WriteLine(ColorScheme[1]);
                Debug.WriteLine(ColorScheme[2]);
            }
            else
            {
                CreateDefaultSetupFile();
                ColorScheme = DefaultColors();
            }
        }

        private void DropdownButton1_Click(object sender, EventArgs e)
        {
            ShowSubMenus(sub1panel);
        }

        private void Sub1Button1_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("convert"));
        }

        private void Sub1Button2Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("combine"));
        }

        private void Sub1Button3_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("convertCombine"));
        }

        private void Sub2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(this));
        }

        private void Sub2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthorForm());
        }

        private void DropdownButton2_Click(object sender, EventArgs e)
        {
            ShowSubMenus(sub2panel);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ConvertForm.converter.Stop();
            if (ConvertForm.thread != null) ConvertForm.thread.Abort();
            Environment.Exit(1);
        }
        #endregion

        #region SecondaryMethods

        private void CreateDefaultSetupFile()
        {
            StreamWriter sw = new StreamWriter(SetupFile);
            sw.WriteLine(" - THIS IS AN AUTOMATICALLY GENERATED FILE BY THORIUM.EXE. -");
            sw.WriteLine(" - DO NOT CHANGE THIS FILE MANUALLY IF YOU DONT KNOW WHAT YOU ARE DOING. - ");
            sw.WriteLine(" - CHANGING MIGHT CAUSE ISSUES FROM BUGS TO DESTROYING THE PROGRAM. - ");
            sw.WriteLine();
            sw.WriteLine("SetupMode: Default");
            sw.WriteLine("ColorScheme0:");
            sw.Close();
        }

        private string GetLine(string fileName, int line)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                {
                    sr.ReadLine();
                }
                return sr.ReadLine();
            }
        }

        private void HideSubMenus()
        {
            sub1panel.Visible = false;
            sub2panel.Visible = false;
        }

        private void ShowSubMenus(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenus();
                panel.Visible = true;
            }
            else panel.Visible = false;
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            //{
                activeForm.Close();
            //}
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(ChildForm);
            FormPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private byte[] DefaultColors()
        {
            return new byte[] { 0, 0, 0, 
                                255, 255, 255, 
                                227, 176, 255, 
                                151, 142, 153, 
                                40, 40, 40, 
                                64, 0, 64,  
                                50, 50, 50, 
                                64, 64, 64,
                                111, 74, 113};
        }

        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}

/*

 transparent in WPF??


    ffMpeg.GetVideoThumbnail(pathToVideoFile, "video_thumbnail.jpg");
     */
