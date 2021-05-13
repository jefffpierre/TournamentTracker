using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents list of Entries.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents team who wins.
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents what Round in the current Matchup.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
