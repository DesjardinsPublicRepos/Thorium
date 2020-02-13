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
        private readonly string convertOptions;

        public LoadingPopup(string convertOptions)
        {
            this.convertOptions = convertOptions;
            InitializeComponent();
            if (convertOptions == "convert") InfoLabel1.Text = "Loading... (1/" + Math.Abs(ConvertForm.ProgressState).ToString() + ")";
        }

        #region onClicks

        private void AbortButton_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];

            if (convertOptions == "convert")
            {
                ConvertForm.converter.Stop(); 
            }
            else
            {
                ConvertForm.converter.Abort();
            }
            

            Application.ExitThread();
        }

        #endregion
    }
}
