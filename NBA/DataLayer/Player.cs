using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA.DataLayer
{
    public class Player
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Nationality { get; set; }
        //public Team CurrentTeam { get; set; }
        public ObjectId TeamId { get; set; }
        public List<string> Awards { get; set; }
    }
}
