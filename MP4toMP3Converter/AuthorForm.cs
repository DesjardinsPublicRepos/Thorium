using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
            CustomColors();
        }

        #region onClicks

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://github.com/DesjardinsPublicRepos");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://github.com/DesjardinsPublicRepos/VideoConverter");
        }

        private void Icons8pictureBox_Click(object sender, EventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://icons8.com/");
        }

        private void NRecoPictureBox_Click(object sender, EventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://www.nrecosite.com/video_converter_net.aspx");
        }

        private void BunifuPictureBox_Click(object sender, EventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://bunifuframework.com/");
        }

        private void AspNETPictureBox_Click(object sender, EventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://github.com/StephenCleary/AspNetBackgroundTasks");
        }

        #endregion

        #region init

        private void CustomColors()
        {
            Heading.ForeColor = MainForm.getCustomColor(3);
            Line1.ForeColor = MainForm.getCustomColor(3);
            InfoLabel1.ForeColor = MainForm.getCustomColor(3);
            linkLabel1.LinkColor = MainForm.getCustomColor(3);
            linkLabel2.LinkColor = MainForm.getCustomColor(3);

            InfoLabel2.ForeColor = MainForm.getCustomColor(4);
            Line2.ForeColor = MainForm.getCustomColor(4);

            if (MainForm.ColorScheme[6] < 236 && MainForm.ColorScheme[7] < 236 && MainForm.ColorScheme[8] < 236)
            {
                linkLabel1.ActiveLinkColor = Color.FromArgb(MainForm.ColorScheme[6] + 20, MainForm.ColorScheme[7] + 20, MainForm.ColorScheme[8] + 20);
                linkLabel2.ActiveLinkColor = Color.FromArgb(MainForm.ColorScheme[6] + 20, MainForm.ColorScheme[7] + 20, MainForm.ColorScheme[8] + 20);
            }
            else
            {
                linkLabel1.ActiveLinkColor = MainForm.getCustomColor(3);
                linkLabel2.ActiveLinkColor = MainForm.getCustomColor(3);
            }
             
            this.BackColor = MainForm.getCustomColor(7);
            BackgroundPanel.BackColor = MainForm.getCustomColor(8);
        }

        #endregion
    }
}
