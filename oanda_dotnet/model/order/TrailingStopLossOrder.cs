using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A TrailingStopLossOrder is an order that is linked to an open Trade and created with a price distance. 
    /// The price distance is used to calculate a trailing stop value for the order that is in the losing direction from the market price at the time of the order’s creation. 
    /// The trailing stop value will follow the market price as it moves in the winning direction, and the order will filled (closing the Trade) by the first price that is equal to or worse than the trailing stop value. 
    /// A TrailingStopLossOrder cannot be used to open a new Position.
    /// </summary>
    public class TrailingStopLossOrder : ExitOrder
    {
        /// <summary>
        /// The type of the Order. Always set to “TRAILING_STOP_LOSS” for Trailing
        /// Stop Loss Orders.
        /// </summary>
        public override OrderType Type => OrderType.TrailingStopLoss;

        /// <summary>
        /// The Id of the Trade to close when the price threshold is breached.
        /// </summary>
        [Required]
        public TradeId TradeId { get; set; }

        /// <summary>
        /// The client Id of the Trade to be closed when the price threshold is
        /// breached.
        /// </summary>
        public ClientId ClientTradeId { get; set; }

        /// <summary>
        /// The price distance (in price units) specified for the TrailingStopLoss
        /// Order.
        /// </summary>
        [Required]
        public decimal Distance { get; set; }

        /// <summary>
        /// The trigger price for the Trailing Stop Loss Order. The trailing stop
        /// value will trail (follow) the market price by the TSL order’s configured
        /// “distance” as the market price moves in the winning direction. If the
        /// market price moves to a level that is equal to or worse than the trailing
        /// stop value, the order will be filled and the Trade will be closed.
        /// </summary>
        public PriceValue TrailingStopValue { get; set; }
    }
}
