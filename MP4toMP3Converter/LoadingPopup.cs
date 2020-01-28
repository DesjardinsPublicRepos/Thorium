using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using MP4toMP3Converter;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class LoadingPopup : Form
    {

        public LoadingPopup()
        {
            InitializeComponent();
            InfoLabel1.Text = "Loading... (1/" + Math.Abs(MP4toMP3Form.ProgressState).ToString() + ")";
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            MP4toMP3Form.converter.Stop();
            
            MP4toMP3Form.InputData = new string[50];
            MP4toMP3Form.InputName = new string[50];

            MP4toMP3Form.thread.Abort();
        }
    }
}
