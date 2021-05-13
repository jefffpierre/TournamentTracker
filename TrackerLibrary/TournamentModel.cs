using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents name of tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents entry fee.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents list of entered names.
        /// </summary>
        public List<TeamModel> EnteredNames { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents list of prizes.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents list of rounds in Matchup.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
