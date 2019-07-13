using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A MarketOrderTradeClose specifies the extensions to a Market Order that has been created specifically to close a Trade.
    /// </summary>
    public class MarketOrderTradeClose
    {
        /// <summary>
        /// The Id of the Trade requested to be closed
        /// </summary>
        public TradeId TradeId { get; set; }

        /// <summary>
        /// The client Id of the Trade requested to be closed
        /// </summary>
        public string ClientTradeId { get; set; }

        /// <summary>
        /// Indication of how much of the Trade to close. Either “ALL”, or a
        /// DecimalNumber reflection a partial close of the Trade.
        /// </summary>
        public string Units { get; set; }
    }
}
