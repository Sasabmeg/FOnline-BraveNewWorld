using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ObjectEditor
{
    public class DeepCopier
    {
        public static T DeepCopy<T>(T obj)
        {
            if (obj == null)
                throw new ArgumentNullException("Object cannot be null");
            return (T)Process(obj);
        }

        static object Process(object obj)
        {
            if (obj == null)
                return null;
            Type type = obj.GetType();
            if (type.IsValueType || type == typeof(string))
            {
                return obj;
            }
            else if (type.IsArray)
            {
                Type elementType = Type.GetType(
                     type.FullName.Replace("[]", string.Empty));
                var array = obj as Array;
                Array copied = Array.CreateInstance(elementType, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    copied.SetValue(Process(array.GetValue(i)), i);
                }
                return Convert.ChangeType(copied, obj.GetType());
            }
            else if (type.IsClass)
            {
                object toret = Activator.CreateInstance(obj.GetType());
                FieldInfo[] fields = type.GetFields(BindingFlags.Public |
                            BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (FieldInfo field in fields)
                {
                    object fieldValue = field.GetValue(obj);
                    if (fieldValue == null)
                        continue;
                    field.SetValue(toret, Process(fieldValue));
                }
                return toret;
            }
            else
                throw new ArgumentException("Unknown type");
        }
    }

    public static class Message
    {
        public static DialogResult Show(string text)
        {
            return MessageBox.Show(text, "FOnline ObjectEditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(text, "FOnline ObjectEditor", buttons, icon);
        }

        public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon, bool LogMsg)
        {
            if (LogMsg) Utils.Log(text);
            return MessageBox.Show(text, "FOnline ObjectEditor", buttons, icon);
        }
    }

    public static class Utils
    {
        
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        private const int WM_SETREDRAW = 11;
        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }

        private static string FileName;
        public static void InitLog(string FileName)
        {
            Utils.FileName = FileName;
            File.Delete(FileName);
        }

        public static void Log(String Text)
        {
            File.AppendAllText(FileName, "[" + DateTime.Now.ToString() + "] " + Text + Environment.NewLine);
        }

        public static string GetVersion()
        {
            return "3.2.0";
        }

        public static string GetFormatCompatibilityVersion()
        {
            return "2.14.3";
        }

        public static void SerializeObjectListView(string Filename, ref BrightIdeasSoftware.FastObjectListView lst, bool Load)
        {
            if (Load && File.Exists(Filename)) lst.RestoreState(File.ReadAllBytes(Filename));
            else File.WriteAllBytes(Filename, lst.SaveState());
        }

        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
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
    }
}
