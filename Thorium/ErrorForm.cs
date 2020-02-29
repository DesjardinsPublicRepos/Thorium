using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4toMP3Converter
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string heading, string text)
        {
            InitializeComponent();
            this.text.Text = text;
            this.heading.Text = heading;
            fontInit();
        }


        private void fontInit()
        {
            //change fonts
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
