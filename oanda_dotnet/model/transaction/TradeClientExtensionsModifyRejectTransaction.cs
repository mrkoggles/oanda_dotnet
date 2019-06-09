using oanda_dotnet.model.trade;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A TradeClientExtensionsModifyRejectTransaction represents the rejection of the modification of a Trade’s Client Extensions.
    /// </summary>
    public class TradeClientExtensionsModifyRejectTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to
        /// “TRADE_CLIENT_EXTENSIONS_MODIFY_REJECT” for a
        /// TradeClientExtensionsModifyRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.TradeClientExtensionsModifyReject;

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

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
