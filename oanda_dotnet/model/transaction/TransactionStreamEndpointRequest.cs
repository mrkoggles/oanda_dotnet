using oanda_dotnet.model.account;
using RestSharp;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// Get a stream of Transactions for an Account starting from when the request is made.
    /// </summary>
    public class TransactionStreamEndpointRequest : StreamEndpointRequest<Transaction>
    {
        public override string Endpoint => "/v3/accounts/{accountID}/transactions/stream";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }
}