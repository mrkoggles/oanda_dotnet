using oanda_dotnet.model.order;
using oanda_dotnet.model.trade;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TrailingStopLossOrderTransaction represents the creation of a TrailingStopLoss Order in the user’s Account.
    /// </summary>
    public class TrailingStopLossOrderTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “TRAILING_STOP_LOSS_ORDER” in
        /// a TrailingStopLossOrderTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.TrailingStopLossOrder;

        /// <summary>
        /// The Id of the Trade to close when the price threshold is breached.
        /// </summary>
        [Required]
        public TradeId TradeId { get; set; }

        /// <summary>
        /// The client Id of the Trade to be closed when the price threshold is
        /// breached.
        /// </summary>
        public ClientId ClientTradeId { get; set; }

        /// <summary>
        /// The price distance (in price units) specified for the TrailingStopLoss
        /// Order.
        /// </summary>
        [Required]
        public decimal Distance { get; set; }

        /// <summary>
        /// The time-in-force requested for the TrailingStopLoss Order. Restricted to
        /// “GTC”, “GFD” and “GTD” for TrailingStopLoss Orders.
        /// </summary>
        [Required]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary>
        /// The date/time when the StopLoss Order will be cancelled if its
        /// timeInForce is “GTD”.
        /// </summary>
        public DateTime GtdTime { get; set; }

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
        /// The reason that the Trailing Stop Loss Order was initiated
        /// </summary>
        public TrailingStopLossOrderReason Reason { get; set; }

        /// <summary>
        /// Client Extensions to add to the Order (only provIded if the Order is
        /// being created with client extensions).
        /// </summary>
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// The Id of the OrderFill Transaction that caused this Order to be created
        /// (only provIded if this Order was created automatically when another Order
        /// was filled).
        /// </summary>
        public TransactionId OrderFillTransactionId { get; set; }

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
}
