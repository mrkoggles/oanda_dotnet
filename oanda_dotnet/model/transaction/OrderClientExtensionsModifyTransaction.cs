using oanda_dotnet.model.order;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// A OrderClientExtensionsModifyTransaction represents the modification of an Order’s Client Extensions.
    /// </summary>
    public class OrderClientExtensionsModifyTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to
        /// “ORDER_CLIENT_EXTENSIONS_MODIFY” for a
        /// OrderClienteExtensionsModifyTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.OrderClientExtensionsModify;

        /// <summary>
        /// The Id of the Order who’s client extensions are to be modified.
        /// </summary>
        public OrderId OrderId { get; set; }

        /// <summary>
        /// The original Client Id of the Order who’s client extensions are to be
        /// modified.
        /// </summary>
        public ClientId ClientOrderId { get; set; }

        /// <summary>
        /// The new Client Extensions for the Order.
        /// </summary>
        public ClientExtensions ClientExtensionsModify { get; set; }

        /// <summary>
        /// The new Client Extensions for the Order’s Trade on fill.
        /// </summary>
        public ClientExtensions TradeClientExtensionsModify { get; set; }
    }


    /// <summary>
    /// A OrderClientExtensionsModifyRejectTransaction represents the rejection of the modification of an Order’s Client Extensions.
    /// </summary>
    public class OrderClientExtensionsModifyRejectTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to
        /// “ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT” for a
        /// OrderClientExtensionsModifyRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.OrderClientExtensionsModifyReject;

        /// <summary>
        /// The Id of the Order who’s client extensions are to be modified.
        /// </summary>
        public OrderId OrderId { get; set; }

        /// <summary>
        /// The original Client Id of the Order who’s client extensions are to be
        /// modified.
        /// </summary>
        public ClientId ClientOrderId { get; set; }

        /// <summary>
        /// The new Client Extensions for the Order.
        /// </summary>
        public ClientExtensions ClientExtensionsModify { get; set; }

        /// <summary>
        /// The new Client Extensions for the Order’s Trade on fill.
        /// </summary>
        public ClientExtensions TradeClientExtensionsModify { get; set; }

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
