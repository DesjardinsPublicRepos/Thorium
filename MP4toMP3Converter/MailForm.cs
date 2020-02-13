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

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
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
    }
}
