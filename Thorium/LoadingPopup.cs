using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections.Generic;

using Thorium.Properties;

namespace Thorium
{
    public partial class LoadingPopup : Form
    {
        private readonly string convertOptions;

        public LoadingPopup(string convertOptions)
        {
            this.convertOptions = convertOptions;
            InitializeComponent();
            fontInit();
            if (convertOptions == "convert") InfoLabel1.Text = "Loading... (1/" + Math.Abs(ConvertForm.ProgressState).ToString() + ")";
        }

        #region onClicks

        private void AbortButton_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new List<string>();

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

        #region init

        private void fontInit()
        {
            byte[] fontData = Resources.font_slim;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint dummy = 0;

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            MainForm.fonts.AddMemoryFont(fontPtr, Resources.font_slim.Length);
            MainForm.AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.font_slim.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            OutsourcedFunctions o = new OutsourcedFunctions();

            o.changeFont(new Control[] { InfoLabel1 }, new Font(MainForm.fonts.Families[0], 20f));

            o.changeFont(new Control[] { InfoLabel2 }, new Font(MainForm.fonts.Families[0], 12f));
        }

        #endregion
    }
}
