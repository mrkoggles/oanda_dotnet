using oanda_dotnet.model.order;
using oanda_dotnet.model.position;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.transaction;
using System.Collections.Generic;

namespace oanda_dotnet.model.account
{
    /// <summary>
    /// An AccountChanges Object is used to represent the changes to an Account’s Orders, Trades and Positions since a specified Account TransactionID in the past.
    /// </summary>
    public class AccountChanges
    {
        /// <summary> 
        /// The Orders created. These Orders may have been filled, cancelled or 
        /// triggered in the same period. 
        /// </summary> 
        public ICollection<Order> OrdersCreated { get; set; }

        /// <summary> 
        /// The Orders cancelled. 
        /// </summary> 
        public ICollection<Order> OrdersCancelled { get; set; }

        /// <summary> 
        /// The Orders filled. 
        /// </summary> 
        public ICollection<Order> OrdersFilled { get; set; }

        /// <summary> 
        /// The Orders triggered. 
        /// </summary> 
        public ICollection<Order> OrdersTriggered { get; set; }

        /// <summary> 
        /// The Trades opened. 
        /// </summary> 
        public ICollection<TradeSummary> TradesOpened { get; set; }

        /// <summary> 
        /// The Trades reduced. 
        /// </summary> 
        public ICollection<TradeSummary> TradesReduced { get; set; }

        /// <summary> 
        /// The Trades closed. 
        /// </summary> 
        public ICollection<TradeSummary> TradesClosed { get; set; }

        /// <summary> 
        /// The Positions changed. 
        /// </summary> 
        public ICollection<Position> Positions { get; set; }

        /// <summary> 
        /// The Transactions that have been generated. 
        /// </summary> 
        public ICollection<Transaction> Transactions { get; set; }
    }
}
