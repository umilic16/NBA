using MongoDB.Bson;
using System.Collections.Generic;

namespace NBA.DataLayer
{
    public class Game
    {
        public ObjectId Id { get; set; }
        //public Team HomeTeam { get; set; }
        //public Team AwayTeam { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Result { get; set; }
        //public List<Stats> Statistics { get; set; }
        //public Player MVP { get; set; }
        public List<Stats> Statistics { get; set; }
        //public ObjectId MVP { get; set; }
        public string Date { get; set; }
        public string FormatString { get; set; }
    }
}
