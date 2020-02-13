using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MP4toMP3Converter
{
    public partial class SettingsForm : Form
    {
        private ColorSelectForm colorSelectForm;
        private MainForm f;
        private Thread thread;
        private bool initComplete = false;

        public SettingsForm(MainForm ff)
        {
            f = ff;
            InitializeComponent();
            CustomColors();
            initComplete = true;
        }

        #region onClicks
        private void color1box_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] {0, 1, 2 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color2box_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 3, 4, 5 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color3box_Click(object sender, EventArgs e)
        {

            colorSelectForm = new ColorSelectForm(this, new byte[3] { 6, 7, 8 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color4box_Click(object sender, EventArgs e)
        {

            colorSelectForm = new ColorSelectForm(this, new byte[3] { 9, 10, 11 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color5box_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 12, 13, 14 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color5box2_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 15, 16, 17 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color6box_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 18, 19, 20 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color7box_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 21, 22, 23 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void color7box2_Click(object sender, EventArgs e)
        {
            colorSelectForm = new ColorSelectForm(this, new byte[3] { 24, 25, 26 });
            thread = new Thread(new ThreadStart(startColorForm));
            thread.Start();
        }

        private void icon1box_Click(object sender, EventArgs e)
        {
            iconClick(0);
        }

        private void icon2box_Click(object sender, EventArgs e)
        {
            iconClick(1);
        }

        private void icon3box_Click(object sender, EventArgs e)
        {
            iconClick(2);
        }

        private void icon4box_Click(object sender, EventArgs e)
        {
            iconClick(3);
        }

        private void icon5box_Click(object sender, EventArgs e)
        {
            iconClick(4);
        }

        private void icon6box_Click(object sender, EventArgs e)
        {
            iconClick(5);
        }

        private void icon7box_Click(object sender, EventArgs e)
        {
            iconClick(6);
        }

        private void icon8box_Click(object sender, EventArgs e)
        {
            iconClick(7);
        }

        private void icon9box_Click(object sender, EventArgs e)
        {
            iconClick(8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = null;
            foreach (byte b in MainForm.ColorScheme)
            {
                if (b < 10)
                {
                    s += "00" + b.ToString() + " ";
                }
                else if (b < 100)
                {
                    s +="0" + b.ToString() + " ";
                }
                else s += b.ToString() + " ";
            }

            MainForm.setLine(MainForm.SetupFile, 7, s);
            MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.ColorScheme = MainForm.DefaultColors();
            updateColors(this);
        }

        private void startColorForm()
        {
            Application.Run(colorSelectForm);
        }

        private void iconClick(byte iconIndex)
        {
            MainForm.iconScheme = iconIndex;
            MainForm.setLine(MainForm.SetupFile, 8, "00" + iconIndex.ToString());
            MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");

            PictureBox[] iconPictures = new PictureBox[] { icon1box, icon2box, icon3box, icon4box, icon5box, icon6box, icon7box, icon8box, icon9box };

            foreach (PictureBox iconPicture in iconPictures)
            {
                if (iconPicture.Name == "icon" + (MainForm.iconScheme + 1) + "box")
                {
                    iconPicture.BackColor = Color.FromArgb(MainForm.ColorScheme[9], MainForm.ColorScheme[10], MainForm.ColorScheme[11]);
                }
                else
                {
                    iconPicture.BackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
                }
            }
        }

        #endregion

        #region checkChanged

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (initComplete == true)
            {
                if (checkBox1.Checked == true)
                {
                    textBox1.BackColor = Color.FromArgb(250, 250, 250);
                    textBox1.Enabled = true;
                    MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");
                    MainForm.setLine(MainForm.SetupFile, 9, textBox1.Text);
                }
                else
                {
                    textBox1.BackColor = Color.Gray;
                    textBox1.Enabled = false;
                    MainForm.setLine(MainForm.SetupFile, 9, "Default");
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (initComplete == true)
            {
                if (checkBox2.Checked == true)
                {
                    textBox2.BackColor = Color.FromArgb(250, 250, 250);
                    textBox2.Enabled = true;
                    MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");
                    MainForm.setLine(MainForm.SetupFile, 10, textBox2.Text);
                }
                else
                {
                    textBox2.BackColor = Color.Gray;
                    textBox2.Enabled = false;
                    MainForm.setLine(MainForm.SetupFile, 10, "Default");
                }
            }
        }

        #endregion

        #region filepaths

        private void FilePathFieldsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13) //=enter
            {
                if (sender == textBox1)
                {
                    MainForm.setLine(MainForm.SetupFile, 9, textBox1.Text);
                    textBox2.Focus();
                }
                else if (sender == textBox2)
                {
                    MainForm.setLine(MainForm.SetupFile, 10, textBox2.Text);
                    panel3.Focus();
                }

                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void OpenFilepathClicked(object sender, EventArgs e)
        {
            if (sender == defaultPathButton)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = folderBrowserDialog.SelectedPath;
                    FilePathFieldsKeyDown(textBox2, new KeyEventArgs(Keys.Enter));
                }
            }
            else if (sender == tmpFilePathButton)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderBrowserDialog.SelectedPath;
                    FilePathFieldsKeyDown(textBox1, new KeyEventArgs(Keys.Enter));
                }
            }
        }

        #endregion

        #region init

        public static void updateColors(SettingsForm settingsForm)
        {
            settingsForm.CustomColors();

            settingsForm.f.BackPanel.BackColor = MainForm.getCustomColor(5);

            settingsForm.f.sub1panel.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.sub2panel.BackColor = MainForm.getCustomColor(8);

            settingsForm.f.Sub1Button1.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);
            settingsForm.f.Sub1Button2.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);
            settingsForm.f.Sub1Button3.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);
            settingsForm.f.Sub2Button1.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);
            settingsForm.f.Sub2Button3.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);
            settingsForm.f.Sub2Button4.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(9);

            settingsForm.f.Sub1Button1.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub1Button2.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub1Button3.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button1.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button3.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button4.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.sub1panel.BackColor = MainForm.getCustomColor(8);
            settingsForm.f.sub2panel.BackColor = MainForm.getCustomColor(8);

            settingsForm.f.Sub1Button1.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub1Button2.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub1Button3.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button1.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button3.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);
            settingsForm.f.Sub2Button4.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(8);

            settingsForm.f.CloseButton.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(6);
            settingsForm.f.RestartButton.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(6);
            settingsForm.f.DropdownButton1.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(6);
            settingsForm.f.DropdownButton2.FlatAppearance.MouseOverBackColor = MainForm.getCustomColor(6);

            settingsForm.f.CloseButton.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(5);
            settingsForm.f.RestartButton.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(5);
            settingsForm.f.DropdownButton1.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(5);
            settingsForm.f.DropdownButton2.FlatAppearance.MouseDownBackColor = MainForm.getCustomColor(5);
            settingsForm.f.CloseButton.BackColor = MainForm.getCustomColor(5);
            settingsForm.f.RestartButton.BackColor = MainForm.getCustomColor(5);
            settingsForm.f.DropdownButton1.BackColor = MainForm.getCustomColor(5);
            settingsForm.f.DropdownButton2.BackColor = MainForm.getCustomColor(5);
            settingsForm.f.sub0panel.BackColor = MainForm.getCustomColor(5);

            settingsForm.f.Sub1Button1.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.Sub1Button2.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.Sub1Button3.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.Sub2Button1.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.Sub2Button3.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.Sub2Button4.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.CloseButton.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.RestartButton.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.DropdownButton1.ForeColor = MainForm.getCustomColor(2);
            settingsForm.f.DropdownButton2.ForeColor = MainForm.getCustomColor(2);
        }

        private void CustomColors()
        {
            this.BackColor = MainForm.getCustomColor(7);

            panel1.BackColor = MainForm.getCustomColor(8);
            panel2.BackColor = MainForm.getCustomColor(8);
            panel3.BackColor = MainForm.getCustomColor(8);

            button1.BackColor = MainForm.getCustomColor(3);
            button2.BackColor = MainForm.getCustomColor(3);

            Heading.ForeColor = MainForm.getCustomColor(3);
            Line1.ForeColor = MainForm.getCustomColor(3);
            Heading2.ForeColor = MainForm.getCustomColor(3);
            Line2.ForeColor = MainForm.getCustomColor(3);
            Heading3.ForeColor = MainForm.getCustomColor(3);
            Line3.ForeColor = MainForm.getCustomColor(3);

            button1.ForeColor = MainForm.getCustomColor(1);
            button2.ForeColor = MainForm.getCustomColor(1);

            label1.ForeColor = MainForm.getCustomColor(4);
            label2.ForeColor = MainForm.getCustomColor(4);
            label3.ForeColor = MainForm.getCustomColor(4);
            label4.ForeColor = MainForm.getCustomColor(4);
            label5.ForeColor = MainForm.getCustomColor(4);
            label6.ForeColor = MainForm.getCustomColor(4);
            checkBox1.ForeColor = MainForm.getCustomColor(4);
            checkBox2.ForeColor = MainForm.getCustomColor(4);
            InputLabel.ForeColor = MainForm.getCustomColor(4);

            color1box.BackColor = MainForm.getCustomColor(1);
            color2box.BackColor = MainForm.getCustomColor(2);
            color3box.BackColor = MainForm.getCustomColor(3);
            color4box.BackColor = MainForm.getCustomColor(4);
            color5box.BackColor = MainForm.getCustomColor(5);
            color5box2.BackColor = MainForm.getCustomColor(6);
            color6box.BackColor = MainForm.getCustomColor(7);
            color7box.BackColor = MainForm.getCustomColor(8);
            color7box2.BackColor = MainForm.getCustomColor(9);

            this.Size = new Size(760, 580);

            PictureBox[] iconPictures = new PictureBox[] { icon1box, icon2box, icon3box, icon4box, icon5box, icon6box, icon7box, icon8box, icon9box };

            foreach(PictureBox iconPicture in iconPictures)
            {
                if (iconPicture.Name == "icon" + (MainForm.iconScheme + 1) + "box")
                {
                    iconPicture.BackColor = Color.FromArgb(MainForm.ColorScheme[9], MainForm.ColorScheme[10], MainForm.ColorScheme[11]);
                }
                else
                {
                    iconPicture.BackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
                }
            }
            
            if (MainForm.customFilepathEnalbled[0] == true)
            {
                textBox1.BackColor = Color.FromArgb(250, 250, 250);
                textBox1.Enabled = true;
                textBox1.Text = MainForm.customFilepaths[0];
                checkBox1.Checked = true;
            }
            if (MainForm.customFilepathEnalbled[1] == true)
            {
                textBox2.BackColor = Color.FromArgb(250, 250, 250);
                textBox2.Enabled = true;
                textBox2.Text = MainForm.customFilepaths[1];
                checkBox2.Checked = true;
            }
        }
        #endregion

        #region ovverrides

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == 0x114 || m.Msg == 0x115)
            && (((int)m.WParam & 0xFFFF) == 5))
            {
                // Change SB_THUMBTRACK to SB_THUMBPOSITION
                m.WParam = (IntPtr)(((int)m.WParam & ~0xFFFF) | 4);
            }
            base.WndProc(ref m);
        }

        #endregion
    }
}
