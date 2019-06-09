using System;
using System.Collections.Generic;

namespace oanda_dotnet.model.transaction
{
    public abstract class TransactionRestv20EndpointResponse : Restv20EndpointResponse { }

    public sealed class GetTransactionsPageResponse : TransactionRestv20EndpointResponse
    {
        /// <summary>
        /// The starting time provIded in the request.
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// The ending time provIded in the request.
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// The pageSize provIded in the request
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// The Transaction-type filter provIded in the request
        /// </summary>
        public ICollection<TransactionFilter> Type { get; set; }

        /// <summary>
        /// The number of Transactions that are contained in the pages returned
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The list of URLs that represent Idrange queries provIding the data for
        /// each page in the query results
        /// </summary>
        public ICollection<string> Pages { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }

    }

    public sealed class GetTransactionResponse : TransactionRestv20EndpointResponse
    {
        /// <summary>
        /// The details of the Transaction requested
        /// </summary>
        public Transaction Transaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }

    public sealed class GetTransactionsResponse : TransactionRestv20EndpointResponse
    {
        /// <summary>
        /// The list of Transactions that satisfy the request.
        /// </summary>
        public ICollection<Transaction> Transaction { get; set; }

        /// <summary>
        /// The Id of the most recent Transaction created for the Account
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }
}
