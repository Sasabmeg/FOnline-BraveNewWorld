using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DATLib;
using FOCommon.Graphic;
using FOCommon.Parsers;
using Ionic.Zip;


namespace ObjectEditor
{
    // Class responsible for reading defines, graphics and other external resources.
    static class Data
    {
        public static Dictionary<string, int> ItemTypes = new Dictionary<string, int>();
        public static Dictionary<string, int> Calibers  = new Dictionary<string, int>();
        public static Dictionary<string, int> WeaponPerks = new Dictionary<string, int>();
        public static Dictionary<string, int> Anim1 = new Dictionary<string, int>();
        public static Dictionary<string, int> Anim2 = new Dictionary<string, int>();
        public static Dictionary<string, int> ItemPid = new Dictionary<string, int>();
        public static Dictionary<string, int> Skills = new Dictionary<string, int>();
        public static Dictionary<string, int> DamageTypes = new Dictionary<string, int>();

        public static Dictionary<string, int> Defines   = new Dictionary<string, int>();

        public static Dictionary<string, Bitmap> Graphics = new Dictionary<string, Bitmap>();

        public static List<String> GraphicsPaths = new List<string>();

        public static void Init()
        {
            GraphicsPaths.Add("art\\items");
            GraphicsPaths.Add("art\\inven");
            GraphicsPaths.Add("art\\scenery");
            GraphicsPaths.Add("art\\misc");

            // TODO: Functionality to set which paths to load in settings.
        }

        public static bool LoadZip(String ZipPath, Color Transparency)
        {
            using (ZipFile zip = ZipFile.Read(ZipPath))
            {
                foreach (ZipEntry e in zip)
                {
                    string ext = Path.GetExtension(e.FileName).ToLower();
                    if (!(ext == ".frm" || ext == ".png"))
                        continue;

                    bool Valid = false;
                    foreach (String path in GraphicsPaths)
                    {
                        if (e.FileName.Contains(path))
                            Valid = true;
                    }
                    if (!Valid)
                        continue;

                    if (!(e.FileName.Contains("art\\items") || e.FileName.Contains("art\\inven") ))
                        continue;

                    System.IO.MemoryStream memstream = new MemoryStream();
                    e.Extract(memstream);
                    List<Byte> data = new List<Byte>();
                    Byte[] buffer = new Byte[4];
                    memstream.Seek(0, SeekOrigin.Begin);
                    while (memstream.Read(buffer, 0, 4) > 0)
                    {
                        data.AddRange(new List<Byte>(buffer));
                    }
                    if (ext == ".frm")
                    {
                        List<Bitmap> bmaps = FalloutFRM.Load(data.ToArray(), Transparency);
                        Graphics[e.FileName.ToLower()] = bmaps[0];
                    }
                    else
                    {
                        Image img = Bitmap.FromStream(memstream);
                        Graphics[e.FileName.ToLower()] = (Bitmap)img;
                    }
                }
            }

            return true;
        }

        public static bool LoadDat(string DatPath, Color Transparency)
        {
           DatReaderError status;
           DAT loadedDat = DATReader.ReadDat(DatPath, out status);
           if (status.Error != DatError.Success)
           {
               Message.Show("Error loading " + DatPath + ": " + Environment.NewLine + status.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
               return false;
           }

           List<DATFile> files = new List<DATFile>();
           foreach (string path in GraphicsPaths)
           {
               files.AddRange(loadedDat.GetFilesByPattern(path));
           }

           foreach (DATFile file in files)
           {
               string ext = Path.GetExtension(file.FileName).ToLower();
               if (!(ext == ".frm" || ext == ".png"))
                   continue;

               if (ext == ".frm")
               {
                   List<Bitmap> bmaps = FalloutFRM.Load(file.GetData(), Transparency);
                   Graphics[file.Path.ToLower()] = bmaps[0];
               }
               else
               {
                   System.ComponentModel.TypeConverter tc = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Bitmap));
                   Bitmap bitmap = (Bitmap)tc.ConvertFrom(file.GetData());
               }
           }

           loadedDat.Close();

           return true;
        }

        public static bool LoadDefines(Config Cfg)
        {
            ClearLists();
            DefineParser defines = new DefineParser();
            string CurrentLine="";
            string CurrentFile="";

            if (!defines.ReadDefines(@Cfg.PathDefinesFOClassic))
            {
                Message.Show("Can't find " + Cfg.PathDefinesFOClassic, MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                return false;
            }

            if (!defines.ReadDefines(@Cfg.PathDefines))
            {
                Message.Show("Can't find " + Cfg.PathDefines, MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                return false;
            }

            try
            {
                Defines = defines.Defines;

                ItemPid.Add("", 0); // none
                WeaponPerks.Add("", 0);

                CurrentFile = "_defines.fos";
                // Read stuff from parsed defines from _defines.fos
                foreach (KeyValuePair<string, int> kvp in Defines)
                {
                    CurrentLine = kvp.Key;
                    if (kvp.Key.StartsWith("ITEM_TYPE_")) ItemTypes.Add((Cfg.StripPrefix ? kvp.Key.Remove(0, 10) : kvp.Key), kvp.Value);
                    if (kvp.Key.StartsWith("CALIBER_")) Calibers.Add((Cfg.StripPrefix ? kvp.Key.Remove(0, 8) : kvp.Key), kvp.Value);
                    if (kvp.Key.StartsWith("WEAPON_PERK_")) WeaponPerks.Add((Cfg.StripPrefix ? kvp.Key.Remove(0, 12) : kvp.Key), kvp.Value);
                    if (kvp.Key.StartsWith("DAMAGE_")) DamageTypes.Add((Cfg.StripPrefix ? kvp.Key.Remove(0, 7) : kvp.Key), kvp.Value);
                }

                if (!File.Exists(Cfg.PathDataFolder + "\\DefineNames.lst"))
                {
                    Message.Show("Can't find DefinesNames.lst", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                    return false;
                }

                List<String> Lines = new List<String>(File.ReadAllLines(Cfg.PathDataFolder + "\\DefineNames.lst", Encoding.UTF8));
                bool PAnim1 = false;
                bool PAnim2 = false;
                bool PSkills = false;
                int BaseNum = 0;
                char[] Sep = { ' ', '\t' };
                CurrentFile = "DefineNames.lst";
                foreach (String Line in Lines)
                {
                    CurrentLine = Line;
                    if (Line.Length == 0 || Line[0] == '#')
                        continue;

                    if (Line[0] == '*')
                    {
                        PAnim1 = false;
                        PAnim2 = false;
                        PSkills = false;
                        BaseNum = Int32.Parse(Line.Remove(0, 1));
                    }

                    if (Line.Length < 6)
                        continue;

                    string[] Parts = Line.Split(Sep, StringSplitOptions.RemoveEmptyEntries);
                    if (PAnim1) Anim1.Add(Parts[1], BaseNum + Int32.Parse(Parts[0]));
                    if (PAnim2) Anim2.Add(Parts[1], BaseNum + Int32.Parse(Parts[0]));
                    if (PSkills) Skills.Add(Parts[1], BaseNum + Int32.Parse(Parts[0]));

                    if (Line.Contains("---ANIM1---")) PAnim1 = true;
                    else if (Line.Contains("---ANIM2---")) PAnim2 = true;
                    else if (Line.Contains("---SKILLS---")) PSkills = true;
                }

                if (!File.Exists(Cfg.PathDataFolder + "\\ItemNames.lst"))
                {
                    Message.Show("Can't find ItemNames.lst", MessageBoxButtons.OK, MessageBoxIcon.Error, true);
                    return false;
                }

                CurrentFile = "ItemNames.lst";
                Lines = new List<String>(File.ReadAllLines(Cfg.PathDataFolder + "\\ItemNames.lst", Encoding.UTF8));
                foreach (String Line in Lines)
                {
                    CurrentLine = Line;
                    if (Line.Length < 4) continue;
                    string[] Parts = Line.Split(Sep, StringSplitOptions.RemoveEmptyEntries);
                    if (ItemPid.ContainsKey(Parts[1]))
                        ItemPid[Parts[1]] = Int32.Parse(Parts[0]);
                    else
                        ItemPid.Add(Parts[1], Int32.Parse(Parts[0]));
                }
            }
            catch (IndexOutOfRangeException)
            {
                Message.Show("Error while parsing line '" + CurrentLine + "' in " + CurrentFile, MessageBoxButtons.OK, MessageBoxIcon.Error, true);
            }
            return true;
        }

        public static void ClearLists()
        {
            ItemTypes.Clear();
        }
    }
}
