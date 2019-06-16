using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A FixedPriceOrderTransaction represents the creation of a Fixed Price Order in the user’s account. A Fixed Price Order is an Order that is filled immediately at a specified price.
    /// </summary>
    public class FixedPriceOrderTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “FIXED_PRICE_ORDER” in a
        /// FixedPriceOrderTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.FixedPriceOrder;

        /// <summary>
        /// The Fixed Price Order’s Instrument.
        /// </summary>
        [Required]
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// The quantity requested to be filled by the Fixed Price Order. A
        /// posititive number of units results in a long Order, and a negative number
        /// of units results in a short Order.
        /// </summary>
        [Required]
        public decimal Units { get; set; }

        /// <summary>
        /// The price specified for the Fixed Price Order. This price is the exact
        /// price that the Fixed Price Order will be filled at.
        /// </summary>
        [Required]
        public PriceValue Price { get; set; }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order
        /// is filled.
        /// </summary>
        [Required]
        public OrderPositionFill PositionFill { get; set; } = OrderPositionFill.Default;

        /// <summary>
        /// The state that the trade resulting from the Fixed Price Order should be
        /// set to.
        [Required]
        /// </summary>
        public string TradeState { get; set; }

        /// <summary>
        /// The reason that the Fixed Price Order was created
        /// </summary>
        public FixedPriceOrderReason Reason { get; set; }

        /// <summary>
        /// The client extensions for the Fixed Price Order.
        /// </summary>
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// The specification of the Take Profit Order that should be created for a
        /// Trade opened when the Order is filled (if such a Trade is created).
        /// </summary>
        public TakeProfitDetails TakeProfitOnFill { get; set; }

        /// <summary>
        /// The specification of the Stop Loss Order that should be created for a
        /// Trade opened when the Order is filled (if such a Trade is created).
        /// </summary>
        public StopLossDetails StopLossOnFill { get; set; }

        /// <summary>
        /// The specification of the Trailing Stop Loss Order that should be created
        /// for a Trade that is opened when the Order is filled (if such a Trade is
        /// created).
        /// </summary>
        public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }

        /// <summary>
        /// Client Extensions to add to the Trade created when the Order is filled
        /// (if such a Trade is created). Do not set, modify, delete
        /// tradeClientExtensions if your account is associated with MT4.
        /// </summary>
        public ClientExtensions TradeClientExtensions { get; set; }
    }
}
