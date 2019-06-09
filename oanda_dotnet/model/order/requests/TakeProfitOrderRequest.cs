using oanda_dotnet.model.pricing;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A TakeProfitOrderRequest specifies the parameters that may be set when creating a Take Profit Order. 
    /// Only one of the price and distance fields may be specified.
    /// </summary>
    public class TakeProfitOrderRequest : ExitOrderRequest
    {
        /// <summary> 
        /// The type of the Order to Create. Must be set to “TAKE_PROFIT” when 
        /// creating a Take Profit Order. 
        /// </summary> 
        public override OrderType Type => OrderType.TakeProfit;

        /// <summary> 
        /// The price threshold specified for the TakeProfit Order. The associated 
        /// Trade will be closed by a market price that is equal to or better than 
        /// this threshold. 
        /// </summary> 
        [Required]
        public PriceValue Price { get; set; }
    }
}
