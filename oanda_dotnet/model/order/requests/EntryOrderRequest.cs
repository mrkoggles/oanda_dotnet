using oanda_dotnet.model.transaction;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The base Entry Order specification used when requesting that an Entry Order be created.
    /// Each specific Entry Order-type extends this definition.
    /// </summary>
    public abstract class EntryOrderRequest : OrderRequest
    {
        /// <summary> 
        /// The Exit Order’s Instrument. 
        /// </summary> 
        [Required]
        public InstrumentName Instrument { get; set; }

        /// <summary> 
        /// The quantity requested to be filled by the Exit Order. A posititive 
        /// number of units results in a long Order, and a negative number of units 
        /// results in a short Order. 
        /// </summary> 
        [Required]
        public decimal Units { get; set; }

        /// <summary> 
        /// Specification of how Positions in the Account are modified when the Order 
        /// is filled. 
        /// </summary> 
        [Required]
        public OrderPositionFill PositionFill { get; set; } = OrderPositionFill.Default;

        /// <summary> 
        /// TakeProfitDetails specifies the details of a Take Profit Order to be 
        /// created on behalf of a client. This may happen when an Order is filled 
        /// that opens a Trade requiring a Take Profit, or when a Trade’s dependent 
        /// Take Profit Order is modified directly through the Trade. 
        /// </summary> 
        public TakeProfitDetails TakeProfitOnFill { get; set; }

        /// <summary> 
        /// StopLossDetails specifies the details of a Stop Loss Order to be created 
        /// on behalf of a client. This may happen when an Order is filled that opens 
        /// a Trade requiring a Stop Loss, or when a Trade’s dependent Stop Loss 
        /// Order is modified directly through the Trade. 
        /// </summary> 
        public StopLossDetails StopLossOnFill { get; set; }

        /// <summary> 
        /// TrailingStopLossDetails specifies the details of a Trailing Stop Loss 
        /// Order to be created on behalf of a client. This may happen when an Order 
        /// is filled that opens a Trade requiring a Trailing Stop Loss, or when a 
        /// Trade’s dependent Trailing Stop Loss Order is modified directly through 
        /// the Trade. 
        /// </summary> 
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }

        /// <summary> 
        /// Client Extensions to add to the Trade created when the Order is filled 
        /// (if such a Trade is created). Do not set, modify, or delete 
        /// tradeClientExtensions if your account is associated with MT4. 
        /// </summary> 
        public ClientExtensions TradeClientExtensions { get; set; }
    }
}
