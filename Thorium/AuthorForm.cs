using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;


using Thorium.Properties;

namespace Thorium
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
            CustomColors();
            fontInit();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OutsourcedFunctions.LoadWebsite("https://befonts.com/author/behance");
        }

        #endregion

        #region init

        private void CustomColors()
        {
            Heading.ForeColor = MainForm.getCustomColor(2);

            this.BackColor = MainForm.getCustomColor(7);

            BackgroundPanel.BackColor = MainForm.getCustomColor(8);
            panel1.BackColor = MainForm.getCustomColor(8);

            InfoLabel1.ForeColor = MainForm.getCustomColor(4);

            InfoLabel2.ForeColor = MainForm.getCustomColor(4);

            linkLabel1.LinkColor = MainForm.getCustomColor(3);
            linkLabel1.ForeColor = MainForm.getCustomColor(4);
            linkLabel1.VisitedLinkColor = MainForm.getCustomColor(9);
            linkLabel1.ActiveLinkColor = MainForm.getCustomColor(9);

            linkLabel2.LinkColor = MainForm.getCustomColor(3);
            linkLabel2.ForeColor = MainForm.getCustomColor(4);
            linkLabel2.VisitedLinkColor = MainForm.getCustomColor(9);
            linkLabel2.ActiveLinkColor = MainForm.getCustomColor(9);
        }

        private void fontInit()
        {
            byte[] fontData = Resources.font_slim;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint dummy = 0;

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            MainForm.fonts.AddMemoryFont(fontPtr, Resources.font_slim.Length);
            MainForm.AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.font_slim.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            OutsourcedFunctions o = new OutsourcedFunctions();

            o.changeFont(new Control[] { InfoLabel1, linkLabel1, linkLabel2, InfoLabel2 }, new Font(MainForm.fonts.Families[0], 15f));

            o.changeFont(new Control[] { Heading }, new Font(MainForm.fonts.Families[0], 26.25f));
        }

        #endregion
    }
}
