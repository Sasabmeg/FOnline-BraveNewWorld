using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FOMonitor
{
    public static class Serializer
    {
        static IniReader ini;
        public static void Init()
        {
            ini = new IniReader("./config.ini");
            if (!File.Exists("./config.ini"))
                File.CreateText("./config.ini");
        }

        public static void DeserializeCmb(string section, string key, ComboBox box)
        {
            box.SelectedIndex = ini.IniReadInt(section, key);
        }

        public static void DeserializeNum(string section, string key, NumericUpDown num)
        {
           num.Value = ini.IniReadInt(section, key);
        }

        public static void DeserializeChk(string section, string key, CheckBox chk)
        {
            chk.Checked = ini.IniReadInt(section, key)==1?true:false;
        }

        public static void DeserializeTextBox(string section, string key, TextBox box)
        {
            box.Text = ini.IniReadValue(section, key);
        }

        public static void SerializeCmb(string section, string key, ComboBox box)
        {
            ini.IniWriteInt(section, key, box.SelectedIndex);
        }

        public static void SerializeChk(string section, string key, CheckBox chk)
        {
            ini.IniWriteInt(section, key, chk.Checked?1:0);
        }

        public static void SerializeTextBox(string section, string key, TextBox box)
        {
            ini.IniWriteValue(section, key, box.Text);
        }
    }
}
