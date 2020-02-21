using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class SettingsForm : Form
    {
        private ColorSelectForm colorSelectForm;
        private readonly MainForm f;
        private Thread thread;
        private readonly bool initComplete = false;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public SettingsForm(MainForm ff)
        {
            f = ff;
            InitializeComponent();
            CustomColors();
            fontInit();
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

        private void startColorForm()
        {
            Application.Run(colorSelectForm);
        }

        private void iconClick(byte iconIndex)
        {
            MainForm.iconScheme = iconIndex;
            MainForm.setLine(MainForm.SetupFile, 8, "00" + iconIndex.ToString());
            MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");

            MainForm.changeBinary(new byte[] { 29, 0 }, new object[] { Convert.ToByte(iconIndex), true }, null);

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

        private void SettingsFormButtonClicked(object sender, EventArgs e)
        {
            if (sender == setDefaultButton)
            {
                MainForm.ColorScheme = MainForm.DefaultColors();
                updateColors(this);
            }
            else if (sender == applyChangesButton)
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
                        s += "0" + b.ToString() + " ";
                    }
                    else s += b.ToString() + " ";
                }

                MainForm.setLine(MainForm.SetupFile, 7, s);
                MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");

                MainForm.changeBinary(new byte[] { 0, 1 }, new object[] { true, true }, MainForm.ColorScheme);
                MainForm.getCurrentSetup(MainForm.binary);
            }

        }

        #endregion

        #region checkChanged

        private void CheckBoxesCheckChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;

            if (checkBox == checkBox2)
            {
                if (initComplete == true)
                {
                    if (checkBox2.Checked == true)
                    {
                        changeLabelStyle(TempFilesLabel, true);
                        MainForm.setLine(MainForm.SetupFile, 5, "SetupMode <Custom>");
                        MainForm.setLine(MainForm.SetupFile, 9, TempFilesLabel.Text);

                        MainForm.changeBinary(new byte[] { 0, 30 }, new object[] { true, TempFilesLabel.Text }, null);

                        MainForm.customFilepathEnalbled[0] = true;
                        MainForm.customFilepaths[0] = TempFilesLabel.Text;
                    }
                    else
                    {
                        changeLabelStyle(TempFilesLabel, false);
                        MainForm.setLine(MainForm.SetupFile, 9, "Default");
                        MainForm.customFilepathEnalbled[0] = false;
                        MainForm.customFilepaths[0] = "Default";

                        MainForm.changeBinary(new byte[] { 30 }, new object[] { "Default" }, null);
                    }
                }
            }
            else if (checkBox == checkBox3)
            {
                if (initComplete == true)
                {
                    if (checkBox3.Checked == true)
                    {
                        changeLabelStyle(OutputPathLabel, true);
                        if (OutputPathLabel.Text.Substring(0, 8) == "..users\\")
                        {
                            MainForm.setLine(MainForm.SetupFile, 10, "C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7));
                            MainForm.customFilepaths[1] = "C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7);
                            MainForm.customFilepathEnalbled[1] = true;

                            MainForm.changeBinary(new byte[] { 31, 0 }, new object[] { ("C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7)).ToString(), true }, null);
                        }
                        else
                        {
                            MainForm.setLine(MainForm.SetupFile, 10, OutputPathLabel.Text);
                            MainForm.customFilepathEnalbled[1] = true;
                            MainForm.customFilepaths[1] = OutputPathLabel.Text;

                            MainForm.changeBinary(new byte[] { 31, 0 }, new object[] { OutputPathLabel.Text.ToString(), true }, null);
                        }
                    }
                    else
                    {
                        changeLabelStyle(OutputPathLabel, false);
                        MainForm.setLine(MainForm.SetupFile, 10, "Default");
                        MainForm.customFilepathEnalbled[1] = false;
                        MainForm.customFilepaths[1] = "Default";

                        MainForm.changeBinary(new byte[] { 31 }, new object[] { "Default" }, null);
                    }
                }
            }
            else if (checkBox == checkBox1)
            {
                if (initComplete == true)
                {
                    if (checkBox1.Checked == false)
                    {
                        backPanel.Location = new Point(32, 291);

                        color2box.Visible = false;
                        color3box.Visible = false;
                        color4box.Visible = false;
                        color5box.Visible = false;
                        color5box2.Visible = false;
                        color6box.Visible = false;
                        color7box.Visible = false;
                        color7box2.Visible = false;
                        sub1heading1.Visible = false;
                        sub1heading2.Visible = false;
                        setDefaultButton.Visible = false;
                        applyChangesButton.Visible = false;

                        MainForm.ColorScheme = MainForm.DefaultColors();
                        updateColors(this);

                        MainForm.setLine(MainForm.SetupFile, 6, "ColorScheme: Disabled");

                        MainForm.changeBinary(new byte[] { 1 }, new object[] { false }, null);

                        SettingsFormButtonClicked(applyChangesButton, null);
                    }
                    else
                    {
                        backPanel.Location = new Point(32, 362);

                        color2box.Visible = true;
                        color3box.Visible = true;
                        color4box.Visible = true;
                        color5box.Visible = true;
                        color5box2.Visible = true;
                        color6box.Visible = true;
                        color7box.Visible = true;
                        color7box2.Visible = true;
                        sub1heading1.Visible = true;
                        sub1heading2.Visible = true;
                        setDefaultButton.Visible = true;
                        applyChangesButton.Visible = true;
                        MainForm.setLine(MainForm.SetupFile, 6, "ColorScheme: Enabled.");

                        MainForm.changeBinary(new byte[] { 1 }, new object[] { true }, null);
                    }
                }
            }
        }

        private void changeLabelStyle(Bunifu.Framework.UI.BunifuMaterialTextbox textbox, bool enabled)
        {
            if (enabled == true)
            {
                textbox.ForeColor = MainForm.getCustomColor(2);
                textbox.HintForeColor = MainForm.getCustomColor(2);
                textbox.LineIdleColor = MainForm.getCustomColor(4);
                textbox.LineFocusedColor = MainForm.getCustomColor(3);
                textbox.LineMouseHoverColor = MainForm.getCustomColor(3);
            }
            else
            {
                textbox.ForeColor = MainForm.getCustomColor(7);
                textbox.HintForeColor = MainForm.getCustomColor(7);
                textbox.LineIdleColor = MainForm.getCustomColor(7);
                textbox.LineFocusedColor = MainForm.getCustomColor(7);
                textbox.LineMouseHoverColor = MainForm.getCustomColor(7);
            }

            textbox.Enabled = enabled;

            if (textbox == TempFilesLabel)
            {
                tmpFilePathButton.Enabled = enabled;
                if (enabled == false)
                {
                    textbox.Text = "C:\\";
                }
            }
            else if (textbox == OutputPathLabel)
            {
                defaultPathButton.Enabled = enabled;
                if (enabled == false)
                {
                    textbox.Text = "..users\\Music\\";
                }
            }
        }
        #endregion

        #region filepaths
      
        private void OpenFilepathClicked(object sender, EventArgs e)
        {
            if (sender == defaultPathButton)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    OutputPathLabel.Text = folderBrowserDialog.SelectedPath;
                    LabelKeyDown(OutputPathLabel, new KeyEventArgs(Keys.Enter));
                }
            }
            else if (sender == tmpFilePathButton)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    TempFilesLabel.Text = folderBrowserDialog.SelectedPath;
                    LabelKeyDown(TempFilesLabel, new KeyEventArgs(Keys.Enter));
                }
            }
        }

        private void LabelKeyDown(object sender, KeyEventArgs e)
        {
            if (OutsourcedFunctions.enterHandling(e) == true) 
            {
                if (sender == TempFilesLabel)
                {
                    if (OutputPathLabel.Enabled == true)
                    {
                        OutputPathLabel.Focus();
                    }
                    else panel3.Focus();
                }
                else if (sender == OutputPathLabel)
                {
                    panel3.Focus();
                }
            }
        }

        private void LableEnter(object sender, EventArgs e)
        {
            var textbox = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;
            if (textbox.Text == "C:\\" | textbox.Text == "..users\\Music\\")
            textbox.Text = null;
        }

        private void LabelLeave(object sender, EventArgs e)
        {
            var textbox = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;

            if (sender == TempFilesLabel && textbox.Text == "")
            {
                textbox.Text = "C:\\";
            }
            if (sender == OutputPathLabel && textbox.Text == "")
            {
                textbox.Text = "..users\\Music\\";
            }

            if (sender == TempFilesLabel)
            {
                MainForm.setLine(MainForm.SetupFile, 9, TempFilesLabel.Text);
                MainForm.customFilepaths[0] = TempFilesLabel.Text;

                MainForm.changeBinary(new byte[] { 0, 30 }, new object[] { true, TempFilesLabel.Text.ToString() }, null);
            }
            else if (sender == OutputPathLabel)
            {
                try
                {
                    if (OutputPathLabel.Text.Substring(0, 8) == "..users\\")
                    {
                        MainForm.setLine(MainForm.SetupFile, 10, "C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7));
                        MainForm.customFilepaths[1] = "C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7);

                        MainForm.changeBinary(new byte[] { 0, 31 }, new object[] { true, ("C:\\Users\\" + Environment.UserName + OutputPathLabel.Text.Substring(7, OutputPathLabel.Text.Length - 7)).ToString() }, null);
                    }
                    else
                    {
                        MainForm.setLine(MainForm.SetupFile, 10, OutputPathLabel.Text);
                        MainForm.customFilepaths[1] = OutputPathLabel.Text;

                        MainForm.changeBinary(new byte[] { 0, 31 }, new object[] { true, OutputPathLabel.Text.ToString() }, null);
                    }
                }
                catch (Exception)
                {
                    MainForm.setLine(MainForm.SetupFile, 10, OutputPathLabel.Text);
                    MainForm.customFilepaths[1] = OutputPathLabel.Text;

                    MainForm.changeBinary(new byte[] { 0, 31 }, new object[] { true, OutputPathLabel.Text.ToString() }, null);
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

            setDefaultButton.BackColor = MainForm.getCustomColor(8);
            setDefaultButton.Activecolor = MainForm.getCustomColor(8);
            setDefaultButton.Normalcolor = MainForm.getCustomColor(8);
            setDefaultButton.OnHovercolor = MainForm.getCustomColor(6);
            setDefaultButton.ForeColor = MainForm.getCustomColor(2);
            setDefaultButton.OnHoverTextColor = MainForm.getCustomColor(2);

            applyChangesButton.BackColor = MainForm.getCustomColor(8);
            applyChangesButton.Activecolor = MainForm.getCustomColor(8);
            applyChangesButton.Normalcolor = MainForm.getCustomColor(8);
            applyChangesButton.OnHovercolor = MainForm.getCustomColor(6);
            applyChangesButton.ForeColor = MainForm.getCustomColor(2);
            applyChangesButton.OnHoverTextColor = MainForm.getCustomColor(2);

            Heading1.ForeColor = MainForm.getCustomColor(2);
            Heading2.ForeColor = MainForm.getCustomColor(2);
            Heading3.ForeColor = MainForm.getCustomColor(2);
            
            sub1heading2.ForeColor = MainForm.getCustomColor(4);
            sub1heading1.ForeColor = MainForm.getCustomColor(4);
            checkBox2.ForeColor = MainForm.getCustomColor(4);
            checkBox3.ForeColor = MainForm.getCustomColor(4);
            checkBox1.ForeColor = MainForm.getCustomColor(4);

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
            
            if (MainForm.customFilepathEnalbled[0] == false)
            {
                changeLabelStyle(TempFilesLabel, false);
            }
            else
            {
                TempFilesLabel.Text = MainForm.customFilepaths[0];
                checkBox2.Checked = true;
                tmpFilePathButton.Enabled = true;
            }
            if (MainForm.customFilepathEnalbled[1] == false)
            {
                changeLabelStyle(OutputPathLabel, false);
            }
            else
            {
                OutputPathLabel.Text = MainForm.customFilepaths[1];
                checkBox3.Checked = true;
                defaultPathButton.Enabled = true;
            }
            
            if (Convert.ToBoolean(MainForm.getCurrentSetup(MainForm.binary)[1]) == false)
            {
                if (initComplete == false)
                {
                    checkBox1.Checked = false;
                    color2box.Visible = false;
                    color3box.Visible = false;
                    color4box.Visible = false;
                    color5box.Visible = false;
                    color5box2.Visible = false;
                    color6box.Visible = false;
                    color7box.Visible = false;
                    color7box2.Visible = false;
                    sub1heading1.Visible = false;
                    sub1heading2.Visible = false;
                    setDefaultButton.Visible = false;
                    applyChangesButton.Visible = false;

                    backPanel.Location = new Point(32, 291);
                }
            }
        }

        private void fontInit()
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            byte[] fontData = Resources.CG;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint dummy = 0;

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fonts.AddMemoryFont(fontPtr, Resources.CG.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.CG.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            OutsourcedFunctions o = new OutsourcedFunctions();

            o.changeFont(new Control[] { Heading1, Heading2, Heading3 }, new Font(fonts.Families[0], 26.25f));

            o.changeFont(new Control[] { checkBox1, checkBox2, checkBox3, TempFilesLabel, OutputPathLabel, applyChangesButton, setDefaultButton }, new Font(fonts.Families[0], 9.75f));

            o.changeFont(new Control[] { sub1heading1, sub1heading2 }, new Font(fonts.Families[0], 20.25f));
        }
        #endregion

        #region overrides

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
