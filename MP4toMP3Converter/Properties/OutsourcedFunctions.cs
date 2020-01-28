using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MP4toMP3Converter;

namespace MP4toMP3Converter.Properties
{
    class OutsourcedFunctions
    {
        public static void ConvertAll(string Output, string format, NReco.VideoConverter.FFMpegConverter converter, LoadingPopup loadingPopup)
        {
            for (int i = 0; i < 50; i++)
            {
                if (MP4toMP3Form.InputData[i] != null && File.Exists("@" + MP4toMP3Form.InputData[i]) == false)
                {
                        converter.ConvertMedia(MP4toMP3Form.InputData[i].Trim(), Output.Trim() + ("\\" + MP4toMP3Form.InputName[i].Substring(0, MP4toMP3Form.InputName[i].Length - 4) + "." + format), format);
                        MP4toMP3Form.ProgressState++;
                        UpdateInfoLabel(loadingPopup);
                }
                else if (MP4toMP3Form.InputData[i] == null)
                {
                    MP4toMP3Form.thread.Abort();
                    MP4toMP3Form.InputData = new string[50];
                    MP4toMP3Form.InputName = new string[50];

                    break;
                }
            }
        }

        public static void UpdateInfoLabel(LoadingPopup loadingPopup)
        {
            try
            {
                if (loadingPopup.InfoLabel1.InvokeRequired)
                {
                    loadingPopup.InfoLabel1.Invoke((MethodInvoker)delegate ()
                    {
                        UpdateInfoLabel(loadingPopup);
                    });
                }
                else
                {
                    int completeState = Convert.ToInt32(loadingPopup.InfoLabel1.Text.Substring(14, 1));
                    int newState = Convert.ToInt32(loadingPopup.InfoLabel1.Text.Substring(12, 1)) + 1;
                    
                    loadingPopup.InfoLabel1.Text = "Loading... (" + newState + "/" + completeState + ")";
                }
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        public static void LoadWebsite(string http)
        {
            System.Diagnostics.Process.Start(http);
        }
    }
}
