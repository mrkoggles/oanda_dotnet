using oanda_dotnet.model.pricing;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A MarketIfTouchedOrderRequest specifies the parameters that may be set when creating a Market-if-Touched Order.
    /// </summary>
    public class MarketIfTouchedOrderRequest : EntryOrderRequest
    {
        /// <summary> 
        /// The type of the Order to Create. Must be set to “MARKET_IF_TOUCHED” when 
        /// creating a Market If Touched Order. 
        /// </summary> 
        public override OrderType Type => OrderType.MarketIfTouched;

        /// <summary> 
        /// The price threshold specified for the MarketIfTouched Order. The 
        /// MarketIfTouched Order will only be filled by a market price that crosses 
        /// this price from the direction of the market price at the time when the 
        /// Order was created (the initialMarketPrice). Depending on the value of the 
        /// Order’s price and initialMarketPrice, the MarketIfTouchedOrder will 
        /// behave like a Limit or a Stop Order. 
        /// </summary> 
        [Required]
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The worst market price that may be used to fill this MarketIfTouched 
        /// Order. 
        /// </summary> 
        public PriceValue PriceBound { get; set; }

        /// <summary> 
        /// The time-in-force requested for the MarketIfTouched Order. Restricted to 
        /// “GTC”, “GFD” and “GTD” for MarketIfTouched Orders. 
        /// </summary> 
        [Required]
        public override TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary> 
        /// The date/time when the MarketIfTouched Order will be cancelled if its 
        /// timeInForce is “GTD”. 
        /// </summary> 
        public DateTime GtdTime { get; set; }

        /// <summary> 
        /// Specification of which price component should be used when determining if 
        /// an Order should be triggered and filled. This allows Orders to be 
        /// triggered based on the bid, ask, mid, default (ask for buy, bid for sell) 
        /// or inverse (ask for sell, bid for buy) price depending on the desired 
        /// behaviour. Orders are always filled using their default price component. 
        /// This feature is only provided through the REST API. Clients who choose to 
        /// specify a non-default trigger condition will not see it reflected in any 
        /// of OANDA’s proprietary or partner trading platforms, their transaction 
        /// history or their account statements. OANDA platforms always assume that 
        /// an Order’s trigger condition is set to the default value when indicating 
        /// the distance from an Order’s trigger price, and will always provide the 
        /// default trigger condition when creating or modifying an Order. A special 
        /// restriction applies when creating a guaranteed Stop Loss Order. In this 
        /// case the TriggerCondition value must either be “DEFAULT”, or the 
        /// “natural” trigger side “DEFAULT” results in. So for a Stop Loss Order for 
        /// a long trade valid values are “DEFAULT” and “BID”, and for short trades 
        /// “DEFAULT” and “ASK” are valid. 
        /// </summary> 
        [Required]
        public OrderTriggerCondition TriggerCondition { get; set; } = OrderTriggerCondition.Default;
    }
}
