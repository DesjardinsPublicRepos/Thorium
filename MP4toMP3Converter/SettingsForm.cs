﻿using System;
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
        public static byte[] cuColorScheme = new byte[3];
        private MainForm f;
        private Thread thread;

        public SettingsForm(MainForm ff)
        {
            f = ff;
            InitializeComponent();
        }

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

        private void startColorForm()
        {
            Application.Run(colorSelectForm);
        }

        public static void updateColors(SettingsForm settingsForm)
        {
            settingsForm.color1box.BackColor = Color.FromArgb(MainForm.ColorScheme[0], MainForm.ColorScheme[1], MainForm.ColorScheme[2]);
            settingsForm.color2box.BackColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.color3box.BackColor = Color.FromArgb(MainForm.ColorScheme[6], MainForm.ColorScheme[7], MainForm.ColorScheme[8]);
            settingsForm.color4box.BackColor = Color.FromArgb(MainForm.ColorScheme[9], MainForm.ColorScheme[10], MainForm.ColorScheme[11]);
            settingsForm.color5box.BackColor = Color.FromArgb(MainForm.ColorScheme[12], MainForm.ColorScheme[13], MainForm.ColorScheme[14]);
            settingsForm.color5box2.BackColor = Color.FromArgb(MainForm.ColorScheme[15], MainForm.ColorScheme[16], MainForm.ColorScheme[17]);
            settingsForm.color6box.BackColor = Color.FromArgb(MainForm.ColorScheme[18], MainForm.ColorScheme[19], MainForm.ColorScheme[20]);
            settingsForm.color7box.BackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.color7box2.BackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);

            settingsForm.f.BackPanel.BackColor = Color.FromArgb(MainForm.ColorScheme[12], MainForm.ColorScheme[13], MainForm.ColorScheme[14]);

            settingsForm.f.sub1panel.BackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.sub2panel.BackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);

            settingsForm.f.Sub1Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);
            settingsForm.f.Sub1Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);
            settingsForm.f.Sub1Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);
            settingsForm.f.Sub2Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);
            settingsForm.f.Sub2Button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);
            settingsForm.f.Sub2Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[24], MainForm.ColorScheme[25], MainForm.ColorScheme[26]);

            settingsForm.f.Sub1Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.Sub1Button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.Sub1Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.Sub2Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.Sub2Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);
            settingsForm.f.Sub2Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[21], MainForm.ColorScheme[22], MainForm.ColorScheme[23]);

            settingsForm.f.CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[15], MainForm.ColorScheme[16], MainForm.ColorScheme[17]);
            settingsForm.f.DropdownButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[15], MainForm.ColorScheme[16], MainForm.ColorScheme[17]);
            settingsForm.f.DropdownButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(MainForm.ColorScheme[15], MainForm.ColorScheme[16], MainForm.ColorScheme[17]);

            settingsForm.f.CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[12], MainForm.ColorScheme[13], MainForm.ColorScheme[14]);
            settingsForm.f.DropdownButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[12], MainForm.ColorScheme[13], MainForm.ColorScheme[14]);
            settingsForm.f.DropdownButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(MainForm.ColorScheme[12], MainForm.ColorScheme[13], MainForm.ColorScheme[14]);

            settingsForm.f.Sub1Button1.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.Sub1Button2.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.Sub1Button3.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.Sub2Button1.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.Sub2Button3.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.Sub2Button4.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.CloseButton.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.DropdownButton1.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
            settingsForm.f.DropdownButton2.ForeColor = Color.FromArgb(MainForm.ColorScheme[3], MainForm.ColorScheme[4], MainForm.ColorScheme[5]);
        }
    }
}
