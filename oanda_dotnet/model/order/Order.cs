using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The base Order definition specifies the properties that are common to all Orders.
    /// </summary>
    public abstract class Order
    {
        /// <summary> 
        /// The Order’s Identifier, unique within the Order’s Account. 
        /// </summary> 
        public OrderId Id { get; set; }

        /// <summary> 
        /// The time when the Order was created. 
        /// </summary> 
        public DateTime CreateTime { get; set; }

        /// <summary> 
        /// The current state of the Order. 
        /// </summary> 
        public OrderState State { get; set; }

        /// <summary> 
        /// The client extensions of the Order. Do not set, modify, or delete 
        /// clientExtensions if your account is associated with MT4. 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }

        /// <summary>
        /// The type of the Order.
        /// </summary>
        public abstract OrderType Type { get; }

        /// <summary>
        /// Id of the Transaction that filled this Order (only provIded when the
        /// Order’s state is FILLED)
        /// </summary>
        public TransactionId FillingTransactionId { get; set; }

        /// <summary>
        /// Date/time when the Order was filled (only provIded when the Order’s state
        /// is FILLED)
        /// </summary>
        public DateTime FilledTime { get; set; }

        /// <summary>
        /// Trade Id of Trade opened when the Order was filled (only provIded when
        /// the Order’s state is FILLED and a Trade was opened as a result of the
        /// fill)
        /// </summary>
        public TradeId TradeOpenedId { get; set; }

        /// <summary>
        /// Trade Id of Trade reduced when the Order was filled (only provIded when
        /// the Order’s state is FILLED and a Trade was reduced as a result of the
        /// fill)
        /// </summary>
        public TradeId TradeReducedId { get; set; }

        /// <summary>
        /// Trade Ids of Trades closed when the Order was filled (only provIded when
        /// the Order’s state is FILLED and one or more Trades were closed as a
        /// result of the fill)
        /// </summary>
        public ICollection<TradeId> TradeClosedIds { get; set; }

        /// <summary>
        /// Id of the Transaction that cancelled the Order (only provIded when the
        /// Order’s state is CANCELLED)
        /// </summary>
        public TransactionId CancellingTransactionId { get; set; }

        /// <summary>
        /// Date/time when the Order was cancelled (only provIded when the state of
        /// the Order is CANCELLED)
        /// </summary>
        public DateTime CancelledTime { get; set; }
    }
}