using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.DataLayer
{
    public class Game
    {
        public ObjectId Id { get; set; }
        //public Team HomeTeam { get; set; }
        //public Team AwayTeam { get; set; }
        public ObjectId HomeTeam { get; set; }
        public ObjectId AwayTeam { get; set; }
        public string Result { get; set; }
        //public List<Stats> Statistics { get; set; }
        //public Player MVP { get; set; }
        public List<ObjectId> Statistics { get; set; }
        public ObjectId MVP { get; set; }
        public string Date { get; set; }
    }
}
