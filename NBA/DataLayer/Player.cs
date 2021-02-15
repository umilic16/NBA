using MongoDB.Bson;
using System.Collections.Generic;

namespace NBA.DataLayer
{
    public class Player
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        //public string Height { get; set; }
        //public string Weight { get; set; }
        //public string Nationality { get; set; }
        //public Team CurrentTeam { get; set; }
        public string TeamId { get; set; }
        public List<string> Championships { get; set; }
    }
}
