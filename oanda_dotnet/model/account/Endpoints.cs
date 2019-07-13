using oanda_dotnet.model.transaction;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.account
{
    public abstract class AccountRestv20EndpointRequest : Restv20EndpointRequest { }


    /// <summary>
    /// Get a list of all Accounts authorized for the provided token.
    /// </summary>
    public sealed class GetAccountsEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts";
        public override Method Method => Method.GET;
    }


    /// <summary>
    /// Get the full details for a single Account that a client has access to. Full pending Order, open Trade and open Position representations are provided.
    /// </summary>
    public sealed class GetAccountEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}";
        public override Method Method => Method.GET;


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [EndpointParameter(Name ="Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }


    /// <summary>
    /// Get a summary for a single Account that a client has access to.
    /// </summary>
    public sealed class GetAccountSummaryEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/summary";
        public override Method Method => Method.GET;


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [EndpointParameter(Name ="Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }


    /// <summary>
    /// Get the list of tradeable instruments for the given Account. 
    /// The list of tradeable instruments is dependent on the regulatory division that the Account is located in, 
    /// thus should be the same for all Accounts owned by a single user.
    /// </summary>
    public sealed class GetAccountInstrumentsEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/instruments";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// List of instruments to query specifically. 
        /// </summary>
        [EndpointParameter(Name ="instruments", Type = ParameterType.QueryString)]
        public ICollection<InstrumentName> Instruments { get; set; }
    }


    /// <summary>
    /// Set the client-configurable portions of an Account.
    /// </summary>
    public sealed class ConfigureAccountEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/configuration";
        public override Method Method => Method.PATCH;


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [EndpointParameter(Name ="Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Client-defined alias (name) for the Account
        /// </summary>
        [Required]
        public string Alias { get; set; }


        /// <summary>
        /// The string representation of a decimal number.
        /// </summary>
        [Required]
        public decimal? MarginRate { get; set; }


        /// <summary>
        /// The object expression required for the Request Body 
        /// Get Only
        /// </summary>
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public object RequestBody => new
        {
            alias = this.Alias,
            marginRate = Convert.ToString(this.MarginRate)
        };
    }


    /// <summary>
    /// Endpoint used to poll an Account for its current state and changes since a specified TransactionID.
    /// </summary>
    public sealed class GetAccountChangesEndpoint : AccountRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/changes";
        public override Method Method => Method.GET;


        /// <summary>
        /// Format of DateTime fields in the request and response. 
        /// </summary>
        [EndpointParameter(Name ="Accept-Datetime-Format", Type = ParameterType.HttpHeader)]
        public AcceptDateTimeFormat? AcceptDateTimeFormat { get; set; }


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// ID of the Transaction to get Account changes since. 
        /// </summary>
        [Required]
        [EndpointParameter(Name ="sinceTransactionID", Type = ParameterType.QueryString)]
        public TransactionId? SinceTransactionId { get; set; }
    }
}
