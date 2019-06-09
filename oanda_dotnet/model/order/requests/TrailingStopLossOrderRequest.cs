using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A TrailingStopLossOrderRequest specifies the parameters that may be set when creating a Trailing Stop Loss Order.
    /// </summary>
    public class TrailingStopLossOrderRequest : ExitOrderRequest
    {
        /// <summary> 
        /// The type of the Order to Create. Must be set to “TRAILING_STOP_LOSS” when 
        /// creating a Trailng Stop Loss Order. 
        /// </summary> 
        public override OrderType Type => OrderType.TrailingStopLoss;

        /// <summary> 
        /// The price distance (in price units) specified for the TrailingStopLoss 
        /// Order. 
        /// </summary> 
        [Required]
        public decimal Distance { get; set; }
    }
}
