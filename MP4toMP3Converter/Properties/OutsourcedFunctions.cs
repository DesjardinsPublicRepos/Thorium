using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MP4toMP3Converter.Properties
{
    class OutsourcedFunctions
    {
        public static void ConvertAll(string[] InputData, string[] InputName, Thread t, string Output, int ProgressState, string format)
        {
            for (int i = 0; i < 50; i++)
            {
                if (InputData[i] != null && File.Exists("@" + InputData[i]) == false)
                {
                    var convert = new NReco.VideoConverter.FFMpegConverter();
                    convert.ConvertMedia(InputData[i].Trim(), Output.Trim() + ("\\" + InputName[i].Substring(0, InputName[i].Length - 4) + "." + format), format);
                    ProgressState++;
                }
                else if (InputData[i] == null)
                {
                    t.Abort();
                    InputData = new string[50];
                    InputName = new string[50];

                    break;
                }
            }
        }
    }
}
