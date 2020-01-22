using System;
using System.Runtime.InteropServices;
using System.Text;

namespace FOMonitor
{
	public class IniReader
	{

            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section,
                string key, string val, string filePath);
            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section,
                     string key, string def, StringBuilder retVal,
                int size, string filePath);

            String Path
            {
                get;
                set;
            }

			public IniReader(string INIPath)
			{
				Path = INIPath;
			}

			public void IniWriteValue(string Section, string Key, string Value)
			{
				WritePrivateProfileString(Section, Key, Value, Path);
			}

            public void IniWriteInt(string Section, string Key, int Value)
            {
                WritePrivateProfileString(Section, Key, Value.ToString(), Path);
            }

            public int IniReadInt(string Section, string Key)
            {
                int res;
                if (!Int32.TryParse(IniReadValue(Section, Key), out res))
                    return -1;
                return res;
            }

			public string IniReadValue(string Section, string Key)
			{
				StringBuilder temp = new StringBuilder(255);
				int i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
				return temp.ToString();
			}
	}
}
