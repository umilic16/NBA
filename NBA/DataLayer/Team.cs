using MongoDB.Bson;
using System.Collections.Generic;

namespace NBA.DataLayer
{
    public class Team
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        //public List<Player> Roster { get; set; }
        //public List<Game> Games { get; set; }
        public List<ObjectId> Roster { get; set; }
        public List<ObjectId> Games { get; set; }
    }
}
