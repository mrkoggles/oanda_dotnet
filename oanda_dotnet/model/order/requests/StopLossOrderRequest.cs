using oanda_dotnet.model.pricing;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A StopLossOrderRequest specifies the parameters that may be set when creating a Stop Loss Order.
    /// Only one of the price and distance fields may be specified.
    /// </summary>
    public class StopLossOrderRequest : ExitOrderRequest
    {
        /// <summary> 
        /// The type of the Order to Create. Must be set to “STOP_LOSS” when creating 
        /// a Stop Loss Order. 
        /// </summary> 
        public override OrderType Type => OrderType.StopLoss;

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
        /// Instrument’s bid price is used, and for long Trades the ask is used. 
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
