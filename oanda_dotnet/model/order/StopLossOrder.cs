using oanda_dotnet.model.pricing;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A StopLossOrder is an order that is linked to an open Trade and created with a price threshold. 
    /// The Order will be filled (closing the Trade) by the first price that is equal to or worse than the threshold. 
    /// A StopLossOrder cannot be used to open a new Position.
    /// </summary>
    public class StopLossOrder : ExitOrder
    {
        /// <summary>
        /// The type of the Order. Always set to “STOP_LOSS” for Stop Loss Orders.
        /// </summary>
        public override OrderType Type => OrderType.StopLoss;

        /// <summary>
        /// The premium that will be charged if the Stop Loss Order is guaranteed and
        /// the Order is filled at the guaranteed price. It is in price units and is
        /// charged for each unit of the Trade.
        /// </summary>
        public decimal GuaranteedExecutionPremium { get; set; }

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
        /// The price threshold specified for the Stop Loss Order. If the guaranteed
        /// flag is false, the associated Trade will be closed by a market price that
        /// is equal to or worse than this threshold. If the flag is true the
        /// associated Trade will be closed at this price.
        /// </summary>
        [Required]
        public PriceValue? Price { get; set; }

        /// <summary>
        /// Specifies the distance (in price units) from the Account’s current price
        /// to use as the Stop Loss Order price. If the Trade is short the
        /// Instrument’s bId price is used, and for long Trades the ask is used.
        /// </summary>
        public decimal Distance { get; set; }

        /// <summary>
        /// Flag indicating that the Stop Loss Order is guaranteed. The default value
        /// depends on the GuaranteedStopLossOrderMode of the account, if it is
        /// REQUIRED, the default will be true, for DISABLED or ENABLED the default
        /// is false.
        /// </summary>
        public bool Guaranteed { get; set; }
    }
}
