
namespace WorldEditor.Commandline
{
    class Commandline
    {
        public bool Shell { get; set; }
        public bool NoGUI { get; set; }

        public void ParseCommandline(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg == "--nogui")
                {
                    Utils.Log("Running in NoGUI mode.");
                    NoGUI = true;
                }
                if (arg == "--shell")
                {
                    Shell = true;
                }
            }
        }
    }
}
