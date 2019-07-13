using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A DelayedTradeClosure Transaction is created administratively to indicate open trades that should have been closed but weren’t because the open trades’ 
    /// instruments were untradeable at the time. Open trades listed in this transaction will be closed once their respective instruments become tradeable.
    /// </summary>
    public class DelayedTradeClosureTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “DELAYED_TRADE_CLOSURE” for an
        /// DelayedTradeClosureTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.DelayedTradeClosure;

        /// <summary>
        /// The reason for the delayed trade closure
        /// </summary>
        public MarketOrderReason Reason { get; set; }

        /// <summary>
        /// List of Trade ID’s identifying the open trades that will be closed when
        /// their respective instruments become tradeable
        /// </summary>
        public TradeId TradeIds { get; set; }
    }
}
