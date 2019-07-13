using oanda_dotnet.model.transaction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.trade
{
    public abstract class TradeRestv20EndpointResponse : Restv20EndpointResponse { }

    public sealed class GetTradesResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The list of Trade detail objects
        /// </summary>
        public ICollection<Trade> Trades { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class GetTradeResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The Account’s list of open Trades
        /// </summary>
        public Trade Trade { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class CloseTradeResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The MarketOrder Transaction created to close the Order.
        /// </summary>
        public MarketOrderTransaction OrderCreateTransaction { get; set; }

        /// <summary>
        /// The OrderFill Transaction that fills the Order-closing MarketOrder and
        /// closes the Order.
        /// </summary>
        public OrderFillTransaction OrderFillTransaction { get; set; }

        /// <summary>
        /// The OrderCancel Transaction that immediately cancelled the Order-closing
        /// MarketOrder.
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

    public sealed class CloseTradeErrorResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The MarketTradeReject Transaction that rejects the creation of the Trade-
        /// closing MarketTrade. Only present if the Account exists.
        /// </summary>
        public MarketOrderRejectTransaction TradeRejectTransaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account. Only
        /// present if the Account exists.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

        /// <summary>
        /// The Ids of all Transactions that were created while satisfying the
        /// request. Only present if the Account exists.
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

    public sealed class UpdateTradeClientExtensionsResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that modified the Client Extensions for the Trade
        /// </summary>
        public TradeClientExtensionsModifyTransaction TradeClientExtensionsModifyTransaction { get; set; }

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

    public sealed class UpdateTradeClientExtensionsErrorResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The Transaction that rejected the modification of the Client Extensions
        /// for the Trade
        /// </summary>
        public TradeClientExtensionsModifyRejectTransaction TradeClientExtensionsModifyRejectTransaction { get; set; }

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

    public sealed class SetTradeOrdersResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// The Transaction created that cancels the Trade’s existing Take Profit
        /// Order.
        /// </summary>
        public OrderCancelTransaction TakeProfitOrderCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction created that creates a new Take Profit Order for the
        /// Trade.
        /// </summary>
        public TakeProfitOrderTransaction TakeProfitOrderTransaction { get; set; }

        /// <summary>
        /// The Transaction created that immediately fills the Trade’s new Take
        /// Profit Order. Only provIded if the new Take Profit Order was immediately
        /// filled.
        /// </summary>
        public OrderFillTransaction TakeProfitOrderFillTransaction { get; set; }

        /// <summary>
        /// The Transaction created that immediately cancels the Trade’s new Take
        /// Profit Order. Only provIded if the new Take Profit Order was immediately
        /// cancelled.
        /// </summary>
        public OrderCancelTransaction TakeProfitOrderCreatedCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction created that cancels the Trade’s existing Stop Loss
        /// Order.
        /// </summary>
        public OrderCancelTransaction StopLossOrderCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction created that creates a new Stop Loss Order for the Trade.
        /// </summary>
        public StopLossOrderTransaction StopLossOrderTransaction { get; set; }

        /// <summary>
        /// The Transaction created that immediately fills the Trade’s new Stop
        /// Order. Only provIded if the new Stop Loss Order was immediately filled.
        /// </summary>
        public OrderFillTransaction StopLossOrderFillTransaction { get; set; }

        /// <summary>
        /// The Transaction created that immediately cancels the Trade’s new Stop
        /// Loss Order. Only provIded if the new Stop Loss Order was immediately
        /// cancelled.
        /// </summary>
        public OrderCancelTransaction StopLossOrderCreatedCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction created that cancels the Trade’s existing Trailing Stop
        /// Loss Order.
        /// </summary>
        public OrderCancelTransaction TrailingStopLossOrderCancelTransaction { get; set; }

        /// <summary>
        /// The Transaction created that creates a new Trailing Stop Loss Order for
        /// the Trade.
        /// </summary>
        public TrailingStopLossOrderTransaction TrailingStopLossOrderTransaction { get; set; }

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

    public sealed class SetTradeOrdersErrorResponse : TradeRestv20EndpointResponse
    {
        /// <summary>
        /// An OrderCancelRejectTransaction represents the rejection of the
        /// cancellation of an Order in the client’s Account.
        /// </summary>
        public OrderCancelRejectTransaction TakeProfitOrderCancelRejectTransaction { get; set; }

        /// <summary>
        /// A TakeProfitOrderRejectTransaction represents the rejection of the
        /// creation of a TakeProfit Order.
        /// </summary>
        public TakeProfitOrderRejectTransaction TakeProfitOrderRejectTransaction { get; set; }

        /// <summary>
        /// An OrderCancelRejectTransaction represents the rejection of the
        /// cancellation of an Order in the client’s Account.
        /// </summary>
        public OrderCancelRejectTransaction StopLossOrderCancelRejectTransaction { get; set; }

        /// <summary>
        /// A StopLossOrderRejectTransaction represents the rejection of the creation
        /// of a StopLoss Order.
        /// </summary>
        public StopLossOrderRejectTransaction StopLossOrderRejectTransaction { get; set; }

        /// <summary>
        /// An OrderCancelRejectTransaction represents the rejection of the
        /// cancellation of an Order in the client’s Account.
        /// </summary>
        public OrderCancelRejectTransaction TrailingStopLossOrderCancelRejectTransaction { get; set; }

        /// <summary>
        /// A TrailingStopLossOrderRejectTransaction represents the rejection of the
        /// creation of a TrailingStopLoss Order.
        /// </summary>
        public TrailingStopLossOrderRejectTransaction TrailingStopLossOrderRejectTransaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account.
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
