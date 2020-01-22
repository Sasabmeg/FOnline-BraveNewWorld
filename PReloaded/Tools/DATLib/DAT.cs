using System;
using System.Collections.Generic;
using System.IO;

namespace DATLib
{
    // This is a helper class for handling multiple DAT files.
    public class DAT
    {
        public bool lError { get; set; }
        public uint ErrorType { get; set; }

        public BinaryReader br { get; set; }
        public String DatFileName { get; set; }
        public List<DATFile> FileList { get; set; }
        public long FileSizeFromDat { get; set; }
        public long TreeSize { get; set; }
        public long tmpTreeSize { get; set; }
        public long FilesTotal { get; set; }

        public void Close()
        {
            br.Close();
        }

        private int CountChar(string s, char c)
        {
            int count=0;
            foreach (char ch in s)
            {
                if (ch == c)
                    count++;
            }
            return count;
        }

        public List<DATFile> GetFilesByPattern(string pattern)
        {
            List<DATFile> Files = new List<DATFile>();
            foreach (DATFile File in FileList)
                if ((pattern=="")||(File.Path.Contains(pattern)&&((CountChar(File.Path,'\\')-1==CountChar(pattern,'\\')))))
                    Files.Add(File);
            return Files;
        }

        public void AddFile(string filename, string virtualfilename)
        {
            DATFile file = new DATFile();
            file.Path = virtualfilename;
            file.FileNameSize = System.Text.ASCIIEncoding.ASCII.GetByteCount(file.Path);
            file.Buffer = File.ReadAllBytes(filename);
            file.UnpackedSize = file.Buffer.Length;
            file.PackedSize = file.Buffer.Length;
            file.Compression = 0x00;
            FileList.Add(file);
            FilesTotal++;
        }

        public DATFile GetFileByName(string filename)
        {
            foreach (DATFile file in FileList)
                if (file.Path == filename)
                    return file;
            return null;
        }
    }
}
