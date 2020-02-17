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
using System.ComponentModel;
using System.Drawing;

using System.Net;
using System.Net.Mail;
using System.Web;

using System.Drawing.Text;

namespace MP4toMP3Converter.Properties
{
    class OutsourcedFunctions
    {
        public static void ConvertAll(string output, string format, NReco.VideoConverter.FFMpegConverter converter, LoadingPopup loadingPopup, string[] inputData, string settings)
        {
            for (int i = 0; i < inputData.Length; i++)
            {
                if (inputData[i] != null)
                {
                    if (settings == "convert")
                    {
                        converter.ConvertMedia(inputData[i].Trim(), output.Trim() + ("\\" + ConvertForm.InputName[i].Substring(0, ConvertForm.InputName[i].Length - 4) + "." + format), format);
                    }
                    else if (settings == "combine")
                    {
                        converter.ConcatMedia(inputData, output.Trim() + ("\\CombinedFile '" + ConvertForm.InputName[0].Substring(0, ConvertForm.InputName[0].Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format), format, new NReco.VideoConverter.ConcatSettings());
                        break;
                    }
                    else
                    {
                        string outPath;
                        if (MainForm.customFilepathEnalbled[0] == true | MainForm.customFilepaths[0] == "Default")
                        {
                            outPath = MainForm.customFilepaths[0];
                        }
                        else outPath = "C:\tempFile";


                        if (format == "mp3")
                        {
                            converter.ConcatMedia(inputData, output.Trim() + ("\\ConvertedFile '" + ConvertForm.InputName[0].Substring(0, ConvertForm.InputName[0].Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format), format, new NReco.VideoConverter.ConcatSettings());
                            break;
                        }
                        else
                        {
                            converter.ConcatMedia(inputData, @outPath + "tempFile.mp4", "mp4", new NReco.VideoConverter.ConcatSettings());
                            converter.ConvertMedia(@outPath + "tempFile.mp4", output.Trim() + "\\ConvertedFile '" + ConvertForm.InputName[0].Substring(0, ConvertForm.InputName[0].Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format, format);

                            File.Delete(@outPath + "tempFile.mp4");
                            break;
                        }
                    }

                    ConvertForm.ProgressState++;
                    if (ConvertForm.ProgressState != 0) UpdateInfoLabel(loadingPopup);
                }
                if (i == inputData.Length)
                {
                    break;
                }
            }
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
                    
            Thread.Sleep(3);
            closePopup(loadingPopup);
        }

        public static void getConvertableFiles(string[] inputData)
        {
            for (int i = 0; i < 50; i++)
            {
                if (inputData[i] != null)
                {
                    if (File.Exists("@" + inputData[i]) == true | IsVideo(Path.GetExtension(inputData[i].Trim())) == false)
                    {
                        inputData[i] = null;
                    }
                }
            }
        }

        public static void closePopup(LoadingPopup loadingPopup)
        {
            try
            {
                if (loadingPopup.InvokeRequired)
                {
                    loadingPopup.Invoke((MethodInvoker)delegate ()
                    {
                        closePopup(loadingPopup);
                    });
                }
                else
                {
                    loadingPopup.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
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

        public static void sendMail(string sender, string reciever, string subject, string body, string smtp, string userName, string password)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(sender, reciever, subject, body);
                SmtpClient smtpClient = new SmtpClient(smtp, 587);

                smtpClient.Credentials = new NetworkCredential(userName, password);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);

                if (e.GetType().FullName == "System.FormatException")
                {

                    MessageBox.Show("It seems like your inputted Data has not the correct format. Maybe the Name of the exception helps: " + e.GetType().FullName, "Oops, something went wrong there!", MessageBoxButtons.OK);
                }
                else if (e.GetType().FullName == "System.Net.Mail.SmtpException")
                {

                    MessageBox.Show("It seems like there went something wrong with the authentication. Please check if your inputted data is correct. Maybe the Name of the exception helps: " + e.GetType().FullName, "Oops, something went wrong there!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please check if your inputted data is correct. Maybe the Name of the exception helps: " + e.GetType().FullName, "Oops, something went wrong there!", MessageBoxButtons.OK);
                }
            }
        }
        
        public static Control GetControlByName(string name, Form form)
        {
            foreach (Control c in form.Controls)
                if (c.Name == name)
                    return c;

            return null;
        }

        private string getThumbnail(string url)
        {
            string thumb = string.Empty;
            if (url == "")
            {
                return "";
            }

            if (url.IndexOf("=") > 0)
            {
                thumb = url.Split('=')[1];
            }
            else if (url.IndexOf("/v/") > 0)
            {
                string videoCode = url.Substring(url.IndexOf("/v/") + 3);
                int ind = videoCode.IndexOf("?");
                thumb = videoCode.Substring(0, ind == -1 ? videoCode.Length : ind);
            }
            else if (url.IndexOf('/') < 6)
            {
                thumb = url.Split('/')[3];
            }
            else if (url.IndexOf('/') > 6)
            {
                thumb = url.Split('/')[1];
            }

            return "http://img.youtube.com/vi/" + thumb + "/mqdefault.jpg";
        }

        private static bool IsVideo(string foo)
        {
            if (foo == ".mp4" || foo == ".m4a" || foo == ".m4v" || foo == ".f4v" || foo == ".f4a" || foo == ".m4b" || foo == ".m4r" || foo == ".f4b" || foo == ".mov"
                        || foo == ".3gp" || foo == ".3gp2" || foo == ".3g2" || foo == ".3gpp" || foo == ".3gpp2" || foo == ".mpeg" || foo == ".vob" || foo == ".lfx"
                        || foo == ".ogg" || foo == ".oga" || foo == ".ogv" || foo == ".ogx" || foo == ".op1a" || foo == ".op-atom" || foo == ".ts" || foo == "."
                        || foo == ".wmv" || foo == ".wma" || foo == ".asf*" || foo == ".webm" || foo == ".flv" || foo == ".avi" || foo == ".quicktime" || foo == ".hdv"
                        || foo == ".gfx" || foo == ".mpeg-2" || foo == ".mxf" || foo == ".mpeg-ts")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool enterHandling(KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return true;
            }
            else return false;
        }

        public void changeFont(Control[] controls, Font font)
        {
            foreach (Control c in controls)
            {
                c.Font = font;
            }
        }
    }
}
