using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WorldEditor.Controls
{
    public static class ConsoleExt
    {
        public static void AppendText(this Console box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    public partial class Console : RichTextBox
    {
        public Console()
        {
            
        }

        public void RedirectConsole(frmShell shl)
        {
            ConsoleRedirect Redirector = new ConsoleRedirect(this, shl);
            System.Console.SetOut(Redirector);
        }

        public void PrependText(string line)
        {
            this.Select(0, 0);
            this.SelectedText = line + Environment.NewLine;
        }

        const short WM_PAINT = 0x00f;
        public static bool _Paint = true;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // Code courtesy of Mark Mihevc
            // sometimes we want to eat the paint message so we don't have to see all the
            // flicker from when we select the text to change the color.
            if (m.Msg == WM_PAINT)
            {
            if (_Paint)
            base.WndProc(ref m); // If we decided to paint this control, just call the RichTextBox WndProc
            else
            m.Result = IntPtr.Zero; // Not painting, must set this to IntPtr.Zero if not painting therwise serious problems.
            }
            else
            base.WndProc (ref m); // Message other than WM_PAINT, just do what you normally do.
        }

        public void SetLastCaretLine()
        {
            SetCaretLine(Lines.Length);
        }

        public void SetCaretLine(int linenr)
        {
            if (linenr > this.Lines.Length)
                linenr = this.Lines.Length;
 
                int row = 1;
                int charCount = 0;
                foreach(string line in this.Lines)
                {
                    charCount+=line.Length + 1;
                    row++;
                    if(row == linenr)
                    {
                        charCount += line.Length + 1;
                        //Set the caret here
                        this.SelectionStart = charCount;
                        break;
                    }
                }
        }
    }

    // Redirecting Console output to RichtextBox
    public class ConsoleRedirect : StringWriter
    { 
        private Console outBox;
        private frmShell main;

        public ConsoleRedirect(Console textBox, frmShell main)
        {
            this.main = main;
            outBox = textBox;
        }

        public override void WriteLine(string x)
        {
            main.BeginInvoke((MethodInvoker)delegate
            {
                outBox.AppendText(x + "\n", Color.Orange);
            });
        }
    }
}
