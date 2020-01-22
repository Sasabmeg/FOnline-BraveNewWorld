using System.Windows.Forms;

namespace WorldEditor
{
    public static class Message
    {
        public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon, bool Log)
        {
            if (Log) Utils.Log(text);
            return MessageBox.Show(text, "FOnline WorldEditor", buttons, icon);
        }
        public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return Message.Show(text, buttons, icon, false);
        }
    }
}
