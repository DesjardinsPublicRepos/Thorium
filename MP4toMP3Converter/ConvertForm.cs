﻿using System;
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
    public partial class ConvertForm : Form
    {
        #region GlobalVars
        public static string Output;

        private string convertOptions;

        public static string[] InputData = new string[50], InputName = new string[50];

        public static LoadingPopup loadingPopup;
        public static NReco.VideoConverter.FFMpegConverter converter = new NReco.VideoConverter.FFMpegConverter();
        public static int ProgressState;
        public static Thread thread;

        #endregion

        #region PrimaryMethods

        public ConvertForm(string convertOptions)
        {
            this.convertOptions = convertOptions;
            this.DoubleBuffered = true;

            InitializeComponent();
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

            if (convertOptions != "convert")
            {
                ConvertLabel.Text = "combine to";
                ConvertLabel.Location = new Point(279, 546);
            }
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Output = "C:\\Users\\" + Environment.UserName + "\\Music";
            OutputBox.Text = Output;
        }

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
            OutputBox.Text = Output;
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            if (InputData[0] != null)
            {
                OutsourcedFunctions.getConvertableFiles(InputData);
                InputData = InputData.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                //MainForm.ActiveForm.Enabled = false;

                string OutputFormat = formatDropdown.Text;
                ProgressState = InputData.Length;

                loadingPopup = new LoadingPopup(convertOptions);
                thread = new Thread(new ThreadStart(StartLoadingPopup));
                thread.Start();

                Nito.AspNetBackgroundTasks.BackgroundTaskManager.Run(() =>
                {
                    try
                    {
                        OutsourcedFunctions.ConvertAll(Output, OutputFormat, converter, loadingPopup, InputData, convertOptions);
                    }
                    catch (Exception ex)
                    { 
                        Debug.WriteLine(ex);
                    }
                });
                ItemListBox.Items.Clear();
            }
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
    }
}
