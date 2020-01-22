using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace FOCommon.Parsers
{
	public class IniReader
	{
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        String Path { get; set; }
		public IniReader(string iniPath)
		{
			Path = iniPath;
		}

        public void DeleteEntry(string section)
        {
            List<String> lines = new List<string>(File.ReadAllLines(Path));
            for (int i = 0; i < lines.Count;i++ )
            {
                if (!lines[i].Contains("[" + section + "]")) continue;
                do
                {
                    lines.RemoveAt(i);
                } while ((i<lines.Count)&&((!lines[i].Contains("[") && (!lines[i].Contains("]")))));
            }
            File.WriteAllLines(Path, lines.ToArray());
        }

		public void IniWriteValue(string section, string key, string value)
		{
			WritePrivateProfileString(section, key, value, Path);
		}

        public void IniWriteValueBool(string section, string key, bool value)
        {
            IniWriteValue(section, key, value?"1":"0");
        }

        public void IniWriteValueHexInt(string section, string key, int value)
        {
            IniWriteValue(section, key, value.ToString("X"));
        }

		public string IniReadValue(string section, string key)
		{
			var temp = new StringBuilder(255);
			GetPrivateProfileString(section, key, "", temp, 255, Path);
			return temp.ToString();
		}

        public bool IniReadValueBool(string section, string key)
        {
            int x;
            Int32.TryParse(IniReadValue(section, key), out x);
            return (x == 1);
        }

        public int IniReadValueInt(string section, string key)
        {
            int x = -1;
            Int32.TryParse(IniReadValue(section, key), out x);
            return x;
        }

        public float IniReadValueFloat(string section, string key)
        {
            float x = -1.0f;
            float.TryParse(IniReadValue(section, key), out x);
            return x;
        }

        public int IniReadValueHexInt(string section, string key)
        {
            string str = IniReadValue(section, key);
            return int.Parse(str, System.Globalization.NumberStyles.HexNumber);
        }
	}
}
