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

        public BetsForm(BindingList<Match> matches, BindingList<Bet> bets)
        {
            InitializeComponent();
            this.matches = matches;
            this.bets = bets;
            dgvBets.DataSource = this.bets;
            dgvBets.Columns["Id"].FillWeight = 35;


            dgvBets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBets.MultiSelect = false;
            dgvBets.RowHeadersVisible = false;
            dgvBets.AllowUserToAddRows = false;
        }
    }
}
