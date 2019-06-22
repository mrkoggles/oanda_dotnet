﻿using oanda_dotnet.model.pricing;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// A StopOrderRequest specifies the parameters that may be set when creating a Stop Order.
    /// </summary>
    public class StopOrderRequest : EntryOrderRequest
    {
        /// <summary>
        /// The type of the Order to Create. Must be set to “STOP” when creating a
        /// Stop Order.
        /// </summary>
        public override OrderType Type => OrderType.Stop;

        /// <summary>
        /// The price threshold specified for the Stop Order. The Stop Order will
        /// only be filled by a market price that is equal to or worse than this
        /// price.
        /// </summary>
        [Required]
        public PriceValue? Price { get; set; }

        /// <summary>
        /// The worst market price that may be used to fill this Stop Order. If the
        /// market gaps and crosses through both the price and the priceBound, the
        /// Stop Order will be cancelled instead of being filled.
        /// </summary>
        public PriceValue? PriceBound { get; set; }

        /// <summary>
        /// The time-in-force requested for the Stop Order.
        /// </summary>
        [Required]
        public override TimeInForce TimeInForce { get; set; } = TimeInForce.GTC;

        /// <summary>
        /// The date/time when the Stop Order will be cancelled if its timeInForce is
        /// “GTD”.
        /// </summary>
        public DateTime GTDTime { get; set; }

        /// <summary>
        /// Specification of which price component should be used when determining if
        /// an Order should be triggered and filled. This allows Orders to be
        /// triggered based on the bid, ask, mid, default (ask for buy, bid for sell)
        /// or inverse (ask for sell, bid for buy) price depending on the desired
        /// behaviour. Orders are always filled using their default price component.
        /// This feature is only provided through the REST API. Clients who choose to
        /// specify a non-default trigger condition will not see it reflected in any
        /// of OANDA’s proprietary or partner trading platforms, their transaction
        /// history or their account statements. OANDA platforms always assume that
        /// an Order’s trigger condition is set to the default value when indicating
        /// the distance from an Order’s trigger price, and will always provide the
        /// default trigger condition when creating or modifying an Order. A special
        /// restriction applies when creating a guaranteed Stop Loss Order. In this
        /// case the TriggerCondition value must either be “DEFAULT”, or the
        /// “natural” trigger side “DEFAULT” results in. So for a Stop Loss Order for
        /// a long trade valid values are “DEFAULT” and “BID”, and for short trades
        /// “DEFAULT” and “ASK” are valid.
        /// </summary>
        [Required]
        public OrderTriggerCondition TriggerCondition { get; set; } = OrderTriggerCondition.Default;
    }
}
