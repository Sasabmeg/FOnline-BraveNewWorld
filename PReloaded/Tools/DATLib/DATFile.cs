using System;
using System.IO;

namespace DATLib
{
    public class DATFile
    {
        public BinaryReader br { get; set; }
        public String Path { get; set; }
        public String FileName { get; set; }
        public byte Compression { get; set; }
        public int UnpackedSize { get; set; }
        public int PackedSize { get; set; }
        public int Offset { get; set; }
        public byte[] Buffer { get; set; } // Whole file
        public long FileIndex { get; set; }
        public long FileNameSize { get; set; }
        public string ErrorMsg { get; set; }

        private byte[] compressStream(MemoryStream mem)
        {
            MemoryStream outStream = new MemoryStream();
            zlib.ZOutputStream outZStream = new zlib.ZOutputStream(outStream, zlib.zlibConst.Z_BEST_COMPRESSION);
            byte[] data;
            try
            {
                byte[] buffer = new byte[512];
                int len;
                while ((len = mem.Read(buffer, 0, 512)) > 0)
                {
                    outZStream.Write(buffer, 0, len);
                }
                outZStream.finish();
                data = outStream.ToArray();
            }
            finally
            {
                outZStream.Close();
                outStream.Close();
            }
            return data;
        }

        private byte[] decompressStream(MemoryStream mem)
        {
            byte[] data;
            using (MemoryStream outStream = new MemoryStream())
            using (zlib.ZOutputStream outZStream = new zlib.ZOutputStream(outStream))
            try
            {
                byte[] buffer = new byte[512];
                int len;
                while ((len = mem.Read(buffer, 0, 512)) > 0)
                {
                    outZStream.Write(buffer, 0, len);
                }
                outZStream.Flush();
                data = outStream.ToArray();
            }
            catch(zlib.ZStreamException ex)
            {
                ErrorMsg = ex.Message;
                return null;
            }
            finally
            {
                outZStream.finish();
            }
            return data;
        }

        public byte[] GetCompressedData()
        {
            if (Compression == 0x01)
                return Buffer;
            else
            {
                MemoryStream st = new MemoryStream(Buffer);
                byte[] compressed = compressStream(st);
                PackedSize = compressed.Length;
                return compressed;
            }
        }

        public byte[] GetData()
        {
            if (Compression == 0x01)
            {
                using (MemoryStream st = new MemoryStream(Buffer))
                    return decompressStream(st);
            }
            return Buffer;
        }
    }
}
