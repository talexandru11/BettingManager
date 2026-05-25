using ProiectPariuri.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectPariuri.Forms
{
    public partial class BetsForm : Form
    {

        private BindingList<Match> matches = new BindingList<Match>();
        private BindingList<Bet> bets = new BindingList<Bet>();
        private int nextId = 1;

        public BetsForm(BindingList<Match> matches, BindingList<Bet> bets)
        {
            InitializeComponent();
            this.matches = matches;
            this.bets = bets;
            cmbMatches.DataSource = this.matches;
            cmbMatches.DisplayMember = "DisplayName";
            cmbMatches.ValueMember = "Id";
            dgvBets.DataSource = this.bets;
            dgvBets.Columns["Id"].FillWeight = 45;

            cmbBetType.Items.Add("1");
            cmbBetType.Items.Add("X");
            cmbBetType.Items.Add("2");
            cmbBetType.Items.Add("Over 2.5");
            cmbBetType.Items.Add("Under 2.5");
            cmbBetType.SelectedIndex = 0;

            dgvBets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBets.MultiSelect = false;
            dgvBets.RowHeadersVisible = false;
            dgvBets.AllowUserToAddRows = false;
            dgvBets.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvBets.ColumnHeadersDefaultCellStyle.BackColor;
            dgvBets.ColumnHeadersDefaultCellStyle.SelectionForeColor = dgvBets.ColumnHeadersDefaultCellStyle.ForeColor;

            dgvBets.Columns["BettingOdds"].HeaderText = "Odds";
            dgvBets.Columns["BetAmount"].HeaderText = "Amount";
            dgvBets.Columns["PotentialWinnings"].HeaderText = "Potential";
            dgvBets.ClearSelection();

        }

        private Bet selectedBet = null;


        private void btnAddBet_Click(object sender, EventArgs e)
        {
            if (cmbMatches.SelectedItem == null)
            {
                MessageBox.Show("Please select a match.");
                return;
            }

            Bet bet = new Bet();

            bet.Id = nextId;
            Match selectedMatch = cmbMatches.SelectedItem as Match;

            if (selectedMatch == null)
            {
                MessageBox.Show("Please select a match.");
                return;
            }
            bet.MatchId = selectedMatch.Id;
            bet.BetType = cmbBetType.Text;
            bet.BettingOdds = numOdds.Value;
            bet.BetAmount = numAmount.Value;
            bet.Winner = chkWinner.Checked;

            bets.Insert(0, bet);

            nextId++;

            dgvBets.ClearSelection();

        }

        private void dgvBets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedBet =
                dgvBets.Rows[e.RowIndex].DataBoundItem as Bet;

            if (selectedBet == null)
            {
                return;
            }

            cmbMatches.SelectedValue = selectedBet.MatchId;
            cmbBetType.Text = selectedBet.BetType;
            numOdds.Value = selectedBet.BettingOdds;
            numAmount.Value = selectedBet.BetAmount;
            chkWinner.Checked = selectedBet.Winner;
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (selectedBet == null)
            {
                MessageBox.Show("Select a bet first.");
                return;
            }

            selectedBet.MatchId =
                (int)cmbMatches.SelectedValue;

            selectedBet.BetType =
                cmbBetType.Text;

            selectedBet.BettingOdds =
                numOdds.Value;

            selectedBet.BetAmount =
                numAmount.Value;

            selectedBet.Winner =
                chkWinner.Checked;

            dgvBets.Refresh();

            dgvBets.ClearSelection();

        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            if (selectedBet == null)
            {
                MessageBox.Show("Select a bet first.");
                return;
            }

            bets.Remove(selectedBet);

            selectedBet = null;

            dgvBets.ClearSelection();

        }
    }
}
