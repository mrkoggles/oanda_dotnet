using oanda_dotnet.model.transaction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    public sealed class CreateOrderResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that created the Order specified by the request.
        /// </summary>
        public Transaction OrderCreateTransaction { get; set; }

        /// <summary>
        /// The Transaction that filled the newly created Order. Only provIded when
        /// the Order was immediately filled.
        /// </summary>
        public OrderFillTransaction OrderFillTransaction { get; set; }

        /// <summary>
        /// The Transaction that cancelled the newly created Order. Only provIded
        /// when the Order was immediately cancelled.
        /// </summary>
        public OrderCancelTransaction OrderCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction that reissues the Order. Only provIded when the Order is
        /// configured to be reissued for its remaining units after a partial fill
        /// and the reissue was successful.
        /// </summary>
        public Transaction OrderReissueTransaction { get; set; }

        /// <summary>
        /// The Transaction that rejects the reissue of the Order. Only provIded when
        /// the Order is configured to be reissued for its remaining units after a
        /// partial fill and the reissue was rejected.
        /// </summary>
        public Transaction OrderReissueRejectTransaction { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class CreateOrderErrorResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that rejected the creation of the Order as requested
        /// </summary>
        public Transaction OrderRejectTransaction { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The code of the error that has occurred. This field may not be returned
        /// for some errors.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        [Required]
        public string ErrorMessage { get; set; }

    }

    public sealed class GetOrdersResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The list of Order detail objects
        /// </summary>
        public ICollection<Order> Orders { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class GetOrderDetailsResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The details of the Order requested
        /// </summary>
        public Order Orders { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class ReplaceOrderResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// Specification of the replacing Order
        /// </summary>
        public OrderRequest Order { get; set; }
    }

    public sealed class CancelPendingOrderResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that cancelled the Order
        /// </summary>
        public OrderCancelTransaction OrderCancelTransaction { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class CancelPendingOrderErrorResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that rejected the cancellation of the Order. Only present
        /// if the Account exists.
        /// </summary>
        public OrderCancelRejectTransaction OrderCancelRejectTransaction { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request. Only present if the Account exists.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account. Only
        /// present if the Account exists.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The code of the error that has occurred. This field may not be returned
        /// for some errors.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        [Required]
        public string ErrorMessage { get; set; }

    }

    public sealed class UpdateOrderClientExtensionsResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that modified the Client Extensions for the Order
        /// </summary>
        public OrderClientExtensionsModifyTransaction OrderClientExtensionsModifyTransaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }
    }

    public sealed class UpdateOrderClientExtensionsErrorResponse : Restv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that rejected the modification of the Client Extensions
        /// for the Order
        /// </summary>
        public OrderClientExtensionsModifyRejectTransaction OrderClientExtensionsModifyRejectTransaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request.
        /// </summary>
        public ICollection<TransactionId> RelatedTransactionIds { get; set; }

        /// <summary>
        /// The code of the error that has occurred. This field may not be returned
        /// for some errors.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// The human-readable description of the error that has occurred.
        /// </summary>
        [Required]
        public string ErrorMessage { get; set; }
    }
}
