﻿using oanda_dotnet.model.transaction;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.position
{
    public class GetPositionsResponse : Restv20Response
    {
        public long LastTransactionId { get; set; }
        public ICollection<Position> Positions { get; set; }
    }


    public class GetPositionResponse : Restv20Response
    {
        public long LastTransactionId { get; set; }
        public Position Position { get; set; }

    }


    public class CloseInstrumentPositionResponse : Restv20Response
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
        /// The IDs of all Transactions that were created while satisfying the 
        /// request. 
        /// </summary> 
        public ICollection<long> RelatedTransactionIDs { get; set; }

        /// <summary> 
        /// The ID of the most recent Transaction created for the Account 
        /// </summary> 
        public long LastTransactionID { get; set; }
    }


    public class RejectedCloseInstrumentPositionResponse : Restv20Response
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
        /// The IDs of all Transactions that were created while satisfying the 
        /// request. 
        /// </summary> 
        public ICollection<long> RelatedTransactionIDs { get; set; }

        /// <summary> 
        /// The ID of the most recent Transaction created for the Account 
        /// </summary> 
        public long LastTransactionID { get; set; }

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
