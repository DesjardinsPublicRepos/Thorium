using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MP4toMP3Converter
{
    public partial class ColorSelectForm : Form
    {
        private SettingsForm settingsForm;
        private byte[] byteArray;

        public ColorSelectForm(SettingsForm settingsForm, byte[] b)
        {
            this.settingsForm = settingsForm;
            byteArray = b;
            InitializeComponent();
            this.textBox1.Text = MainForm.ColorScheme[b[0]].ToString();
            this.textBox2.Text = MainForm.ColorScheme[b[1]].ToString();
            this.textBox3.Text = MainForm.ColorScheme[b[2]].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.ColorScheme[byteArray[0]] = Convert.ToByte(textBox1.Text);
                MainForm.ColorScheme[byteArray[1]] = Convert.ToByte(textBox2.Text);
                MainForm.ColorScheme[byteArray[2]] = Convert.ToByte(textBox3.Text);
            }
            catch (OverflowException) { }

            SettingsForm.updateColors(settingsForm);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 256)
                {
                    pictureBox1.BackColor = Color.FromArgb(Convert.ToByte(textBox1.Text), pictureBox1.BackColor.G, pictureBox1.BackColor.B);
                }
                if (textBox1.Text.Length > 2 | Convert.ToInt32(textBox1.Text) > 25)
                {
                    textBox2.Focus();
                }
            }
            catch (FormatException) { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox2.Text) < 256)
                {
                    pictureBox1.BackColor = Color.FromArgb(pictureBox1.BackColor.R, Convert.ToByte(textBox2.Text), pictureBox1.BackColor.B);
                }
                if (textBox2.Text.Length > 2 | Convert.ToInt32(textBox2.Text) > 25)
                {
                    textBox3.Focus();
                }
            }
            catch (FormatException) { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox3.Text) < 256)
                {
                    pictureBox1.BackColor = Color.FromArgb(pictureBox1.BackColor.R, pictureBox1.BackColor.G, Convert.ToByte(textBox3.Text));
                }
                if (textBox3.Text.Length > 2 | Convert.ToInt32(textBox3.Text) > 25)
                {
                    button1.Focus();
                }
            }
            catch (FormatException) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
