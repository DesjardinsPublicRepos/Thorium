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

        private Form activeForm = null;
        string SetupFile = "preferences.txt";
        public int[] ColorScheme0 = new int[3];
        #endregion

        #region PrimaryMethods

        public MainForm()
        {
            InitializeComponent();

            sub1panel.Visible = false;
            sub2panel.Visible = false;

            if (File.Exists(SetupFile) == true && GetLine(SetupFile, 5).Substring(11, 7) != "Default")
            {
                ColorScheme0[0] = Convert.ToInt32(GetLine(SetupFile, 6).Substring(14, 3));
                ColorScheme0[1] = Convert.ToInt32(GetLine(SetupFile, 6).Substring(18, 3));
                ColorScheme0[2] = Convert.ToInt32(GetLine(SetupFile, 6).Substring(22, 3));

                Debug.WriteLine(ColorScheme0[0]);
                Debug.WriteLine(ColorScheme0[1]);
                Debug.WriteLine(ColorScheme0[2]);
            }
            else
            {
                CreateDefaultSetupFile();
            }
        }

        private void DropdownButton1_Click(object sender, EventArgs e)
        {
            ShowSubMenus(sub1panel);
        }

        private void Sub1Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MP4toMP3Form());
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
            MP4toMP3Form.converter.Stop();
            if (MP4toMP3Form.thread != null) MP4toMP3Form.thread.Abort();
            this.Close();
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

        #endregion
    }
}

/*

 transparent in WPF??


    ffMpeg.GetVideoThumbnail(pathToVideoFile, "video_thumbnail.jpg");
     */
