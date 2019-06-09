using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. 
    /// This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a 
    /// Trade’s dependent Take Profit Order is modified directly through the Trade.
    /// </summary>
    public class TakeProfitDetails
    {
        /// <summary> 
        /// The price that the Take Profit Order will be triggered at. Only one of 
        /// the price and distance fields may be specified. 
        /// </summary> 
        public PriceValue Price { get; set; }

        /// <summary> 
        /// The time in force for the created Take Profit Order. This may only be 
        /// GTC, GTD or GFD. 
        /// </summary> 
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary> 
        /// The date when the Take Profit Order will be cancelled on if timeInForce 
        /// is GTD. 
        /// </summary> 
        public System.DateTime GtdTime { get; set; }

        /// <summary> 
        /// The Client Extensions to add to the Take Profit Order when created. 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }
    }
}
