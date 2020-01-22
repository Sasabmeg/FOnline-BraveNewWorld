using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace FOCommon.Translation
{
    // Very simplistic translation functionality (Used in ObjectEditor), .NET localization is probably a wiser choice in most cases...
    public static class Translate
    {
        private static Dictionary<String, String> CurrentLanguage = new Dictionary<string, string>();

        public static void WriteTemplateLanguageFile(Form frm)
        {
            List<String> Lines = new List<string>();
            
            foreach (Control Ctrl in Utils.GetAllControls(frm.Controls))
                if (!String.IsNullOrEmpty(Ctrl.Name) && ( (Ctrl is Label) || 
                                                          (Ctrl is GroupBox) || 
                                                          (Ctrl is CheckBox) || 
                                                          (Ctrl is Button) || 
                                                          (Ctrl is RadioButton) ||
                                                          (Ctrl is TabPage))
                    ) Lines.Add(Utils.GetSpacedLine(Ctrl.Name,"= " + Ctrl.Text, 40));
            Lines.Sort();
            Lines.Insert(0,"Encoding=Windows-1251");
            File.WriteAllLines(".\\Template.lang", Lines.ToArray());
        }

        public static void TranslateForm(Form frm)
        {
            foreach (Control Ctrl in Utils.GetAllControls(frm.Controls))
            {
                if (CurrentLanguage.ContainsKey(Ctrl.Name))
                    Ctrl.Text = CurrentLanguage[Ctrl.Name];
            }
            
        }

        public static bool LoadLanguage(string Path)
        {
            CurrentLanguage.Clear();

            if (!File.Exists(Path)) return false;
            StreamReader Sr = File.OpenText(Path);
            String Encoding = Sr.ReadLine();
            Sr.Close();

            if (String.IsNullOrEmpty(Encoding))
                return false;

            String[] EncParts = Encoding.Split('=');
            foreach (String Line in File.ReadAllLines(Path, System.Text.Encoding.GetEncoding(EncParts[1])))
            {
                String[] Parts = Line.Split(new char[]{'='}, StringSplitOptions.RemoveEmptyEntries);
                if (Parts.Length==2)
                {
                    CurrentLanguage.Add(Parts[0].TrimEnd(), Parts[1]);
                }
            }
            return true;
        }
    }
}
