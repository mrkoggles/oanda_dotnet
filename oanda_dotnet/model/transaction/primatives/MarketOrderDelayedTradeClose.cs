using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// Details for the Market Order extensions specific to a Market Order placed with the intent of fully closing a specific
    /// open trade that should have already been closed but wasn’t due to halted market conditions
    /// </summary>
    public class MarketOrderDelayedTradeClose
    {
        /// <summary> 
        /// The Id of the Trade being closed 
        /// </summary> 
        public TradeId TradeId { get; set; }

        /// <summary> 
        /// The Client Id of the Trade being closed 
        /// </summary> 
        public TradeId ClientTradeId { get; set; }

        /// <summary> 
        /// The Transaction Id of the DelayedTradeClosure transaction to which this 
        /// Delayed Trade Close belongs to 
        /// </summary> 
        public TransactionId SourceTransactionId { get; set; }
    }
}
