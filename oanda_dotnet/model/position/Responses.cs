using oanda_dotnet.model.transaction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.position
{
    public sealed class GetPositionsResponse : Restv20EndpointResponse
    {
        public long LastTransactionId { get; set; }
        public ICollection<Position> Positions { get; set; }
    }


    public sealed class GetPositionResponse : Restv20EndpointResponse
    {
        public long LastTransactionId { get; set; }
        public Position Position { get; set; }

    }

    public sealed class CloseInstrumentPositionResponse : Restv20EndpointResponse
    {
        /// <summary> 
        /// The MarketOrderTransaction created to close the long Position. 
        /// </summary> 
        public MarketOrderTransaction LongOrderCreateTransaction { get; set; }

        /// <summary> 
        /// OrderFill Transaction that closes the long Position 
        /// </summary> 
        public OrderFillTransaction LongOrderFillTransaction { get; set; }

        /// <summary> 
        /// OrderCancel Transaction that cancels the MarketOrder created to close the 
        /// long Position 
        /// </summary> 
        public OrderCancelTransaction LongOrderCancelTransaction { get; set; }

        /// <summary> 
        /// The MarketOrderTransaction created to close the short Position. 
        /// </summary> 
        public MarketOrderTransaction ShortOrderCreateTransaction { get; set; }

        /// <summary> 
        /// OrderFill Transaction that closes the short Position 
        /// </summary> 
        public OrderFillTransaction ShortOrderFillTransaction { get; set; }

        /// <summary> 
        /// OrderCancel Transaction that cancels the MarketOrder created to close the 
        /// short Position 
        /// </summary> 
        public OrderCancelTransaction ShortOrderCancelTransaction { get; set; }

        /// <summary> 
        /// The Ids of all Transactions that were created while satisfying the 
        /// request. 
        /// </summary> 
        public ICollection<long> RelatedTransactionIds { get; set; }

        /// <summary> 
        /// The Id of the most recent Transaction created for the Account 
        /// </summary> 
        public long LastTransactionId { get; set; }
    }


    public sealed class RejectedCloseInstrumentPositionResponse : Restv20EndpointResponse
    {
        /// <summary> 
        /// The Transaction created that rejects the creation of a MarketOrder to 
        /// close the long Position. 
        /// </summary> 
        public MarketOrderRejectTransaction LongOrderRejectTransaction { get; set; }

        /// <summary> 
        /// The Transaction created that rejects the creation of a MarketOrder to 
        /// close the short Position. 
        /// </summary> 
        public MarketOrderRejectTransaction ShortOrderRejectTransaction { get; set; }

        /// <summary> 
        /// The Ids of all Transactions that were created while satisfying the 
        /// request. 
        /// </summary> 
        public ICollection<long> RelatedTransactionIds { get; set; }

        /// <summary> 
        /// The Id of the most recent Transaction created for the Account 
        /// </summary> 
        public long LastTransactionId { get; set; }

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
