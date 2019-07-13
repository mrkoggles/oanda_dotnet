using oanda_dotnet.model.pricing;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The dynamic state of an Order. 
    /// This is only relevant to TrailingStopLoss Orders, as no other Order type has dynamic state.
    /// </summary>
    public class DynamicOrderState
    {
        /// <summary> 
        /// The Order’s Id. 
        /// </summary> 
        public OrderId Id { get; set; }

        /// <summary> 
        /// The Order’s calculated trailing stop value. 
        /// </summary> 
        public PriceValue? TrailingStopValue { get; set; }

        /// <summary> 
        /// The distance between the Trailing Stop Loss Order’s trailingStopValue and 
        /// the current Market Price. This represents the distance (in price units) 
        /// of the Order from a triggering price. If the distance could not be 
        /// determined, this value will not be set. 
        /// </summary> 
        public PriceValue? TriggerDistance { get; set; }

        /// <summary> 
        /// True if an exact trigger distance could be calculated. If false, it means 
        /// the provIded trigger distance is a best estimate. If the distance could 
        /// not be determined, this value will not be set. 
        /// </summary> 
        public bool IsTriggerDistanceExact { get; set; }
    }
}
