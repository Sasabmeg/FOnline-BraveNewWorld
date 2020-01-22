using System.IO;

namespace WorldEditor
{
    public static class TableSerializer
    {
        public static bool Exists(string name)
        {
            return File.Exists("./data/" + name + ".dat");
        }

        public static byte[] Load(string name)
        {
            if (!File.Exists("./data/" + name + ".dat"))
                return new byte[0];

            return File.ReadAllBytes("./data/" + name + ".dat");
        }
        public static void Save(string name, byte[] bytes)
        {
            if (!File.Exists("./data"))
                Directory.CreateDirectory("data");
            File.WriteAllBytes("./data/" + name + ".dat", bytes);
        }

    }
}
