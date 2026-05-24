using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectPariuri.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        public DateTime MatchDate { get; set; }

        public string Competition { get; set; }

        public string FinalScore { get; set; }
    }
}
