using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using FOCommon.Parsers;

// Generic ini config class
namespace FOCommon
{
    public class ConfigItem
    {
        public string Section { get; set; }
        public string Key { get; set; }
        public string Variable { get; set; }
        public object Default { get; set; }
        public ConfigItem(string Section, String Key, String Variable, object Default)
        {
            this.Variable = Variable;
            this.Section = Section;
            this.Key = Key;
            this.Default = Default;
        }
    }

    public class Config
    {
        private readonly bool _firstTime;

        private FOCommon.Parsers.IniReader Ini;

        List<ConfigItem> ConfigItems = new List<ConfigItem>(); // <ConfigName>.cfg
        List<ConfigItem> UserConfigItems = new List<ConfigItem>(); // <ConfigName>.user.cfg

        private String ConfigName;

        public string GetVariable(string Variable)
        {
            return this.GetType().GetField(Variable).GetValue(this).ToString();
        }

        public void SetVariable(string Variable, object value)
        {
            this.GetType().GetField(Variable).SetValue(this, Convert.ChangeType(value, this.GetType().GetField(Variable).FieldType));
        }

        public void AddConfigItem(bool User, string Section, string Key, string VariableName, object Default)
        {
            if(User)
                UserConfigItems.Add(new ConfigItem(Section, Key, VariableName, Default));
            else
                ConfigItems.Add(new ConfigItem(Section, Key, VariableName, Default));
        }

        // VariableName==Key
        public void AddConfigItem(bool User, string Section, string Key, object Default)
        {
            AddConfigItem(User, Section, Key, Key, Default);
        }

        public Config(String ConfigName)
        {
            this.ConfigName = ConfigName;

            Ini = new IniReader(".\\"+ConfigName+".cfg");
            if (!File.Exists(".\\" + ConfigName + ".cfg"))
            {
                SetDefaultValues(false);
                _firstTime = true;
            }
            if (!File.Exists(".\\" + ConfigName + ".user.cfg"))
                SetDefaultValues(true);
        }

        public bool IsFirstTime() { return _firstTime; }
        public void SetDefaultValues(bool User) 
        { 
            if(!User)
                foreach (ConfigItem It in ConfigItems) SetVariable(It.Variable, It.Default);
            else
                foreach (ConfigItem It in UserConfigItems) SetVariable(It.Variable, It.Default);
        }
        public void LoadConfigItem(IniReader ini, ConfigItem it)
        {
            string Val = ini.IniReadValue(it.Section, it.Key);
            if (string.IsNullOrEmpty(Val))
                SetVariable(it.Variable, it.Default);
            else
                SetVariable(it.Variable, ini.IniReadValue(it.Section, it.Key));
        }

        public void Save() {
            Ini = new IniReader(".\\" + ConfigName + ".cfg");
            foreach(ConfigItem It in ConfigItems) 
                Ini.IniWriteValue(It.Section, It.Key, GetVariable(It.Variable));
            Ini = new IniReader(".\\" + ConfigName + ".user.cfg");
            foreach (ConfigItem It in UserConfigItems)
                Ini.IniWriteValue(It.Section, It.Key, GetVariable(It.Variable));
        }
        public void Load() {
            Ini = new IniReader(".\\" + ConfigName + ".cfg");
            foreach (ConfigItem It in ConfigItems)
                LoadConfigItem(Ini, It);
            Ini = new IniReader(".\\" + ConfigName + ".user.cfg");
            foreach (ConfigItem It in UserConfigItems)
                LoadConfigItem(Ini, It);
        }
    }
}
