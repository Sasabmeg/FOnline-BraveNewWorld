using System.Collections.Generic;

using FOCommon.Worldmap.EncounterGroup;

namespace FOCommon.Parsers
{
    public class FOGAMEParser : BaseParser, IParser
    {
        readonly MSGParser _msgParser;
        readonly List<Faction> _factions = new List<Faction>();
        Dictionary<int, string> _dict = new Dictionary<int, string>();

        public FOGAMEParser(string path)
        {
            this._msgParser = new MSGParser(path);
        }

        public bool Parse()
        {
            if (!_msgParser.Parse())
                return false;
            _dict = _msgParser.GetSpecificData(106021, 107000);
            if (_dict == null)
                return false;

            _IsParsed = true;
            return true;
        }

        public List<Faction> GetFactions()
        {
            foreach(KeyValuePair<int,string> kvp in _dict)
            {
                var faction = new Faction();
                faction.Id = (kvp.Key - 106001) / 10;
                faction.Name = kvp.Value;
                _factions.Add(faction);
            }
            return _factions;
        }
    }
}
