using oanda_dotnet.model.order;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// TrailingStopLossDetails specifies the details of a Trailing Stop Loss Order to be created on behalf of a client. 
    /// This may happen when an Order is filled that opens a Trade requiring a Trailing Stop Loss, or when a 
    /// Trade’s dependent Trailing Stop Loss Order is modified directly through the Trade.
    /// </summary>
    public class TrailingStopLossDetails : IExitOrderDetail
    {
        /// <summary> 
        /// The distance (in price units) from the Trade’s fill price that the 
        /// Trailing Stop Loss Order will be triggered at. 
        /// </summary> 
        public decimal Distance { get; set; }

        /// <summary> 
        /// The time in force for the created Trailing Stop Loss Order. This may only 
        /// be GTC, GTD or GFD. 
        /// </summary> 
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary> 
        /// The date when the Trailing Stop Loss Order will be cancelled on if 
        /// timeInForce is GTD. 
        /// </summary> 
        public System.DateTime GtdTime { get; set; }

        /// <summary> 
        /// The Client Extensions to add to the Trailing Stop Loss Order when 
        /// created. 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }
    }
}
