using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The base Exit Order specification used when requesting that an Exit Order be created.
    /// Each specific Entry Order-type extends this definition.
    /// </summary>
    public abstract class ExitOrderRequest : OrderRequest
    {
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
        /// The time-in-force requested for the StopLoss Order. Restricted to “GTC”, 
        /// “GFD” and “GTD” for StopLoss Orders. 
        /// </summary> 
        [Required]
        public override TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

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
    }
}
