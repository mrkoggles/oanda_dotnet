using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TradeClientExtensionsModifyTransaction represents the modification of a Trade’s Client Extensions.
    /// </summary>
    public class TradeClientExtensionsModifyTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to
        /// “TRADE_CLIENT_EXTENSIONS_MODIFY” for a
        /// TradeClientExtensionsModifyTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.TradeClientExtensionsModify;

        /// <summary>
        /// The Id of the Trade who’s client extensions are to be modified.
        /// </summary>
        public TradeId TradeId { get; set; }

        /// <summary>
        /// The original Client Id of the Trade who’s client extensions are to be
        /// modified.
        /// </summary>
        public ClientId ClientTradeId { get; set; }

        /// <summary>
        /// The new Client Extensions for the Trade.
        /// </summary>
        public ClientExtensions TradeClientExtensionsModify { get; set; }
    }
}
