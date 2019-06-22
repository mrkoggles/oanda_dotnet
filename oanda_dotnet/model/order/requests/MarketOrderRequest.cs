using oanda_dotnet.model.pricing;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A MarketOrderRequest specifies the parameters that may be set when creating a Market Order.
    /// </summary>
    public class MarketOrderRequest : EntryOrderRequest
    {
        /// <summary> 
        /// The type of the Order to Create. Must be set to “MARKET” when creating a 
        /// Market Order. 
        /// </summary> 
        public override OrderType Type => OrderType.Market;

        /// <summary> 
        /// The time-in-force requested for the Market Order. Restricted to FOK or 
        /// IOC for a MarketOrder. 
        /// </summary> 
        [Required]
        public override TimeInForce TimeInForce { get; set; } = TimeInForce.FOK;

        /// <summary> 
        /// The worst price that the client is willing to have the Market Order 
        /// filled at. 
        /// </summary> 
        public PriceValue? PriceBound { get; set; }
    }
}
