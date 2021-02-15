using MongoDB.Bson;

namespace NBA.DataLayer
{
    public class Stats
    {
        public ObjectId Id { get; set; }
        //public Player Player { get; set; }
        //public string GameId { get; set; }
        public string PlayerID { get; set; }
        public int Points { get; set; }
        public int Rebounds { get; set; }
        public int Assists { get; set; }
        public int Blocks { get; set; }
        public int Steals { get; set; }
    }
}
