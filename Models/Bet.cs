using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPariuri.Models
{
    public class Bet
    {
        public int Id { get; set; }

        public int MatchId { get; set; }

        public string BetType { get; set; }

        public decimal BettingOdds { get; set; }

        public decimal BetAmount { get; set; }

        public bool Winner { get; set; }

        public decimal PotentialWinnings
        {
            get
            {
                return BettingOdds * BetAmount;
            }
        }
    }
}
