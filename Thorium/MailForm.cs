﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class MailForm : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public MailForm()
        {
            InitializeComponent();
            CustomColors();
            fontInit();
        }

        #region onClicks

        private void sendButtonClick(object sender, EventArgs e)
        {
            try
            {
                OutsourcedFunctions.sendMail(MailBox.Text, "Desjardinslegedz@icloud.com", SubjectBox.Text, BodyTextBox.Text, "smtp-mail.outlook.com", MailBox.Text, PasswordBox.Text);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Please check if your inputted data is correct. Maybe the Name of the exception helps: " + ee, "Oops, something went wrong there!", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Textboxes

        private void TextboxesEnter(object sender, EventArgs e)
        {
            var textBox = (Bunifu.Framework.UI.BunifuMaterialTextbox)sender;

            if (textBox.Text == "Password" | textBox.Text == "E - Mail" | textBox.Text == "Subject")
            {
                textBox.Text = ""; 
            }
            textBox.ForeColor = Color.White;

            if (sender == PasswordBox)
            {
                PasswordBox.isPassword = true;
            }
        }

        private void TextBoxesKeyDown(object sender, KeyEventArgs e)
        {
            if (OutsourcedFunctions.enterHandling(e) == true) 
            {
                if (sender == SubjectBox)
                {
                    MailBox.Focus();
                }
                else if (sender == MailBox)
                {
                    PasswordBox.Focus();
                }
                else if (sender == PasswordBox)
                {
                    BodyTextBox.Focus();
                }
            }
        }

        private void TextBoxesLeave(object sender, EventArgs e)
        {
            if (sender == SubjectBox && SubjectBox.Text == "")
            {
                SubjectBox.Text = "Subject";
            }
            else if (sender == MailBox && MailBox.Text == "")
            {
                MailBox.Text = "E - Mail";
            }
            else if (sender == PasswordBox && PasswordBox.Text == "")
            {
                PasswordBox.isPassword = false;
                PasswordBox.Text = "Password";
            }
        }

        #endregion

        #region init

        private void CustomColors()
        {
            this.BackColor = MainForm.getCustomColor(7);

            Heading.ForeColor = MainForm.getCustomColor(2);

            SubjectBox.ForeColor = MainForm.getCustomColor(2);
            SubjectBox.LineIdleColor = MainForm.getCustomColor(4);
            SubjectBox.LineFocusedColor = MainForm.getCustomColor(3);
            SubjectBox.LineMouseHoverColor = MainForm.getCustomColor(3);

            MailBox.ForeColor = MainForm.getCustomColor(2);
            MailBox.LineIdleColor = MainForm.getCustomColor(4);
            MailBox.LineFocusedColor = MainForm.getCustomColor(3);
            MailBox.LineMouseHoverColor = MainForm.getCustomColor(3);

            PasswordBox.ForeColor = MainForm.getCustomColor(2);
            PasswordBox.LineIdleColor = MainForm.getCustomColor(4);
            PasswordBox.LineFocusedColor = MainForm.getCustomColor(3);
            PasswordBox.LineMouseHoverColor = MainForm.getCustomColor(3);

            BodyTextBox.BackColor = MainForm.getCustomColor(8);
            BodyTextBox.ForeColor = MainForm.getCustomColor(2);

            BodyTextBox2.BackColor = MainForm.getCustomColor(8);
            
            sendButton.BackColor = MainForm.getCustomColor(8);
            sendButton.Activecolor = MainForm.getCustomColor(8);
            sendButton.Normalcolor = MainForm.getCustomColor(8);
            sendButton.OnHovercolor = MainForm.getCustomColor(6);
            sendButton.ForeColor = MainForm.getCustomColor(2);
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

            o.changeFont(new Control[] { Heading }, new Font(fonts.Families[0], 26.25f));

            o.changeFont(new Control[] { SubjectBox, MailBox, PasswordBox, BodyTextBox, sendButton }, new Font(fonts.Families[0], 9.75f));
        }

        #endregion
    }
}
