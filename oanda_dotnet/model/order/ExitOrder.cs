using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The base Order definition specifies the properties that are common to orders to enter a position.
    /// </summary>
    public abstract class ExitOrder : Order
    {
        /// <summary>
        /// The time-in-force requested for the Exit Order. Restricted to “GTC”,
        /// “GFD” and “GTD” for Exit Orders.
        /// </summary>
        [Required]
        public TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary>
        /// The date/time when the Exit Order will be cancelled if its
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
        /// The Id of the Order that was replaced by this Order (only provIded if
        /// this Order was created as part of a cancel/replace).
        /// </summary>
        public OrderId ReplacesOrderId { get; set; }

        /// <summary>
        /// The Id of the Order that replaced this Order (only provIded if this Order
        /// was cancelled as part of a cancel/replace).
        /// </summary>
        public OrderId ReplacedByOrderId { get; set; }
    }
}