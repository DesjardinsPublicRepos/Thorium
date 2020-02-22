using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

using MP4toMP3Converter.Properties;

namespace MP4toMP3Converter
{
    public partial class MainForm : Form
    {
        public static bool[] customFilepathEnalbled = new bool[2] { false, false };
        public static string[] customFilepaths = new string[2] { "Default", "Default" };
        public static byte[] ColorScheme = new byte[27];
        public static byte iconScheme;

        private Form activeForm = null;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private readonly PrivateFontCollection fonts = new PrivateFontCollection();

        public static Type[] setupFileTypes = new Type[32] { typeof(bool), typeof(bool), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte),
                                                     typeof(byte), typeof(string), typeof(string) };
        public static string binary = "settings.bin"; 

        public MainForm()
        {
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            UpdateStyles();

            readSetup();
            InitializeComponent();
            CustomColors();
            fontInit();
        }

        #region onClicks

        private void DropdownButton1_Click(object sender, EventArgs e)
        {
            ShowSubMenus(sub1panel);
        }

        private void Sub1Button1_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("convert"));
        }

        private void Sub1Button2Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("combine"));
        }

        private void Sub1Button3_Click(object sender, EventArgs e)
        {
            ConvertForm.InputData = new string[50];
            ConvertForm.InputName = new string[50];
            OpenChildForm(new ConvertForm("convertCombine"));
        }

        private void Sub2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SettingsForm(this));
        }

        private void Sub2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AuthorForm());
        }

        private void DropdownButton2_Click(object sender, EventArgs e)
        {
            ShowSubMenus(sub2panel);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ConvertForm.converter.Stop();
            if (ConvertForm.thread != null) ConvertForm.thread.Abort();
            Environment.Exit(1);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Sub2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MailForm());
        }

        #endregion

        #region colorHandling

        public static byte[] DefaultColors()
        {
            return new byte[] 
            {
                0, 0, 0, //2            1
                249, 252, 255,//5       2
                170, 170, 255, //8      3
                147, 150, 153, //11     4
                35, 38, 41, //14        5
                0, 0, 64,  //17        6
                43, 46, 50,//20         7 
                56, 60, 64,//23         8
                74, 74, 113 //26       9
            };
        }

        public static Color getCustomColor(byte index)
        {
            //return Color.FromArgb(ColorScheme[(index - 2) * 3], ColorScheme[((index - 2) * 3) + 1], ColorScheme[((index - 2) * 3) + 2]);
            return Color.FromArgb(ColorScheme[(index - 1) * 3], ColorScheme[((index - 1) * 3) + 1], ColorScheme[((index - 1) * 3) + 2]);
        }

        #endregion

        #region functionality

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            FormPanel.Controls.Add(ChildForm);
            FormPanel.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        #endregion

        #region binaryHandling

        public static object[] getCurrentSetup()
        {
            using (BinaryReader binaryReader = new BinaryReader(new FileStream(binary, FileMode.Open)))
            {
                object[] newObjects = new object[32];

                for(int i = 0; i < setupFileTypes.Length; i++)
                {
                    newObjects[i] = readNextObject(Convert.ToByte(i), binaryReader);
                }
                return newObjects;
            }
        }

        public static object readNextObject(byte index, BinaryReader binaryReader)
        {
            object obj = new object();

            if (setupFileTypes[index] == typeof(bool))
            {
                obj = binaryReader.ReadBoolean();
            }
            else if (setupFileTypes[index] == typeof(byte))
            {
                obj = binaryReader.ReadByte();
            }
            else if (setupFileTypes[index] == typeof(string))
            {
                obj = binaryReader.ReadString();
            }
            else Debug.WriteLine("something went wrong there");

            Debug.WriteLine(index + " " + obj.ToString());
            return obj;
        }

        public static void changeBinary(byte[] itemIndexes, object[] newObjects, byte[] colors)
        {
            object[] oldObjects = getCurrentSetup();

            if (colors != null)
            {
                for(int i = 0; i < 27; i++)
                {
                    oldObjects[i + 2] = colors[i];
                }
            }
            
            for (int i = 0; i < itemIndexes.Length; i++)
            {
                oldObjects[itemIndexes[i]] = newObjects[i];
            }
            
            writeBinary(oldObjects);
        }

        public static void writeBinary(object[] objects)
        {
            using(BinaryWriter bw = new BinaryWriter(new FileStream(binary, FileMode.Create)))
            {
                foreach (object o in objects)
                {
                    if (o.GetType() == typeof(bool))
                    {
                        bw.Write(Convert.ToBoolean(o));
                    }
                    else if (o.GetType() == typeof(string))
                    {
                        bw.Write(o.ToString());
                    }
                    else if (o.GetType() ==  typeof(byte))
                    {
                        bw.Write(Convert.ToByte(o));
                    }
                    else if(o.GetType() == typeof(byte[]))
                    {
                        var tempArray = o as IEnumerable;

                        foreach(byte b in tempArray)
                        {
                            bw.Write(b);
                        }
                    }
                }
            }

            using(BinaryReader br = new BinaryReader(new FileStream(binary, FileMode.Open)))
            {
                Debug.WriteLine(br.ReadInt32());
            }
        }

        #endregion

        #region init

        private void readSetup()
        {
            if (File.Exists(binary) == true)
            {
                object[] objects = getCurrentSetup();

                if(Convert.ToBoolean(objects[0]) == false)
                {
                    ColorScheme = DefaultColors();
                    iconScheme = 6;
                }
                else
                {
                    if (Convert.ToBoolean(objects[1]) == false)
                    {
                        ColorScheme = DefaultColors();
                    }
                    else
                    {
                        for (int i = 0; i < 27; i++)
                        {
                            ColorScheme[i] = Convert.ToByte(objects[i + 2]);
                        }
                    }
                    iconScheme = Convert.ToByte(objects[29]);

                    if (objects[30].ToString().Trim() != "Default")
                    {
                        customFilepathEnalbled[0] = true;
                        customFilepaths[0] = objects[30].ToString();
                    }
                    if (objects[31].ToString().Trim() != "Default")
                    {
                        customFilepathEnalbled[1] = true;
                        customFilepaths[1] = objects[31].ToString();
                    }

                    Debug.WriteLine(customFilepathEnalbled[1].ToString() + customFilepathEnalbled[0].ToString());
                }
            }
            else
            {
                writeBinary( new object[] { false, false, DefaultColors(), Convert.ToByte(6), "Default", "Default" });
                ColorScheme = DefaultColors();
                iconScheme = 6;
            }
        }

        private void ShowSubMenus(Panel panel)
        {
            if (panel.Visible == false)
            {
                sub1panel.Visible = false;
                sub2panel.Visible = false;
                panel.Visible = true;
            }
            else panel.Visible = false;
        }

        private void CustomColors()
        {
            panel1.BackColor = getCustomColor(7);

            FormPanel.BackColor = getCustomColor(7);
            IconPictureBox.BackColor = getCustomColor(7);
            InfoLabel2.BackColor = getCustomColor(7);
            InfoLabel1.BackColor = getCustomColor(7);
            stLabel.BackColor = getCustomColor(7);

            Sub1Button1.BackColor = getCustomColor(8);
            Sub1Button2.BackColor = getCustomColor(8);
            Sub1Button3.BackColor = getCustomColor(8);
            Sub2Button1.BackColor = getCustomColor(8);
            Sub2Button3.BackColor = getCustomColor(8);
            Sub2Button4.BackColor = getCustomColor(8);
            sub1panel.BackColor = getCustomColor(8);
            sub2panel.BackColor = getCustomColor(8);

            InfoLabel2.ForeColor = getCustomColor(2);
            CloseButton.ForeColor = getCustomColor(2);
            RestartButton.ForeColor = getCustomColor(2);
            DropdownButton1.ForeColor = getCustomColor(2);
            DropdownButton2.ForeColor = getCustomColor(2);
            Sub1Button1.ForeColor = getCustomColor(2);
            Sub1Button2.ForeColor = getCustomColor(2);
            Sub1Button3.ForeColor = getCustomColor(2);
            Sub2Button1.ForeColor = getCustomColor(2);
            Sub2Button3.ForeColor = getCustomColor(2);
            Sub2Button4.ForeColor = getCustomColor(2);

            InfoLabel1.ForeColor = getCustomColor(3);
            stLabel.ForeColor = getCustomColor(3);

            CloseButton.BackColor = getCustomColor(7);
            RestartButton.BackColor = getCustomColor(7);
            BackPanel.BackColor = getCustomColor(5);
            DropdownButton1.BackColor = getCustomColor(5);
            DropdownButton2.BackColor = getCustomColor(5);
            sub0panel.BackColor = getCustomColor(5);

            CloseButton.FlatAppearance.MouseOverBackColor = getCustomColor(6);
            RestartButton.FlatAppearance.MouseOverBackColor = getCustomColor(6);
            DropdownButton1.FlatAppearance.MouseOverBackColor = getCustomColor(6);
            DropdownButton2.FlatAppearance.MouseOverBackColor = getCustomColor(6);

            Sub1Button1.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            Sub1Button2.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            Sub1Button3.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            Sub2Button1.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            Sub2Button3.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            Sub2Button4.FlatAppearance.MouseOverBackColor = getCustomColor(9);
            switch (iconScheme)
            {
                case 0:
                    IconPictureBox.Image = Properties.Resources.coal_white;
                    break;
                case 1:
                    IconPictureBox.Image = Resources.coal_orange;
                    break;
                case 2:
                    IconPictureBox.Image = Resources.coal_yellow;
                    break;
                case 3:
                    IconPictureBox.Image = Resources.coal_green;
                    break;
                case 4:
                    IconPictureBox.Image = Resources.coal_brightblue;
                    break;
                case 5:
                    IconPictureBox.Image = Resources.coal_blue;
                    break;
                case 6:
                    IconPictureBox.Image = Resources.coal_lila;
                    break;
                case 7:
                    IconPictureBox.Image = Resources.coal_red;
                    break;
                case 8:
                    IconPictureBox.Image = Resources.coal_black;
                    break;
            }
            sub1panel.Visible = false;
            sub2panel.Visible = false;
        }

        private void fontInit()
        {
            byte[] fontData = Resources.mss;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint uint1 = 0;

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fonts.AddMemoryFont(fontPtr, Resources.mss.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.mss.Length, IntPtr.Zero, ref uint1);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            OutsourcedFunctions o = new OutsourcedFunctions();

            o.changeFont(new Control[] { DropdownButton1, DropdownButton2,Sub1Button1, Sub1Button2, Sub1Button3}, new Font(fonts.Families[0], 11.25f));

            o.changeFont(new Control[] { RestartButton, CloseButton }, new Font(fonts.Families[0], 8.25f));

            o.changeFont(new Control[] { stLabel }, new Font(fonts.Families[0], 15.75f));

            o.changeFont(new Control[] { InfoLabel1 }, new Font(fonts.Families[0], 21.75f));

            byte[] fontData0 = Resources.Playball;
            IntPtr fontPtr0 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            uint uint2 = 1;

            System.Runtime.InteropServices.Marshal.Copy(fontData0, 0, fontPtr0, fontData0.Length);
            fonts.AddMemoryFont(fontPtr0, Resources.Playball.Length);
            AddFontMemResourceEx(fontPtr0, (uint)Properties.Resources.Playball.Length, IntPtr.Zero, ref uint2);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr0);

            o.changeFont(new Control[] { InfoLabel2 }, new Font(fonts.Families[1], 48f));

        }

        #endregion

        #region overrides

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        #endregion
    }
}
