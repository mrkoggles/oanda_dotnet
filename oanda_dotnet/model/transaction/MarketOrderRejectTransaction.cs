using oanda_dotnet.model.account;
using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A MarketOrderRejectTransaction represents the rejection of the creation of a Market Order.
    /// </summary>
    public class MarketOrderRejectTransaction
    {
        /// <summary>
        /// The Transaction’s Identifier.
        /// </summary>
        public TransactionId Id { get; set; }

        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        public System.DateTime Time { get; set; }

        /// <summary>
        /// The Id of the user that initiated the creation of the Transaction.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the Account the Transaction was created for.
        /// </summary>
        public AccountId AccountId { get; set; }

        /// <summary>
        /// The Id of the “batch” that the Transaction belongs to. Transactions in
        /// the same batch are applied to the Account simultaneously.
        /// </summary>
        public TransactionId BatchId { get; set; }

        /// <summary>
        /// The Request Id of the request which generated the transaction.
        /// </summary>
        public RequestId RequestId { get; set; }

        /// <summary>
        /// The Type of the Transaction. Always set to “MARKET_ORDER_REJECT” in a
        /// MarketOrderRejectTransaction.
        /// </summary>
        public TransactionType Type => TransactionType.MarketOrderReject;

        /// <summary>
        /// The Market Order’s Instrument.
        /// </summary>
        [Required]
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// The quantity requested to be filled by the Market Order. A posititive
        /// number of units results in a long Order, and a negative number of units
        /// results in a short Order.
        /// </summary>
        [Required]
        public decimal Units { get; set; }

        /// <summary>
        /// The time-in-force requested for the Market Order. Restricted to FOK or
        /// IOC for a MarketOrder.
        /// </summary>
        [Required]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.FOK;

        /// <summary>
        /// The worst price that the client is willing to have the Market Order
        /// filled at.
        /// </summary>
        public PriceValue PriceBound { get; set; }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order
        /// is filled.
        /// </summary>
        [Required]
        public OrderPositionFill PositionFill { get; set; } = OrderPositionFill.Default;

        /// <summary>
        /// Details of the Trade requested to be closed, only provIded when the
        /// Market Order is being used to explicitly close a Trade.
        /// </summary>
        public MarketOrderTradeClose TradeClose { get; set; }

        /// <summary>
        /// Details of the long Position requested to be closed out, only provIded
        /// when a Market Order is being used to explicitly closeout a long Position.
        /// </summary>
        public MarketOrderPositionCloseout LongPositionCloseout { get; set; }

        /// <summary>
        /// Details of the short Position requested to be closed out, only provIded
        /// when a Market Order is being used to explicitly closeout a short
        /// Position.
        /// </summary>
        public MarketOrderPositionCloseout ShortPositionCloseout { get; set; }

        /// <summary>
        /// Details of the Margin Closeout that this Market Order was created for
        /// </summary>
        public MarketOrderMarginCloseout MarginCloseout { get; set; }

        /// <summary>
        /// Details of the delayed Trade close that this Market Order was created for
        /// </summary>
        public MarketOrderDelayedTradeClose DelayedTradeClose { get; set; }

        /// <summary>
        /// The reason that the Market Order was created
        /// </summary>
        public MarketOrderReason Reason { get; set; }

        /// <summary>
        /// Client Extensions to add to the Order (only provIded if the Order is
        /// being created with client extensions).
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

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
