using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;
using System.Collections.Generic;

namespace oanda_dotnet.model.position
{
    /// <summary>
    /// The representation of a Position for a single direction (long or short).
    /// </summary>
    public class PositionSide
    {
        /// <summary> 
        /// Number of units in the position (negative value indicates short position, 
        /// positive indicates long position). 
        /// </summary> 
        public decimal Units { get; set; }

        /// <summary> 
        /// Volume-weighted average of the underlying Trade open prices for the 
        /// Position. 
        /// </summary> 
        public PriceValue? AveragePrice { get; set; }

        /// <summary> 
        /// List of the open Trade Ids which contribute to the open Position. 
        /// </summary> 
        public IEnumerable<TradeId> TradeIds { get; set; }

        /// <summary> 
        /// Profit/loss realized by the PositionSIde over the lifetime of the 
        /// Account. 
        /// </summary> 
        public AccountUnits Pl { get; set; }

        /// <summary> 
        /// The unrealized profit/loss of all open Trades that contribute to this 
        /// PositionSIde. 
        /// </summary> 
        public AccountUnits UnrealizedPL { get; set; }

        /// <summary> 
        /// Profit/loss realized by the PositionSIde since the Account’s resettablePL 
        /// was last reset by the client. 
        /// </summary> 
        public AccountUnits ResettablePL { get; set; }

        /// <summary> 
        /// The total amount of financing paId/collected for this PositionSIde over 
        /// the lifetime of the Account. 
        /// </summary> 
        public AccountUnits Financing { get; set; }

        /// <summary> 
        /// The total amount of fees charged over the lifetime of the Account for the 
        /// execution of guaranteed Stop Loss Orders attached to Trades for this 
        /// PositionSIde. 
        /// </summary> 
        public AccountUnits GuaranteedExecutionFees { get; set; }
    }
}
