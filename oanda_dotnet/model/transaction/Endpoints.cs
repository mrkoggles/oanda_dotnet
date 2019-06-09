using oanda_dotnet.model.account;
using RestSharp;
using System;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    public class Endpoints
    {
        /// <summary>
        /// Get a list of Transactions pages that satisfy a time-based Transaction query.
        /// </summary>
        public sealed class GetTransactionsPageEndpoint : Restv20EndpointRequest
        {
            private uint? _pageSize;

            public override string Endpoint => @"/v3/accounts/{accountID}/transactions";
            public override Method Method => Method.GET;


            /// <summary>
            /// Format of DateTime fields in the request and response. 
            /// </summary>
            [EndpointParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
            public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


            /// <summary>
            /// Account Identifier
            /// </summary>
            [Required]
            [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
            public AccountId? AccountId { get; set; }


            /// <summary>
            /// The starting time (inclusive) of the time range for the Transactions being queried. [default=Account Creation Time] 
            /// </summary>
            [EndpointParameter(Name = "from", Type = ParameterType.QueryString)]
            public DateTime? From { get; set; }


            /// <summary>
            /// The ending time (inclusive) of the time range for the Transactions being queried. [default=Request Time] 
            /// </summary>
            [EndpointParameter(Name = "to", Type = ParameterType.QueryString)]
            public DateTime? To { get; set; }


            /// <summary>
            /// The number of Transactions to include in each page of the results. [default=100, maximum=1000] 
            /// </summary>
            [EndpointParameter(Name = "pageSize", Type = ParameterType.QueryString)]
            public uint? PageSize
            {
                get => _pageSize;
                set => _pageSize = (value == null ? null : (uint?)Math.Min((uint)value, 1000));
            }


            /// <summary>
            /// A filter for restricting the types of Transactions to retreive. 
            /// </summary>
            [EndpointParameter(Name = "type", Type = ParameterType.QueryString)]
            public TransactionFilter? Type { get; set; }
        }


        /// <summary>
        /// Get the details of a single Account Transaction.
        /// </summary>
        public sealed class GetTransactionEndpoint : Restv20EndpointRequest
        {
            public override string Endpoint => @"/v3/accounts/{accountID}/transactions/{transactionID}";
            public override Method Method => Method.GET;


            /// <summary>
            /// Format of DateTime fields in the request and response. 
            /// </summary>
            [EndpointParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
            public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


            /// <summary>
            /// Account Identifier
            /// </summary>
            [Required]
            [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
            public AccountId? AccountId { get; set; }


            /// <summary>
            /// A filter for restricting the types of Transactions to retreive. 
            /// </summary>
            [Required]
            [EndpointParameter(Name = "TransactionID", Type = ParameterType.UrlSegment)]
            public TransactionId? TransactionId { get; set; }
        }


        /// <summary>
        /// Get a range of Transactions for an Account based on the Transaction IDs.
        /// </summary>
        public sealed class GetTransactionsByIdsEndpoint : Restv20EndpointRequest
        {
            public override string Endpoint => @"/v3/accounts/{accountID}/transactions/idrange";
            public override Method Method => Method.GET;


            /// <summary>
            /// Format of DateTime fields in the request and response. 
            /// </summary>
            [EndpointParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
            public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


            /// <summary>
            /// Account Identifier
            /// </summary>
            [Required]
            [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
            public AccountId? AccountId { get; set; }


            /// <summary>
            /// The starting time (inclusive) of the time range for the Transactions being queried. [default=Account Creation Time] 
            /// </summary>
            [Required]
            [EndpointParameter(Name = "from", Type = ParameterType.QueryString)]
            public TransactionId? From { get; set; }


            /// <summary>
            /// The ending time (inclusive) of the time range for the Transactions being queried. [default=Request Time] 
            /// </summary>
            [Required]
            [EndpointParameter(Name = "to", Type = ParameterType.QueryString)]
            public TransactionId? To { get; set; }


            /// <summary>
            /// A filter for restricting the types of Transactions to retreive. 
            /// </summary>
            [EndpointParameter(Name = "type", Type = ParameterType.QueryString)]
            public TransactionFilter? Type { get; set; }
        }


        /// <summary>
        /// /v3/accounts/{accountID}/transactions/sinceid
        /// </summary>
        public sealed class GetTransactionsSinceIdEndpoint : Restv20EndpointRequest
        {
            public override string Endpoint => @"";
            public override Method Method => Method.GET;


            /// <summary>
            /// Format of DateTime fields in the request and response. 
            /// </summary>
            [EndpointParameter(Name = "Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
            public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


            /// <summary>
            /// Account Identifier
            /// </summary>
            [Required]
            [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
            public AccountId? AccountId { get; set; }


            /// <summary>
            /// A filter for restricting the types of Transactions to retreive. 
            /// </summary>
            [Required]
            [EndpointParameter(Name = "id", Type = ParameterType.QueryString)]
            public TransactionId? SinceId { get; set; }
        }
    }
}
