using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace MP4toMP3Converter.Properties
{
    class OutsourcedFunctions
    {
        public static void ConvertAll(string output, string format, NReco.VideoConverter.FFMpegConverter converter, LoadingPopup loadingPopup, List<string> inputData, string settings)
        {
            foreach (string input in inputData)
            {
                string name = Path.GetFileName(input);

                if (input != null)
                {
                    if (settings == "convert")
                    {
                        converter.ConvertMedia(input.Trim(), output.Trim() + ("\\" + name.Substring(0, name.Length - 4) + "." + format), format);
                    }
                    else if (settings == "combine")
                    {

                        converter.ConcatMedia(inputData.ToArray(), output.Trim() + ("\\CombinedFile '" + name.Substring(0, name.Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format), format, new NReco.VideoConverter.ConcatSettings());
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
                            converter.ConcatMedia(inputData.ToArray(), output.Trim() + ("\\ConvertedFile '" + name.Substring(0, name.Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format), format, new NReco.VideoConverter.ConcatSettings());
                            break;
                        }
                        else
                        {
                            converter.ConcatMedia(inputData.ToArray(), @outPath + "tempFile.mp4", "mp4", new NReco.VideoConverter.ConcatSettings());
                            converter.ConvertMedia(@outPath + "tempFile.mp4", output.Trim() + "\\ConvertedFile '" + name.Substring(0, name.Length - 4) + "' and " + (ConvertForm.ProgressState - 1) + " others" + "." + format, format);

                            File.Delete(@outPath + "tempFile.mp4");
                            break;
                        }
                    }

                    ConvertForm.ProgressState++;

                    if (ConvertForm.ProgressState != 0) UpdateInfoLabel(loadingPopup);
                }
            }
            ConvertForm.InputData = null;

            Thread.Sleep(3);
            closePopup(loadingPopup);
        }

        public static List<string> getConvertableFiles(List<string> inputData)
        {
            string[] files = inputData.ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i] != null)
                {
                    if (File.Exists("@" + files[i]) == true | IsVideo(Path.GetExtension(files[i].Trim())) == false)
                    {
                        files[i] = null;
                    }
                    else Debug.WriteLine("loool");
                }
            }
            List<string> l = files.ToList();

            l.RemoveAll(item => item == null);

            return l;
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
                SmtpClient smtpClient = new SmtpClient(smtp, 587)
                {
                    Credentials = new NetworkCredential(userName, password),
                    EnableSsl = true
                };
                smtpClient.Send(mailMessage);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);

                if (e.GetType().FullName == "System.FormatException")
                {
                    Thread thread = new Thread(() => showForm(new ErrorForm("Something went wrong here.", "It seems like your inputted Data has not the correct format. Maybe the Name of the exception helps: " + e.GetType().FullName)));
                    thread.Start();
                }
                else if (e.GetType().FullName == "System.Net.Mail.SmtpException")
                {
                    Thread thread = new Thread(() => showForm(new ErrorForm("Something went wrong here.", "It seems like there went something wrong with the authentication. Please check if your inputted data is correct. Maybe the Name of the exception helps: " + e.GetType().FullName)));
                    thread.Start();
                }
                else
                {
                    Thread thread = new Thread(() => showForm(new ErrorForm("Something went wrong here.", "Please check if your inputted data is correct. Maybe the Name of the exception helps: " + e.GetType().FullName)));
                    thread.Start();
                }
            }
        }

        public static void showForm(Form form)
        {
            Application.Run(form);
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

    #region BackgroundTasks

    public sealed class tasks : IRegisteredObject
    {
        private readonly CancellationTokenSource abort;

        private readonly AsyncCountdownEvent count;

        private readonly Task completed;

        public tasks()
        {
            abort = new CancellationTokenSource();
            count = new AsyncCountdownEvent(1);
            abort.Token.Register(() => count.Signal(), useSynchronizationContext: false);

            HostingEnvironment.RegisterObject(this);

            completed = count.WaitAsync().ContinueWith(
                _ => HostingEnvironment.UnregisterObject(this),
                CancellationToken.None,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);
        }

        public CancellationToken Abort { get { return abort.Token; } }

        void IRegisteredObject.Stop(bool immediate)
        {
            abort.Cancel();

            if (immediate)
                completed.Wait();
        }

        private void Register(Task task)
        {
            count.AddCount();

            task.ContinueWith(
                _ => count.Signal(),
                CancellationToken.None,
                TaskContinuationOptions.ExecuteSynchronously,
                TaskScheduler.Default);
        }

        public void Run(Func<Task> operation)
        {
            Register(Task.Run(operation));
        }

        public void Run(Action operation)
        {
            Register(Task.Run(operation));
        }
    }

    [DebuggerDisplay("CurrentCount = {count}")]
    [DebuggerTypeProxy(typeof(DebugView))]

    public sealed class AsyncCountdownEvent
    {
        private readonly TaskCompletionSource<object> tcs;

        private int count;

        public AsyncCountdownEvent(int countt)
        {
            tcs = new TaskCompletionSource<object>();
            count = countt;
        }

        public Task WaitAsync()
        {
            return tcs.Task;
        }

        private void ModifyCount(int signalCount)
        {
            if (Interlocked.Add(ref count, signalCount) == 0)
                tcs.TrySetResult(null);
        }

        public void AddCount()
        {
            ModifyCount(1);
        }

        public void Signal()
        {
            ModifyCount(-1);
        }

        [DebuggerNonUserCode]
        private sealed class DebugView
        {
            private readonly AsyncCountdownEvent ce;

            public DebugView(AsyncCountdownEvent cee)
            {
                ce = cee;
            }

            public int CurrentCount { get { return ce.count; } }

            public Task Task { get { return ce.tcs.Task; } }
        }
    }

    public static class BGTasks
    {
        private static readonly tasks Instance = new tasks();

        public static CancellationToken Abort { get { return Instance.Abort; } }

        public static void Run(Func<Task> operation)
        {
            Instance.Run(operation);
        }

        public static void Run(Action operation)
        {
            Instance.Run(operation);
        }
    }

    #endregion
}
