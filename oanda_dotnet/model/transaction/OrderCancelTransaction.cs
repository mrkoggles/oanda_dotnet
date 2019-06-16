using oanda_dotnet.model.order;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// An OrderCancelTransaction represents the cancellation of an Order in the client’s Account.
    /// </summary>
    public class OrderCancelTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “ORDER_CANCEL” for an
        /// OrderCancelTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.OrderCancel;

        /// <summary>
        /// The Id of the Order cancelled
        /// </summary>
        public OrderId OrderId { get; set; }

        /// <summary>
        /// The client Id of the Order cancelled (only provIded if the Order has a
        /// client Order Id).
        /// </summary>
        public OrderId ClientOrderId { get; set; }

        /// <summary>
        /// The reason that the Order was cancelled.
        /// </summary>
        public OrderCancelReason Reason { get; set; }

        /// <summary>
        /// The Id of the Order that replaced this Order (only provIded if this Order
        /// was cancelled for replacement).
        /// </summary>
        public OrderId ReplacedByOrderId { get; set; }
    }
    

    /// <summary>
    /// An OrderCancelRejectTransaction represents the rejection of the cancellation of an Order in the client’s Account.
    /// </summary>
    public class OrderCancelRejectTransaction : Transaction
    {
        /// <summary>
        /// The Type of the Transaction. Always set to “ORDER_CANCEL_REJECT” for an
        /// OrderCancelRejectTransaction.
        /// </summary>
        public override TransactionType Type => TransactionType.OrderCancelReject;

        /// <summary>
        /// The Id of the Order intended to be cancelled
        /// </summary>
        public OrderId OrderId { get; set; }

        /// <summary>
        /// The client Id of the Order intended to be cancelled (only provIded if the
        /// Order has a client Order Id).
        /// </summary>
        public OrderId ClientOrderId { get; set; }

        /// <summary>
        /// The reason that the Reject Transaction was created
        /// </summary>
        public TransactionRejectReason RejectReason { get; set; }
    }
}
