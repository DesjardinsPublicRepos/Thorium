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
        public static string SetupFile = "preferences.txt";
        public static bool[] customFilepathEnalbled = new bool[2] { false, false };
        public static string[] customFilepaths = new string[2] { "Default", "Default" };
        public static byte[] ColorScheme = new byte[27];
        public static byte iconScheme;

        private Form activeForm = null;

        public MainForm()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();
            readSetup();
            InitializeComponent();
            CustomColors();
            
            sub1panel.Visible = false;
            sub2panel.Visible = false;
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

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #region SecondaryMethods

        private void CreateDefaultSetupFile()
        {
            StreamWriter sw = new StreamWriter(SetupFile);
            sw.WriteLine(" - THIS IS AN AUTOMATICALLY GENERATED FILE BY THORIUM.EXE. -");
            sw.WriteLine(" - DO NOT CHANGE THIS FILE MANUALLY IF YOU DONT KNOW WHAT YOU ARE DOING. - ");
            sw.WriteLine(" - IF YOU DID A CHANGE AND THE PROGRAM ISNT WORKING PROPERLY, TRY DELETING THIS FILE. - ");
            sw.WriteLine();
            sw.WriteLine("SetupMode <Default>");
            sw.WriteLine("ColorScheme: ");
            sw.WriteLine("000 000 000 255 255 255 227 176 255 151 142 153 044 044 044 064 000 064 050 050 050 064 064 064 111 074 113");
            sw.WriteLine("006");
            //sw.WriteLine("customFilepaths 00");
            sw.WriteLine("Default");
            sw.WriteLine("Default");
            sw.Close();
        }

        public static string getLine(string fileName, int line)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                {
                    sr.ReadLine();
                }
                string s = sr.ReadLine();
                sr.Close();
                return s;
            }
        }

        public static void setLine(string fileName, int line, string text)
        {
            string[] file = File.ReadAllLines(fileName);
            file[line - 1] = text;

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (string s in file)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
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

        private void readSetup()
        {
            if (File.Exists(SetupFile) == true)
            {
                if (getLine(SetupFile, 5).Substring(11, 7) == "Default")
                {
                    ColorScheme = DefaultColors();
                    iconScheme = 6;
                }
                else
                {
                    string[] file = File.ReadAllLines(SetupFile);

                    ColorScheme[0] = Convert.ToByte(file[6].Substring(0, 3));
                    ColorScheme[1] = Convert.ToByte(file[6].Substring(4, 3));
                    ColorScheme[2] = Convert.ToByte(file[6].Substring(8, 3));
                    ColorScheme[3] = Convert.ToByte(file[6].Substring(12, 3));
                    ColorScheme[4] = Convert.ToByte(file[6].Substring(16, 3));
                    ColorScheme[5] = Convert.ToByte(file[6].Substring(20, 3));
                    ColorScheme[6] = Convert.ToByte(file[6].Substring(24, 3));
                    ColorScheme[7] = Convert.ToByte(file[6].Substring(28, 3));
                    ColorScheme[8] = Convert.ToByte(file[6].Substring(32, 3));
                    ColorScheme[9] = Convert.ToByte(file[6].Substring(36, 3));
                    ColorScheme[10] = Convert.ToByte(file[6].Substring(40, 3));
                    ColorScheme[11] = Convert.ToByte(file[6].Substring(44, 3));
                    ColorScheme[12] = Convert.ToByte(file[6].Substring(48, 3));
                    ColorScheme[13] = Convert.ToByte(file[6].Substring(52, 3));
                    ColorScheme[14] = Convert.ToByte(file[6].Substring(56, 3));
                    ColorScheme[15] = Convert.ToByte(file[6].Substring(60, 3));
                    ColorScheme[16] = Convert.ToByte(file[6].Substring(64, 3));
                    ColorScheme[17] = Convert.ToByte(file[6].Substring(68, 3));
                    ColorScheme[18] = Convert.ToByte(file[6].Substring(72, 3));
                    ColorScheme[19] = Convert.ToByte(file[6].Substring(76, 3));
                    ColorScheme[20] = Convert.ToByte(file[6].Substring(80, 3));
                    ColorScheme[21] = Convert.ToByte(file[6].Substring(84, 3));
                    ColorScheme[22] = Convert.ToByte(file[6].Substring(88, 3));
                    ColorScheme[23] = Convert.ToByte(file[6].Substring(92, 3));
                    ColorScheme[24] = Convert.ToByte(file[6].Substring(96, 3));
                    ColorScheme[25] = Convert.ToByte(file[6].Substring(100, 3));
                    ColorScheme[26] = Convert.ToByte(file[6].Substring(104, 3));

                    iconScheme = Convert.ToByte(file[7].Substring(0, 3));

                    if (file[8].Trim() != "Default")
                    {
                        customFilepathEnalbled[0] = true;
                        customFilepaths[0] = file[8].Trim();
                    }
                    if (file[9].Trim() != "Default")
                    {
                        customFilepathEnalbled[1] = true;
                        customFilepaths[1] = file[9].Trim();
                    }
                    Debug.WriteLine(customFilepathEnalbled[1].ToString() + customFilepathEnalbled[0].ToString());
                }
            }
            else
            {
                CreateDefaultSetupFile();
                ColorScheme = DefaultColors();
                iconScheme = 6;
            }
        }

        public static byte[] DefaultColors()
        {
            return new byte[] { 0, 0, 0, 
                                255, 255, 255, 
                                227, 176, 255, 
                                151, 142, 153, 
                                44, 44, 44, 
                                64, 0, 64,  
                                50, 50, 50, 
                                64, 64, 64,
                                111, 74, 113};//26
        }

        public static byte[] getCustomColor(byte index)
        {
            return new byte[3] { ColorScheme[(index - 1) * 3], ColorScheme[((index - 1) * 3) + 1], ColorScheme[((index - 1) * 3) + 2] };
        }

        private void CustomColors()
        {
            FormPanel.BackColor = Color.FromArgb(ColorScheme[18], ColorScheme[19], ColorScheme[20]);
            IconPictureBox.BackColor = Color.FromArgb(ColorScheme[18], ColorScheme[19], ColorScheme[20]);
            InfoLabel2.BackColor = Color.FromArgb(ColorScheme[18], ColorScheme[19], ColorScheme[20]);
            InfoLabel1.BackColor = Color.FromArgb(ColorScheme[18], ColorScheme[19], ColorScheme[20]);
            stLabel.BackColor = Color.FromArgb(ColorScheme[18], ColorScheme[19], ColorScheme[20]);

            Sub1Button1.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            Sub1Button2.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            Sub1Button3.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            Sub2Button1.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            Sub2Button3.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            Sub2Button4.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            sub1panel.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);
            sub2panel.BackColor = Color.FromArgb(ColorScheme[21], ColorScheme[22], ColorScheme[23]);

            InfoLabel2.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            CloseButton.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            DropdownButton1.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            DropdownButton2.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub1Button1.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub1Button2.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub1Button3.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub2Button1.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub2Button3.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);
            Sub2Button4.ForeColor = Color.FromArgb(ColorScheme[3], ColorScheme[4], ColorScheme[5]);

            InfoLabel1.ForeColor = Color.FromArgb(ColorScheme[6], ColorScheme[7], ColorScheme[8]);
            stLabel.ForeColor = Color.FromArgb(ColorScheme[6], ColorScheme[7], ColorScheme[8]);

            CloseButton.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);
            RestartButton.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);
            BackPanel.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);
            DropdownButton1.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);
            DropdownButton2.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);
            sub0panel.BackColor = Color.FromArgb(ColorScheme[12], ColorScheme[13], ColorScheme[14]);

            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[15], ColorScheme[16], ColorScheme[17]);
            RestartButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[15], ColorScheme[16], ColorScheme[17]);
            DropdownButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[15], ColorScheme[16], ColorScheme[17]);
            DropdownButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[15], ColorScheme[16], ColorScheme[17]);

            Sub1Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);
            Sub1Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);
            Sub1Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);
            Sub2Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);
            Sub2Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);
            Sub2Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(ColorScheme[24], ColorScheme[25], ColorScheme[26]);

            switch(iconScheme)
            {
                case 0:
                    IconPictureBox.Image = Properties.Resources.coal_white;
                    break;
                case 1:
                    IconPictureBox.Image = Resources.coal_orange;
                    break;
                case 2:
                    IconPictureBox.Image = Resources.coal_yellow;
                    break;
                case 3:
                    IconPictureBox.Image = Resources.coal_green;
                    break;
                case 4:
                    IconPictureBox.Image = Resources.coal_brightblue;
                    break;
                case 5:
                    IconPictureBox.Image = Resources.coal_blue;
                    break;
                case 6:
                    IconPictureBox.Image = Resources.coal_lila;
                    break;
                case 7:
                    IconPictureBox.Image = Resources.coal_red;
                    break;
                case 8:
                    IconPictureBox.Image = Resources.coal_black;
                    break;
            }
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
