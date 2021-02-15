using NBA.DataLayer;
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
        }
    }
}
