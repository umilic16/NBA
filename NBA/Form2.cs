using MongoDB.Bson;
using MongoDB.Driver;
using NBA.DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NBA
{
    public partial class Form2 : Form
    {
        public User currentUser;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            lbUser.Text = currentUser.Username;
            var database = MongoCRUD.GetDB();
            var teamColl = database.GetCollection<Team>("Teams");
            //lista svih timova iz baze - kolekcija "Teams"
            List<Team> teams = teamColl.Find(new BsonDocument()).ToList();
            foreach (Team t in teams)
            {
                cbTeams.Items.Add(t);
                cbHome.Items.Add(t);
                cbAway.Items.Add(t);
            }
            cbTeams.DisplayMember = "Name";
            //cbTeams.ValueMember = "_id";
            cbHome.DisplayMember = "Name";
            //cbHome.ValueMember = "Id";
            cbAway.DisplayMember = "Name";
            //cbAway.ValueMember = "Id";
            var playerColl = database.GetCollection<Player>("Players");
            //lista svih igraca iz baze - kolekcija "Players"
            List<Player> players = playerColl.Find(new BsonDocument()).ToList();
            foreach (Player p in players)
            {
                cbPlayers.Items.Add(p);
                cbStatsPlayer.Items.Add(p);
            }
            cbPlayers.DisplayMember = "Name";
            //cbPlayers.ValueMember = "Id";
            cbStatsPlayer.DisplayMember = "Name";
            //cbStatsPlayer.ValueMember = "Id";
            RefreshGames();
            if (currentUser.FavTeams == null)
                currentUser.FavTeams = new List<string>();
            if (currentUser.FavPlayers == null)
                currentUser.FavPlayers = new List<string>();     
            cbFavorites.SelectedIndex = 0;
            RefreshFavorites();
            dtGame.Format = DateTimePickerFormat.Custom;
            dtGame.CustomFormat = "dd.MM.yyyy";
            lbFavorites.DisplayMember = "Name";
        }
        //refresh prikazi liste utakmica
        private void RefreshGames()
        {
            if (cbStatsGame.Items.Count > 0)
                cbStatsGame.Items.Clear();
            var database = MongoCRUD.GetDB();
            var gameColl = database.GetCollection<Game>("Games");
            List<Game> games;
            //ako nije izabran nijedan igrac po kome se filtriraju utakmice prikazi sve utakmice iz baze
            if (cbStatsPlayer.SelectedIndex < 0)
                games = gameColl.Find(new BsonDocument()).ToList();
            //prikazi utakmice izabranog igraca
            else
            {
                Player player = (Player)cbStatsPlayer.SelectedItem;
                games = gameColl.Find(x => x.HomeTeam == player.TeamId || x.AwayTeam == player.TeamId).ToList();
            }
            foreach (Game g in games)
                cbStatsGame.Items.Add(g);
            //prikazi ih u formatu Home vs Away
            cbStatsGame.DisplayMember = "FormatString";
            //cbStatsGame.ValueMember = "Id";
        }
        //svaki put kad se promeni izabrani tim refresh listu igraca (prikazi igrace koji igraju za taj tim)
        private void cbTeams_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cbPlayers.Items.Clear();
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<Player>("Players");
            Team team = (Team)cbTeams.SelectedItem;
            List<Player> players = collection.Find(x => x.TeamId == team.Id.ToString()).ToList();
            foreach (Player p in players)
                cbPlayers.Items.Add(p);
        }
        //refresh prikaz favorita
        private void RefreshFavorites()
        {
            if (lbFavorites.Items.Count > 0)
                lbFavorites.Items.Clear();
            var database = MongoCRUD.GetDB();
            var teamColl = database.GetCollection<Team>("Teams");
            var playerColl = database.GetCollection<Player>("Players");
            //ako je selektovano da se prikazu timovi prikazi favorite timove ako ne igrace
            if (cbFavorites.SelectedIndex == 0)
                foreach (string id in currentUser.FavTeams)
                {
                    Team t = teamColl.Find(x => x.Id == MongoDB.Bson.ObjectId.Parse(id)).FirstOrDefault();
                    lbFavorites.Items.Add(t);
                }
            else
                foreach (string id in currentUser.FavPlayers)
                {
                    Player p = playerColl.Find(x => x.Id == MongoDB.Bson.ObjectId.Parse(id)).FirstOrDefault();
                    lbFavorites.Items.Add(p);
                }
        }
        //dodavanje favorite tima trenutnom korisniku
        private void btnAddTeamFav_Click(object sender, System.EventArgs e)
        {
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<User>("Users");
            Team team = (Team)cbTeams.SelectedItem;
            //ako izabrani tim vec postoji u listu favorita return ako ne dodaj ga u listu
            if (currentUser.FavTeams.Find(x => x == team.Id.ToString()) != null)
                return;
            currentUser.FavTeams.Add(team.Id.ToString());
            //update bazu refresh prikaz liste
            collection.ReplaceOne(x => x.Id == currentUser.Id, currentUser);
            RefreshFavorites();
        }
        //dodavanje favorite igraca trenutnom korisniku
        private void btnAddPlayerFav_Click(object sender, System.EventArgs e)
        {
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<User>("Users");
            Player player = (Player)cbPlayers.SelectedItem;
            //ako izabrani igrac vec postoji u listu favorita return ako ne dodaj ga
            if (currentUser.FavPlayers.Find(x => x == player.Id.ToString()) != null)
                return;
            currentUser.FavPlayers.Add(player.Id.ToString());
            //update bazu refresh listu
            collection.ReplaceOne(x => x.Id == currentUser.Id, currentUser);
            RefreshFavorites();
        }
        //kad se promeni opcija Favorite teams/Favorite players refresh listu za odgovarajuci parametar/filter
        private void cbFavorites_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshFavorites();
        }
        //dodaj titulu izabranom timu za unetu godinu
        private void btnAddChTeam_Click(object sender, System.EventArgs e)
        {
            if (cbTeams.SelectedIndex < 0)
                return;
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<Team>("Teams");
            Team team = (Team)cbTeams.SelectedItem;
            //ako izabrani tim nema nijednu titulu kreiraj praznu listu
            if (team.Championships == null)
                team.Championships = new List<string>();
            //ako izabrani tim vec ima unetu titulu return ako ne dodaj
            if (team.Championships.Find(x => x == nUDYear.Value.ToString()) != null)
                return;
            //dodaj u listu update bazu
            team.Championships.Add(nUDYear.Value.ToString());
            collection.ReplaceOne(x => x.Id == team.Id, team);
        }
        //dodaj titulu izabranom igracu za unetu godinu
        private void btnAddChPlayer_Click(object sender, System.EventArgs e)
        {
            if (cbPlayers.SelectedIndex < 0)
                return;
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<Player>("Players");
            Player player = (Player)cbPlayers.SelectedItem;
            //ako izabrani igrac nema nijednu titulu kreiraj praznu listu
            if (player.Championships == null)
                player.Championships = new List<string>();
            //ako izabrani igrac ima vec titulu za unetu godinu return ako ne dodaj
            if (player.Championships.Find(x => x == nUDYear.Value.ToString()) != null)
                return;
            //dodaj u listu zatim update bazu
            player.Championships.Add(nUDYear.Value.ToString());
            collection.ReplaceOne(x => x.Id == player.Id, player);
        }
        //dodavanje utakmice u bazu
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (cbHome.SelectedIndex < 0 || cbAway.SelectedIndex < 0)
                return;
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<Game>("Games");
            Team homeTeam = (Team)cbHome.SelectedItem;
            Team awayTeam = (Team)cbAway.SelectedItem;
            //ako su oba tima ista nista ako ne dodaj utakmicu za unete timove i unet datum
            if(homeTeam.Name==awayTeam.Name)
            {
                MessageBox.Show("Ne mozes protiv sebe?");
                return;
            }    
            //dodavanje u bazu
            collection.InsertOne(new Game { 
                HomeTeam = homeTeam.Id.ToString(), 
                AwayTeam = awayTeam.Id.ToString(), 
                Date = dtGame.Value.Date.ToString("dd.MM.yyyy"), 
                FormatString=homeTeam.Name + " vs " + awayTeam.Name});
            //refresh prikaz liste utakmica
            RefreshGames();
        }
        //svaki put kad se promeni izabran igrac refresh se prikaz mogucih utakmica za odabir
        private void cbStatsPlayer_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshGames();
        }
        //dodaj statistiku izabranom igracu
        private void btnAddStats_Click(object sender, System.EventArgs e)
        {
            //provera da li je izabrana neka utakmica
            Game g = (Game)cbStatsGame.SelectedItem;
            if (g == null)
                return;
            //ako je prazna lista za utakmicu kreiraj listu
            if (g.Statistics == null)
                g.Statistics = new List<Stats>();
            Player p = (Player)cbStatsPlayer.SelectedItem;
            //ako igrac vec ima neku statistiku/rezultat za izabranu utakmicu return
            if (g.Statistics.Find(x => x.PlayerID == p.Id.ToString()) != null)
                return;
            //dodaj statistiku u listu
            g.Statistics.Add(new Stats
            {
                PlayerID = p.Id.ToString(),
                Points = (int)nUDPoints.Value,
                Rebounds = (int)nUDRebounds.Value,
                Assists = (int)nUDAssists.Value,
                Blocks = (int)nUDBlocks.Value,
                Steals = (int)nUDSteals.Value
            });
            //update bazu
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<Game>("Games");
            collection.ReplaceOne(x => x.Id == g.Id, g);
        }
        //brisi favorita iz liste i iz baze za trenutnog korisnika
        private void btnDeleteFav_Click(object sender, System.EventArgs e)
        {
            if (lbFavorites.SelectedItem == null)
                return;
            //provera da li treba da se pobrise tim ili igrac
            if (cbFavorites.SelectedIndex == 0)
            {
                Team t = (Team)lbFavorites.SelectedItem;
                currentUser.FavTeams.Remove(t.Id.ToString());
            }
            else
            {
                Player p = (Player)lbFavorites.SelectedItem;
                currentUser.FavPlayers.Remove(p.Id.ToString());
            }
            //update bazu
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Id == currentUser.Id, currentUser);
            //refresh prikaz liste
            RefreshFavorites();
        }
        //prikaz igraca u timu ako je kliknut tim prikaz statistike igraca ako je kliknut igrac
        private void lbFavorites_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var database = MongoCRUD.GetDB();
            //tim
            if(cbFavorites.SelectedIndex==0)
            {
                var playerColl = database.GetCollection<Player>("Players");
                Team t = (Team)lbFavorites.SelectedItem;
                List<Player> players = playerColl.Find(x => x.TeamId == t.Id.ToString()).ToList();
                string championships = "";
                if (t.Championships != null)
                    foreach (string c in t.Championships)
                        championships += c + " Champions\n";
                string roster = "";
                foreach (Player p in players)
                    roster += p.Name + "\n";
                MessageBox.Show(t.Name + "\nHistory:\n" + championships + "Roster:\n" + roster);
            }
            //igrac
            else
            {
                var gameColl = database.GetCollection<Game>("Games");
                //kliknut igrac
                Player p = (Player)lbFavorites.SelectedItem;
                var teamColl = database.GetCollection<Team>("Teams");
                //nadji team za koji igra
                Team t = teamColl.Find(x => x.Id == MongoDB.Bson.ObjectId.Parse(p.TeamId)).FirstOrDefault();
                string championships = "";
                if (p.Championships != null)
                    foreach (string c in p.Championships)
                        championships += c + " Champion\n";
                //nadji sve utakmice koje je odigrao igrac po timu za koji igra
                List<Game> games = gameColl.Find(x => x.HomeTeam == t.Id.ToString() || x.AwayTeam == t.Id.ToString()).ToList();
                //dodaj u listu svaku statistiku/rezultat za izabranog igraca i kreiraj string za prikaz
                List<Stats> stats = new List<Stats>();
                if (games != null)
                    foreach (Game g in games)
                        if (g.Statistics != null)
                            stats.Add(g.Statistics.Find(x => x.PlayerID == p.Id.ToString()));
                var pAvg = stats.Average(x => x.Points);
                var rAvg = stats.Average(x => x.Rebounds);
                var aAvg = stats.Average(x => x.Assists);
                var sAvg = stats.Average(x => x.Steals);
                var bAvg = stats.Average(x => x.Blocks);
                string statString = "P: " + pAvg + " R: " + rAvg + " A: " + aAvg + " S: " + sAvg + " B: " + bAvg + "\n";
                MessageBox.Show(p.Name + " (" + t.Name + ")\nChampionships:\n" + championships + "Stats:\n" + statString);
            }
        }
    }
}
