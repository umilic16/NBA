using MongoDB.Bson;
using MongoDB.Driver;
using NBA.DataLayer;
using System;
using System.Windows.Forms;

namespace NBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            lbUsernameError.Visible = false;
            lbPasswordError.Visible = false;
            //provera da li su prazni text boxovi
            if (tbSignPass.TextLength == 0 || tbSignUser.TextLength == 0)
            {
                MessageBox.Show("Fields cant be empty");
                return;
            }
            //provera da li je ponovljena sifra ispravno
            if (tbSignPass.Text != tbSignRepPass.Text)
            {
                lbPasswordError.Visible = true;
                return;
            }
            //var client = new MongoClient("mongodb://localhost:27017/");
            //var database = client.GetDatabase("NBA");
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<User>("Users");
            //provera da li posotji vec uneti username u bazi
            var users = collection.Find(x => x.Username == tbSignUser.Text).FirstOrDefault();
            if(users == null)
            {
                MongoCRUD.Create("Users", new User { 
                    Username = tbSignUser.Text,
                    Password = tbSignPass.Text
                });
                MessageBox.Show("User created");
                tbSignPass.Text = "";
                tbSignRepPass.Text = "";
                tbSignUser.Text = "";
            }
            else
                lbUsernameError.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbLoginError.Visible = false;
            //provera da li su prazni text boxovi
            if (tbLogPass.TextLength == 0 || tbLogUser.TextLength == 0)
            {
                MessageBox.Show("Fields cant be empty");
                return;
            }
            ////provera username pass
            var database = MongoCRUD.GetDB();
            var collection = database.GetCollection<User>("Users");
            //provera da li posotji vec uneti username u bazi
            var currentUser = collection.Find(x=>x.Username==tbLogUser.Text && x.Password == tbLogPass.Text).FirstOrDefault();
            if (currentUser!=null)
            {
                    tbLogUser.Text = "";
                    tbLogPass.Text = "";
                    Form2 forma = new Form2();
                    forma.currentUser = currentUser;
                    forma.ShowDialog();
            }
            else
                lbLoginError.Visible = true;
        }
    }
}
