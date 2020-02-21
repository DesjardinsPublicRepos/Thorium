using System;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class ConvertForm : Form
    {
        public static string Output;
        public static string[] InputData = new string[50], InputName = new string[50];
        public static LoadingPopup loadingPopup;
        public static NReco.VideoConverter.FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
        public static int ProgressState;
        public static Thread thread;

        private readonly string convertOptions;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public ConvertForm(string convertOptions)
        {
            this.convertOptions = convertOptions;

            InitializeComponent();
            CustomColors();
            setFilepathMode();
            fontInit();
        }

        #region onClicks

        private void InputBoxClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true};
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    Debug.WriteLine(file);
                    AddInputFile(file, Path.GetFileName(file));
                }
                DragDropLabel.Dispose();
                GC.Collect();
            }
        }

        private void OutputBoxClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Output = folderBrowserDialog.SelectedPath;
            }
            OutputPathLabel.Text = Output;
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            if (InputData[0] != null)
            {
                OutsourcedFunctions.getConvertableFiles(InputData, InputName);
                InputData = InputData.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                InputName = InputName.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                string OutputFormat = formatDropdown.Text;
                ProgressState = InputData.Length;

                loadingPopup = new LoadingPopup(convertOptions);
                thread = new Thread(new ThreadStart(StartLoadingPopup));
                thread.Start();

                Thread t = new Thread(() => convertLauncher(OutputFormat));
                t.Start();
                ItemListBox.Items.Clear();
            }
        }
        
        #endregion

        #region DragDrop

        private void ListBoxDragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                AddInputFile(Path.GetFullPath(file), Path.GetFileName(file));

                DragDropLabel.Dispose();
                GC.Collect();
            }
        }

        private void ListBoxDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        #endregion

        #region enterPressed

        private void InputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (OutsourcedFunctions.enterHandling(e) == true) 
            {
                AddInputFile(InputPathLabel.Text, System.IO.Path.GetFileName(InputPathLabel.Text));
                InputPathLabel.Text = null;
            }
        }

        private void OutputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (OutsourcedFunctions.enterHandling(e) == true) 
            {
                Output = OutputPathLabel.Text;
                ConvertButton.Focus();
            }
        }

        #endregion

        #region SecondaryMethods

        private void convertLauncher(string OutputFormat)
        {
            try
            {
                OutsourcedFunctions.ConvertAll(Output, OutputFormat, converter, loadingPopup, InputData, convertOptions);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void StartLoadingPopup()
        {
            Application.Run(loadingPopup);
        }

        private void AddInputFile(string FilePath, string FileName)
        {
            for (int i = 0; i < 50; i++)
            {
                if (InputData[i] == null)
                {
                    InputData[i] = FilePath;
                    InputName[i] = FileName;
                    Debug.WriteLine("added '" + FileName + "' to InputData");

                    ItemListBox.Items.Add(Path.GetFileNameWithoutExtension(FilePath));
                    break; 
                }
            }
        }
        #endregion

        #region init

        private void CustomColors()
        {
            ItemListBox.BackColor = MainForm.getCustomColor(8);
            ItemListBox.ForeColor = MainForm.getCustomColor(2);

            DragDropLabel.ForeColor = MainForm.getCustomColor(5);
            DragDropLabel.BackColor = MainForm.getCustomColor(3);

            this.BackColor = MainForm.getCustomColor(7);

            formatDropdown.ForeColor = MainForm.getCustomColor(5);
            formatDropdown.BackColor = MainForm.getCustomColor(4);

            ConvertButton.BackColor = MainForm.getCustomColor(8);
            ConvertButton.Activecolor = MainForm.getCustomColor(8);
            ConvertButton.Normalcolor = MainForm.getCustomColor(8);
            ConvertButton.OnHovercolor = MainForm.getCustomColor(6);
            ConvertButton.Textcolor = MainForm.getCustomColor(2);
            ConvertButton.OnHoverTextColor = MainForm.getCustomColor(2);

            OutpuFormatLabel.ForeColor = MainForm.getCustomColor(4);
            OutpuFormatLabel.BackColor = MainForm.getCustomColor(7);

            OutputLabel.BackColor = MainForm.getCustomColor(7);
            OutputLabel.ForeColor = MainForm.getCustomColor(3);

            InputLabel.BackColor = MainForm.getCustomColor(7);
            InputLabel.ForeColor = MainForm.getCustomColor(3);

            OpenInput.BackColor = MainForm.getCustomColor(4);

            OpenOutput.BackColor = MainForm.getCustomColor(4);

            InputPathLabel.ForeColor = MainForm.getCustomColor(2);
            InputPathLabel.HintForeColor = MainForm.getCustomColor(2);
            InputPathLabel.BackColor = MainForm.getCustomColor(7);
            InputPathLabel.LineFocusedColor = MainForm.getCustomColor(3);
            InputPathLabel.LineIdleColor = MainForm.getCustomColor(4);
            InputPathLabel.LineMouseHoverColor = MainForm.getCustomColor(3);

            OutputPathLabel.ForeColor = MainForm.getCustomColor(2);
            OutputPathLabel.HintForeColor = MainForm.getCustomColor(2);
            OutputPathLabel.BackColor = MainForm.getCustomColor(7);
            OutputPathLabel.LineFocusedColor = MainForm.getCustomColor(3);
            OutputPathLabel.LineIdleColor = MainForm.getCustomColor(4);
            OutputPathLabel.LineMouseHoverColor = MainForm.getCustomColor(3);

            this.Size = new Size(760, 580);
        }

        private void setFilepathMode()
        {

            if (convertOptions != "convert")
            {
                ConvertButton.Text = "combine";
            }

            if (this.convertOptions != "combine")
            {
                Output = "C:\\Users\\" + Environment.UserName + "\\Music";
            }
            else
            {
                Output = "C:\\Users\\" + Environment.UserName + "\\Videos";
            }

            if (MainForm.customFilepathEnalbled[1] == true)
            {
                Output = MainForm.customFilepaths[1];
            }
            OutputPathLabel.Text = Output;


            if (convertOptions == "convert" | convertOptions == "convertCombine")
            {
                formatDropdown.SelectedIndex = 3;
            }
            else
            {
                formatDropdown.Items.Clear();
                string[] items = new string[] { "mp4", "avi", "flv", "mov", "webm", "ogg", "oga", "ogv" };

                foreach (string item in items)
                {
                    formatDropdown.Items.Add(item);
                }

                formatDropdown.SelectedIndex = 0;
            }
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

            o.changeFont(new Control[] { DragDropLabel, ItemListBox }, new Font(fonts.Families[0], 11.25f));

            o.changeFont(new Control[] { InputPathLabel, OutputPathLabel, OutpuFormatLabel, formatDropdown, OutputPathLabel, ConvertButton}, new Font(fonts.Families[0], 9.75f));

            o.changeFont(new Control[] { InputLabel, OutputLabel }, new Font(fonts.Families[0], 8.25f));
        }
        #endregion
    }
}
