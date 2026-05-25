
using ProiectPariuri.Forms;
using ProiectPariuri.Models;
using System.ComponentModel;
using System.Linq;

namespace ProiectPariuri
{
    public partial class MainForm : Form
    {
        private BindingList<Match> matches = new BindingList<Match>();
        private BindingList<Bet> bets = new BindingList<Bet>();
        public MainForm()
        {
            InitializeComponent();
            UpdateStatistics();
        }

        private void btnManageMatches_Click(object sender, EventArgs e)
        {
            MatchesForm form = new MatchesForm(matches);
            form.ShowDialog();
            UpdateStatistics();

        }

        private void btnManageBets_Click(object sender, EventArgs e)
        {
            BetsForm form = new BetsForm(matches, bets);
            form.ShowDialog();
            UpdateStatistics();


        }

        private void UpdateStatistics()
        {
            lblTotalMatchesValue.Text =
                matches.Count.ToString();

            lblTotalBetsValue.Text =
                bets.Count.ToString();

            lblWinningBetsValue.Text =
                bets.Count(b => b.Winner).ToString();

            lblTotalAmountValue.Text =
                bets.Sum(b => b.BetAmount).ToString();
        }

        private void lblWinningBetsValue_Click(object sender, EventArgs e)
        {

        }
    }
}
