using oanda_dotnet.model.account;
using oanda_dotnet.model.order;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// An OrderCancelTransaction represents the cancellation of an Order in the client’s Account.
    /// </summary>
    public class OrderCancelTransaction
    {
        /// <summary>
        /// The Transaction’s Identifier.
        /// </summary>
        public TransactionId Id { get; set; }

        /// <summary>
        /// The date/time when the Transaction was created.
        /// </summary>
        public System.DateTime Time { get; set; }

        /// <summary>
        /// The Id of the user that initiated the creation of the Transaction.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The Id of the Account the Transaction was created for.
        /// </summary>
        public AccountId AccountId { get; set; }

        /// <summary>
        /// The Id of the “batch” that the Transaction belongs to. Transactions in
        /// the same batch are applied to the Account simultaneously.
        /// </summary>
        public TransactionId BatchId { get; set; }

        /// <summary>
        /// The Request Id of the request which generated the transaction.
        /// </summary>
        public RequestId RequestId { get; set; }

        /// <summary>
        /// The Type of the Transaction. Always set to “ORDER_CANCEL” for an
        /// OrderCancelTransaction.
        /// </summary>
        public TransactionType Type => TransactionType.OrderCancel;

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
}
