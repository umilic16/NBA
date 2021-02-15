using MongoDB.Bson;

namespace NBA.DataLayer
{
    public class Stats
    {
        public ObjectId Id { get; set; }
        //public Player Player { get; set; }
        public ObjectId GameId { get; set; }
        public ObjectId PlayerID { get; set; }
        public string Points { get; set; }
        public string Rebounds { get; set; }
        public string Assists { get; set; }
        public string Blocks { get; set; }
        public string Steals { get; set; }
    }
}
