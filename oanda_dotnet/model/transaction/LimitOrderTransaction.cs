using oanda_dotnet.model.order;
using oanda_dotnet.model.pricing;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A LimitOrderTransaction represents the creation of a Limit Order in the user’s Account.
    /// </summary>
    public class LimitOrderTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “LIMIT_ORDER” in a
        /// LimitOrderTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.LimitOrder;

        /// <summary>
        /// The Limit Order’s Instrument.
        /// </summary>
        [Required]
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// The quantity requested to be filled by the Limit Order. A posititive
        /// number of units results in a long Order, and a negative number of units
        /// results in a short Order.
        /// </summary>
        [Required]
        public decimal Units { get; set; }

        /// <summary>
        /// The price threshold specified for the Limit Order. The Limit Order will
        /// only be filled by a market price that is equal to or better than this
        /// price.
        /// </summary>
        [Required]
        public PriceValue Price { get; set; }

        /// <summary>
        /// The time-in-force requested for the Limit Order.
        /// </summary>
        [Required]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary>
        /// The date/time when the Limit Order will be cancelled if its timeInForce
        /// is “GTD”.
        /// </summary>
        public DateTime GtdTime { get; set; }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order
        /// is filled.
        /// </summary>
        [Required]
        public OrderPositionFill PositionFill { get; set; } = OrderPositionFill.Default;

        /// <summary>
        /// Specification of which price component should be used when determining if
        /// an Order should be triggered and filled. This allows Orders to be
        /// triggered based on the bId, ask, mId, default (ask for buy, bId for sell)
        /// or inverse (ask for sell, bId for buy) price depending on the desired
        /// behaviour. Orders are always filled using their default price component.
        /// This feature is only provIded through the REST API. Clients who choose to
        /// specify a non-default trigger condition will not see it reflected in any
        /// of OANDA’s proprietary or partner trading platforms, their transaction
        /// history or their account statements. OANDA platforms always assume that
        /// an Order’s trigger condition is set to the default value when indicating
        /// the distance from an Order’s trigger price, and will always provIde the
        /// default trigger condition when creating or modifying an Order. A special
        /// restriction applies when creating a guaranteed Stop Loss Order. In this
        /// case the TriggerCondition value must either be “DEFAULT”, or the
        /// “natural” trigger sIde “DEFAULT” results in. So for a Stop Loss Order for
        /// a long trade valId values are “DEFAULT” and “BId”, and for short trades
        /// “DEFAULT” and “ASK” are valId.
        /// </summary>
        [Required]
        public OrderTriggerCondition TriggerCondition { get; set; } = OrderTriggerCondition.Default;

        /// <summary>
        /// The reason that the Limit Order was initiated
        /// </summary>
        public LimitOrderReason Reason { get; set; }

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
        /// The Id of the Order that this Order replaces (only provIded if this Order
        /// replaces an existing Order).
        /// </summary>
        public OrderId ReplacesOrderId { get; set; }

        /// <summary>
        /// The Id of the Transaction that cancels the replaced Order (only provIded
        /// if this Order replaces an existing Order).
        /// </summary>
        public TransactionId CancellingTransactionId { get; set; }
    }


    /// <summary>
    /// A LimitOrderRejectTransaction represents the rejection of the creation of a Limit Order.
    /// </summary>
    public class LimitOrderRejectTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “LIMIT_ORDER_REJECT” in a
        /// LimitOrderRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.LimitOrderReject;

        /// <summary>
        /// The Limit Order’s Instrument.
        /// </summary>
        [Required]
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// The quantity requested to be filled by the Limit Order. A posititive
        /// number of units results in a long Order, and a negative number of units
        /// results in a short Order.
        /// </summary>
        [Required]
        public decimal Units { get; set; }

        /// <summary>
        /// The price threshold specified for the Limit Order. The Limit Order will
        /// only be filled by a market price that is equal to or better than this
        /// price.
        /// </summary>
        [Required]
        public PriceValue Price { get; set; }

        /// <summary>
        /// The time-in-force requested for the Limit Order.
        /// </summary>
        [Required]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary>
        /// The date/time when the Limit Order will be cancelled if its timeInForce
        /// is “GTD”.
        /// </summary>
        public DateTime GtdTime { get; set; }

        /// <summary>
        /// Specification of how Positions in the Account are modified when the Order
        /// is filled.
        /// </summary>
        [Required]
        public OrderPositionFill PositionFill { get; set; } = OrderPositionFill.Default;

        /// <summary>
        /// Specification of which price component should be used when determining if
        /// an Order should be triggered and filled. This allows Orders to be
        /// triggered based on the bId, ask, mId, default (ask for buy, bId for sell)
        /// or inverse (ask for sell, bId for buy) price depending on the desired
        /// behaviour. Orders are always filled using their default price component.
        /// This feature is only provIded through the REST API. Clients who choose to
        /// specify a non-default trigger condition will not see it reflected in any
        /// of OANDA’s proprietary or partner trading platforms, their transaction
        /// history or their account statements. OANDA platforms always assume that
        /// an Order’s trigger condition is set to the default value when indicating
        /// the distance from an Order’s trigger price, and will always provIde the
        /// default trigger condition when creating or modifying an Order. A special
        /// restriction applies when creating a guaranteed Stop Loss Order. In this
        /// case the TriggerCondition value must either be “DEFAULT”, or the
        /// “natural” trigger sIde “DEFAULT” results in. So for a Stop Loss Order for
        /// a long trade valId values are “DEFAULT” and “BId”, and for short trades
        /// “DEFAULT” and “ASK” are valId.
        /// </summary>
        [Required]
        public OrderTriggerCondition TriggerCondition { get; set; } = OrderTriggerCondition.Default;

        /// <summary>
        /// The reason that the Limit Order was initiated
        /// </summary>
        public LimitOrderReason Reason { get; set; }

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
        /// The Id of the Order that this Order was intended to replace (only
        /// provIded if this Order was intended to replace an existing Order).
        /// </summary>
        public OrderId IntendedReplacesOrderId { get; set; }

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
