using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents unique ID for price.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents Place number.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents Name of place(standing).
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents Prize amount(cash/points).
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents Prize percentage.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
