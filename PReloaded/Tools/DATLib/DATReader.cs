using System;
using System.Collections.Generic;
using System.IO;

namespace DATLib
{
    public enum DatError
    {
        Fallout1DAT,
        IOError,
        Success,
        WrongSize
    };

    public class DatReaderError
    {
        public DatReaderError(DatError error, string Message)
        {
            this.Error = error;
            this.Message = Message;
        }
        public DatError Error { get; set; }
        public string Message { get; set; }
    }

    // TODO: Implement FO1 dat support
    public static class DATReader
    {
        // Based on code by Dims
        public static DAT ReadDat(string filename, out DatReaderError error)
        {
            if (String.IsNullOrEmpty(filename))
            {
                error = new DatReaderError(DatError.IOError, "Invalid filename: '" + filename  + "'");
                return null;
            }

            List<string> dirs = new List<string>();

            DAT dat = new DAT();
            dat.DatFileName = filename;
            BinaryReader br=null;
            try
            {
                br = new BinaryReader(File.Open(filename, FileMode.Open));
            }
            catch (IOException io)
            {
                error = new DatReaderError(DatError.IOError, io.Message);
                return null;
            }
            dat.br = br;
            br.BaseStream.Seek(-8, SeekOrigin.End);
            dat.TreeSize = br.ReadInt32();
            dat.FileSizeFromDat = br.ReadInt32();
            
            br.BaseStream.Seek(0, SeekOrigin.Begin); 
            ulong F1DirCount = ToLittleEndian((ulong)br.ReadInt32());
            if (F1DirCount == 0x01 || F1DirCount == 0x33) // Check if it's Fallout 1 dat
            {
                error = new DatReaderError(DatError.IOError, "Fallout 1 DATs not supported.");
                return null;
            }

            if (br.BaseStream.Length != dat.FileSizeFromDat)
            {
                error = new DatReaderError(DatError.WrongSize, "Size is incorrect.");
                return null;
            }
            br.BaseStream.Seek(-(dat.TreeSize+8), SeekOrigin.End);
            dat.FilesTotal = br.ReadInt32();
            byte[] buff = new byte[dat.TreeSize];
            br.Read(buff, 0, (int)(dat.TreeSize - 4));
            dat.FileList = FindFiles(dat, br);

            error = new DatReaderError(DatError.Success, "");
            return dat;
        }

        public static void WriteDat(DAT dat, string filename)
        {
            dat.br.Close();
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create));
            int i=0;
            while (i < dat.FilesTotal) // Write DataBlock
            {
                dat.FileList[i].Offset = (int)bw.BaseStream.Position;
                bw.Write(dat.FileList[i].Buffer, 0, dat.FileList[i].Buffer.Length);
                i++;
            }
            bw.Write((int)dat.FilesTotal);
            i=0;
            int treeSize = (int)bw.BaseStream.Position;
            while (i < dat.FilesTotal) // Write DirTree
            {
                bw.Write((int)dat.FileList[i].FileNameSize);
                bw.Write(dat.FileList[i].Path.ToCharArray(0, dat.FileList[i].Path.Length));
                bw.Write(dat.FileList[i].Compression);
                bw.Write(dat.FileList[i].UnpackedSize);
                bw.Write(dat.FileList[i].PackedSize);
                bw.Write(dat.FileList[i].Offset);
                i++;
            }
            bw.Write((int)(bw.BaseStream.Position - treeSize) + 4);
            bw.Write((int)bw.BaseStream.Position+4);
        }

        public static List<DATFile> FindFiles(DAT dat, BinaryReader br)
        {
            List<DATFile> DatFiles = new List<DATFile>();

            uint FileIndex = 0;
            br.BaseStream.Seek(-(dat.TreeSize + 4), SeekOrigin.End);
            while (FileIndex < dat.FilesTotal)
            {
                DATFile file = new DATFile();
                file.br = br;
                file.FileNameSize = br.ReadInt32();
                char[] namebuf = new Char[file.FileNameSize];
                br.Read(namebuf, 0, (int)file.FileNameSize);
                file.Path = new String(namebuf, 0, namebuf.Length);
                file.FileName = Path.GetFileName(file.Path);
                file.Compression = br.ReadByte();
                file.UnpackedSize = br.ReadInt32();
                file.PackedSize = br.ReadInt32();
                if (file.Compression==0x00&&(file.UnpackedSize != file.PackedSize))
                        file.Compression = 1;
                file.Offset = br.ReadInt32();
                long oldoffset = br.BaseStream.Position;
                // Read whole file into a buffer
                br.BaseStream.Position = file.Offset;
                file.Buffer = new Byte[file.PackedSize];
                br.Read(file.Buffer, 0, file.PackedSize);
                br.BaseStream.Position = oldoffset;

                DatFiles.Add(file);
                FileIndex++;
            }
            return DatFiles;
        }

        public static ulong ToLittleEndian(ulong value)
        {
            byte[] temp = BitConverter.GetBytes(value);
            Array.Reverse(temp);
            return (ulong)BitConverter.ToInt32(temp,0);
        }
    }
}
