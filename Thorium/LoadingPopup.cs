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
using System.Drawing.Text;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class LoadingPopup : Form
    {
        private readonly string convertOptions;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

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

        #region init

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

            o.changeFont(new Control[] { InfoLabel1 }, new Font(fonts.Families[0], 20f));

            o.changeFont(new Control[] { InfoLabel2 }, new Font(fonts.Families[0], 12f));
        }

        #endregion
    }
}
