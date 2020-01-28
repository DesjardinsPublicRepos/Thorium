using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class MP4toMP3Form : Form
    {
        #region GlobalVars
        public static string Output;


        public static string[] InputData = new string[50], InputName = new string[50];

        public static LoadingPopup loadingPopup;
        public static NReco.VideoConverter.FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
        public static int ProgressState;
        public static Thread thread;

        #endregion

        #region PrimaryMethods

        public MP4toMP3Form()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Output = @"C:\Users\Fabian\Downloads";
            OutputBox.Text = Output;
        }

        private void InputBoxClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "Video file|*.mp4" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddInputFile(openFileDialog.FileName, openFileDialog.SafeFileName);

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
            OutputBox.Text = Output;
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            ProgressState = -GetInputFileAmount();
            Debug.WriteLine(GetInputFileAmount());
            thread = new Thread(new ThreadStart(StartLoadingPopup));
            thread.Start(); 

            Nito.AspNetBackgroundTasks.BackgroundTaskManager.Run(() =>
            {
                try
                {
                    OutsourcedFunctions.ConvertAll(Output, "mp3", converter);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
            ItemListBox.Items.Clear();
        }

        private void ListBoxDragDrop(object sender, DragEventArgs e)
        {
            string[] droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
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

        private void InputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13) //=enter
            {
                AddInputFile(InputBox.Text, System.IO.Path.GetFileName(InputBox.Text));
                InputBox.Text = null;   
            }
        }

        private void OutputBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13) 
            {
                Output = OutputBox.Text;
            }
        }

        #endregion

        #region SecondaryMethods


        public void StartLoadingPopup()
        {
            loadingPopup = new LoadingPopup();
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

        private int GetInputFileAmount()
        {
            for (int i = 0; i < 50; i++)
            {
                if (InputData[i] == null) return i;
            }
            return 50;
        }

        #endregion
    }
}

/*
Label label = new Label();
            this.Controls.Add(label);

            LoadingPopup(label);
            test

            var timer = new System.Windows.Forms.Timer { Interval = 800 };
            timer.Tick += (o, args) =>
            {
                if (ProgressState == 0)
                {
                    label.Text = "Compiling complete!";
                    timer.Dispose();

                    ItemListBox.Items.Clear();
                    InputData = new string[50];
                    InputName = new string[50];
                }
                label.Text += ".";
                if (label.Text == "loading .....")
                {
                    label.Text = "loading .";
                }

                // DISPOSE LABEL
            };
            timer.Start();


    private void LoadingPopup(Label label)
        {
            LoadingPopup loadingPopup = new LoadingPopup();
            loadingPopup.ShowDialog();

            label.Location = new Point(64, 133);
            label.Size = new Size(615, 304);
            label.BackColor = Color.FromArgb(255, 230, 191, 255);
            label.TextAlign = ContentAlignment.BottomCenter;

            label.Font = ItemListBox.Font;
            label.Padding = new Padding(0, 0, 0, 60);
            label.Text = "loading ";
            label.BringToFront();
        }


    */
