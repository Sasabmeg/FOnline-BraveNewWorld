using System;
using System.Collections.Generic;
using System.IO;

using FOCommon.Dialog;

namespace FOCommon.Parsers
{
    // This class parses dialog.lst
    public class DialogListParser : BaseParser, IParser
    {
        string filename;
        List<ListDialog> Dialogs = new List<ListDialog>();

        public DialogListParser(string filename)
        {
            this.filename = filename;
        }

        public string GetNameById(int id)
        {
            foreach (ListDialog dialog in Dialogs)
                if (id == dialog.Id)
                    return dialog.Name;
            return "";
        }

        public List<ListDialog> GetDialogs(bool onlyEnabled)
        {
            List<ListDialog> retDialogs = new List<ListDialog>();
            foreach (ListDialog dialog in Dialogs)
            {
                if ((onlyEnabled && !dialog.Enabled))
                    continue;
                retDialogs.Add(dialog);
            }
            return retDialogs;
        }

        public bool Parse()
        {
            if (!File.Exists(filename))
                return false;
            Dialogs.Clear();
            List<String> lines = new List<string>(File.ReadAllLines(filename));
            foreach (String line in lines)
            {
                if (string.IsNullOrEmpty(line?.Trim() ?? string.Empty) || line.TrimStart(new char[] { ' ', '\t' }).StartsWith("#") || line.TrimStart(new char[] { ' ', '\t' }).StartsWith(";"))
                    continue;;

                string[] parts = line.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length < 2)
                    continue;

                int i = 0;
                bool enabled;

                if (Int32.TryParse(parts[1].Trim(new char[] { ' ', '\t' }), out i))
                    enabled = i > 0;
                else
                    enabled = false;

                Dialogs.Add(new ListDialog(i, parts[0].Trim(new char[] { ' ', '\t' }), enabled));

            }
            _IsParsed = true;
            return true;
        }
    }
}
