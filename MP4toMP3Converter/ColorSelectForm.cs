using System;
using System.Drawing;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class ColorSelectForm : Form
    {
        private readonly SettingsForm settingsForm;
        private readonly byte[] byteArray;

        public ColorSelectForm(SettingsForm settingsForm, byte[] b)
        {
            this.settingsForm = settingsForm;
            byteArray = b;
            InitializeComponent();
            textBox1.Text = MainForm.ColorScheme[b[0]].ToString();
            textBox2.Text = MainForm.ColorScheme[b[1]].ToString();
            textBox3.Text = MainForm.ColorScheme[b[2]].ToString();
        }
        
        #region onClicks

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] before = MainForm.ColorScheme;
            try
            {
                MainForm.ColorScheme[byteArray[0]] = Convert.ToByte(textBox1.Text);
                MainForm.ColorScheme[byteArray[1]] = Convert.ToByte(textBox2.Text);
                MainForm.ColorScheme[byteArray[2]] = Convert.ToByte(textBox3.Text);
            }
            catch (FormatException) { MainForm.ColorScheme = before; }
            catch (OverflowException) { MainForm.ColorScheme = before; }


            SettingsForm.updateColors(settingsForm);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region TextBoxesTextChanged

        private void TextBoxesTextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == textBox1)
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
                else if (sender == textBox2)
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
                else if (sender == textBox3)
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
            }
            catch(Exception) { }
        }

        private void TextBoxesKeyDown(object sender, KeyEventArgs e)
        {
            if (OutsourcedFunctions.enterHandling(e) == true)
            {
                if (sender == textBox1)
                {
                    textBox2.Focus();
                }
                else if (sender == textBox2)
                {
                    textBox3.Focus();
                }
                else if (sender == textBox3)
                {
                    button1.Focus();
                }
            }
        }
        #endregion

    }
}
