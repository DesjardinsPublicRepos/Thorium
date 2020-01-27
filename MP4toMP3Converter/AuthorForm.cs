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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DesjardinsPublicRepos");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DesjardinsPublicRepos/VideoConverter");
        }

        private void Icons8pictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://icons8.com/");
        }

        private void NRecoPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nrecosite.com/video_converter_net.aspx");
        }

        private void BunifuPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bunifuframework.com/");
        }

        private void AspNETPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/StephenCleary/AspNetBackgroundTasks");
        }
    }
}
