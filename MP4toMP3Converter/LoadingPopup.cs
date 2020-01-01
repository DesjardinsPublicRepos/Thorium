using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4toMP3Converter
{
    public partial class LoadingPopup : Form
    {
        public LoadingPopup()
        {
            InitializeComponent();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
