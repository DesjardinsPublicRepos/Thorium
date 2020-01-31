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
                    string foo = Path.GetExtension(MP4toMP3Form.InputData[i].Trim());

                    if (foo == ".mp4" || foo == ".m4a" || foo == ".m4v" || foo == ".f4v" || foo == ".f4a" || foo == ".m4b" || foo == ".m4r" || foo == ".f4b" || foo == ".mov"
                        || foo == ".3gp" || foo == ".3gp2" || foo == ".3g2" || foo == ".3gpp" || foo == ".3gpp2" || foo == ".mpeg" || foo == ".vob" || foo == ".lfx"
                        || foo == ".ogg" || foo == ".oga" || foo == ".ogv" || foo == ".ogx" || foo == ".op1a" || foo == ".op-atom" || foo == ".ts" || foo == "."
                        || foo == ".wmv" || foo == ".wma" || foo == ".asf*" || foo == ".webm" || foo == ".flv" || foo == ".avi" || foo == ".quicktime" || foo == ".hdv"
                        || foo == ".gfx" || foo == ".mpeg-2" || foo == ".mxf" || foo == ".mpeg-ts")

                    {
                        converter.ConvertMedia(MP4toMP3Form.InputData[i].Trim(), Output.Trim() + ("\\" + MP4toMP3Form.InputName[i].Substring(0, MP4toMP3Form.InputName[i].Length - 4) + "." + format), format);
                    }

                    MP4toMP3Form.ProgressState++;
                    if (MP4toMP3Form.ProgressState != 0) UpdateInfoLabel(loadingPopup);
                }
                else if (MP4toMP3Form.InputData[i] == null)
                {
                    MP4toMP3Form.InputData = new string[50];
                    MP4toMP3Form.InputName = new string[50];

                    loadingPopup.Close();
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
