
using ProiectPariuri.Forms;
using ProiectPariuri.Models;
using System.ComponentModel;


namespace ProiectPariuri
{
    public partial class MainForm : Form
    {
        private BindingList<Match> matches = new BindingList<Match>();
        private BindingList<Bet> bets = new BindingList<Bet>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            MatchesForm form = new MatchesForm(matches);
            form.ShowDialog();
        }

        private void btnManageBets_Click(object sender, EventArgs e)
        {
            BetsForm form = new BetsForm(matches,bets);
            form.ShowDialog();
        }
    }
}
