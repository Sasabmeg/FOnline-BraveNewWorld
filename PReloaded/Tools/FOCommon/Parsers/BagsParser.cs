using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace FOCommon.Parsers
{
    class BagsParser
    {
        public enum BagItemLocation
        {
            Inventory = 0,
            ActiveHand = 1, // m
            SecondHand = 2, // e
            Armor = 3 // a
        }

        public class BagItem
        {
            public int Pid;
            public int AmountMinimum;
            public int AmountMaximum;
            BagItemLocation Location;

            bool IsConstantAmount { get { return (AmountMinimum == AmountMaximum); } }

            public BagItem( int pid, int min, int max = -1, BagItemLocation location = BagItemLocation.Inventory )
            {
                Pid = pid;
                AmountMinimum = min;
                if( max < 0 || max < min )
                    AmountMaximum = AmountMinimum;
                Location = location;
            }
        }

        public class Bag
        {
            public readonly int Id;
            public List<BagItem> Items = new List<BagItem>();

            public Bag( int id )
            {
                Id = id;
            }

            public void AddItem( int pid, int min, int max = -1, BagItemLocation location = BagItemLocation.Inventory )
            {
            }
        }

        private readonly string _fileName;

        private ParseError _parseError = null;

        public List<Bag> Bags = new List<Bag>();

        public BagsParser( string fileName )
        {
            _fileName = fileName;
        }

        public bool Parse()
        {
            return (Parse( null ));
        }

        public bool Parse( DefineParser itemPids )
        {
            if( !File.Exists( _fileName ) )
                return (false);

            string currentLine = String.Empty;
            List<string> lines = new List<string>( File.ReadAllLines( _fileName ) );

            try
            {
                Dictionary<string, string> bags = new Dictionary<string, string>();
                Dictionary<string, string> defines = new Dictionary<string, string>();

                Match match = null;
                string reAlias = "^(.*?)[\t ]*=[\t ]*(.*?)$";
                string reBag = "^[\t ]*bag_([0-9]+)$";
                foreach( string line in lines )
                {
                    if( line.Length == 0 || Regex.Match( line, "^[\t ]*#" ).Success )
                        continue;

                    match = Regex.Match( line, reAlias );
                    if( match.Success )
                    {
                        string bag = match.Groups[1].Value;
                        string def = match.Groups[2].Value;

                        match = Regex.Match( bag, reBag );
                        if( match.Success )
                        {
                            if( !bags.ContainsKey( bag ) )
                                bags.Add( bag, def );
                            else
                                bags[bag] = def;
                        }
                        else
                        {
                            if( !defines.ContainsKey( bag ) )
                                defines.Add( bag, def );
                            else
                                defines[bag] = def;
                        }
                    }
                }
            }
            catch( IndexOutOfRangeException ex )
            {
                Utils.Log( "Failed to parse line: '" + currentLine + "' in " + _fileName );
                SetError( _fileName, ex, currentLine );
                return false;
            }

            return (true);
        }

        void SetError( string fileName, Exception exception, string errorLine )
        {
            _parseError = new ParseError();
            _parseError.ErrorLine = errorLine;
            _parseError.File = fileName;
            _parseError.Exception = exception;
        }
    }
}
