using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FOCommon.Parsers;
using FOCommon.WMLocation;

namespace WorldEditor
{
    public static class Utils
    {
        static object loglock = new object();

        public static void InitLog()
        {
            File.Delete(".\\WorldEditor.log");
        }

        public static void Log(String Text)
        {
            lock (loglock)
            {
                File.AppendAllText(".\\WorldEditor.log", "[" + DateTime.Now.ToString() + "] " + Text + Environment.NewLine);
                if(Config.DebugConsole)
                    Console.WriteLine("[" + DateTime.Now.ToString() + "] " + Text);
            }
        }

        public static void HandleParseError(ParseError parseError, string fileName)
        {
            if (parseError == null)
            {
                Message.Show("Failed to find or open " + fileName, MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                return;
            }

            Message.Show("Parsing failed on '" + parseError.ErrorLine + "' in " + parseError.File + Environment.NewLine +
                parseError.Exception.Message
                , 
                MessageBoxButtons.OK,
                MessageBoxIcon.Error, true);
        }

        public static void ScrollToEnd(TextBox textbox)
        {
            textbox.SelectionStart = textbox.Text.Length;
            textbox.ScrollToCaret();
        }

        public static Bitmap ScaleByPercent(this Bitmap imgPhoto, int Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            var destWidth = (int)(sourceWidth * nPercent);
            var destHeight = (int)(sourceHeight * nPercent);

            var bmPhoto = new Bitmap(destWidth, destHeight,
                                     PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                                  imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                              new Rectangle(0, 0, destWidth, destHeight),
                              new Rectangle(0, 0, sourceWidth, sourceHeight),
                              GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        public static String ToCSV(string delimeter, List<string> list)
        {
            List<string> csv = new List<string>();
            String line = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) line += list[i];
                else line += list[i] + delimeter;
            }
            return line;
        }

        public static String ToCSV(List<string> list)
        {
            return ToCSV(",", list);
        }

        public static string MapsToCSV(string delimeter, List<Map> list)
        {
            String line = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) line += list[i];
                else line += list[i] + delimeter;
            }
            return line;
        }

        public static bool IsOutOfZoneBoundries(int x, int y)
        {
            return (x > Config.ZoneMaxX || (y > Config.ZoneMaxY) || x < 0 || y < 0);
        }

        public static string RemoveIllegalDefineChars(string Text)
        {
            Text = Text.Replace(" ", "");
            Text = Text.Replace(":", "");
            Text = Text.Replace("'", "");
            Text = Text.Replace("-", "");
            Text = Text.Replace("/", "");
            Text = Text.Replace("!", "");
            return Text;
        }

        public static string GetSpacedLine(string Text1, string Text2, int Distance)
        {
            string Entry = Text1;
            int Len = Distance - Entry.Length;
            for (int i = 0; i < Len; i++)
                Entry += " ";
            Entry += Text2;
            return Entry;
        }

        public static List<T> RemoveDuplicates<T>(List<T> List)
        {
            return List.Distinct<T>().ToList<T>();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public static void LoadProcessInControl(string Process, Control Control)
        {
            var startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = Path.GetDirectoryName(@Process);
            startInfo.FileName = @Process;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(startInfo);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, Control.Handle);
        }
    }
}
