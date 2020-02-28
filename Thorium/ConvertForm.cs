using System;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections.Generic;

using Thorium.Properties;

namespace Thorium
{
    public partial class ConvertForm : Form
    {
        public static string Output;
        public static List<string> InputData = null;
        public static LoadingPopup loadingPopup;
        public static NReco.VideoConverter.FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
        public static int ProgressState;
        public static Thread thread;

        private readonly string convertOptions;

        public ConvertForm(string convertOptions)
        {
            this.convertOptions = convertOptions;
            InputData = null;

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
                    AddInputFile(file);
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
            if (InputData != null)
            {
                InputData = OutsourcedFunctions.getConvertableFiles(InputData);
                //data = data.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                string outputFormat = formatDropdown.Text;
                ProgressState = InputData.Count;

                foreach (string s in InputData)
                {
                    Debug.WriteLine(s);
                }

                loadingPopup = new LoadingPopup(convertOptions);
                thread = new Thread(new ThreadStart(StartLoadingPopup));
                thread.Start();

                Thread t = new Thread(() => convertLauncher(outputFormat, InputData));
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
                AddInputFile(Path.GetFullPath(file));

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
                AddInputFile(InputPathLabel.Text);
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

        private void convertLauncher(string OutputFormat, List<string> data)
        {
            try
            {
                OutsourcedFunctions.ConvertAll(Output, OutputFormat, converter, loadingPopup, data, convertOptions);
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

        private void AddInputFile(string FilePath)
        {
            if (InputData == null) InputData = new List<string>();
            InputData.Add(FilePath);

            ItemListBox.Items.Add(Path.GetFileNameWithoutExtension(FilePath));
            Debug.WriteLine("added '" + Path.GetFileName(FilePath) + "' to InputData");
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
            byte[] fontData = Resources.font_slim;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint dummy = 0;

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            MainForm.fonts.AddMemoryFont(fontPtr, Resources.font_slim.Length);
            MainForm.AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.font_slim.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            OutsourcedFunctions o = new OutsourcedFunctions();

            o.changeFont(new Control[] { DragDropLabel, ItemListBox }, new Font(MainForm.fonts.Families[0], 11.25f));

            o.changeFont(new Control[] { InputPathLabel, OutputPathLabel, OutpuFormatLabel, formatDropdown, OutputPathLabel, ConvertButton}, new Font(MainForm.fonts.Families[0], 9.75f));

            o.changeFont(new Control[] { InputLabel, OutputLabel }, new Font(MainForm.fonts.Families[0], 8.25f));
        }
        #endregion
    }
}
