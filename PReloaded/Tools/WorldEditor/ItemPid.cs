using System;
using System.Collections.Generic;
using System.IO;
using FOCommon.Items;
using FOCommon.Parsers;

namespace WorldEditor
{
    public static class ItemPid
    {
        private static List<Item> Items = new List<Item>();
        public static bool IsInitialized { get; set; }

        public static string GetDefineName(int pid)
        {
            foreach (Item It in Items)
            {
                if (It.Pid == pid)
                    return It.Define;
            }
            return "";
        }

        public static int GetPid(string define)
        {
            foreach (Item It in Items)
                if(It.Define==define)
                    return It.Pid;
            return -1;
        }

        public static Item GetItemByDefine(string define)
        {
            foreach (Item It in Items)
                if (It.Define == define)
                    return It;
            return null;
        }

        public static Item GetItemByPid(int pid)
        {
            foreach(Item It in Items)
                if (It.Pid == pid)
                    return It;
            return null;
        }

        public static List<Item> GetItems()
        {
            return Items;
        }

        public static void Init()
        {
            if (!File.Exists(Config.PathItemPid))
            {
                Message.Show("Can't find ITEMPID.H", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error, true);
                Environment.Exit(0);
                return;
            }

            DefineParser defineParser = new DefineParser();
            if (!defineParser.ReadDefines(Config.PathItemPid))
            {
                Utils.HandleParseError(defineParser.Error, Config.PathItemPid);
                return;
            }

            foreach (KeyValuePair<string, int> kvp in defineParser.Defines)
            {
                Items.Add(new Item(kvp.Value, kvp.Key));
            }
                
            Utils.Log("Found " + Items.Count + " PIDs in ITEMPID.H");
            IsInitialized = true;
        }
    }
}
