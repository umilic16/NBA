using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.DataLayer
{
    public class Team
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Founded { get; set; }
        public string Year { get; set; }
        //public List<Player> Roster { get; set; }
        //public List<Game> Games { get; set; }
        public List<ObjectId> Roster { get; set; }
        public List<ObjectId> Games { get; set; }
        public List<string> Titles { get; set; }
    }
}
