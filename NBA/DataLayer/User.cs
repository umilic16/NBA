using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.DataLayer
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public List<Player> FavPlayers { get; set; }
        //public List<Team> FavTeams { get; set; }
        public List<ObjectId> FavPlayers { get; set; }
        public List<ObjectId> FavTeams { get; set; }
    }
}
