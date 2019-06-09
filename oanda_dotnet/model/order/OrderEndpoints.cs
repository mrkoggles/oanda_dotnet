using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// Create an Order for an Account
    /// </summary>
    public sealed class CreateOrderEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/orders";
        public override Method Method => Method.POST;


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
        /// Specification of the Order to create
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public OrderRequest Order { get; set; } 
    }


    /// <summary>
    /// Get a list of Orders for an Account
    /// </summary>
    public sealed class GetOrdersEndpoint : Restv20EndpointRequest
    {
        private uint? _count;


        public override string Endpoint => @"/v3/accounts/{accountID}/orders";
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
        /// List of Order IDs to retrieve 
        /// </summary>
        [EndpointParameter(Name = "ids", Type = ParameterType.QueryString)]
        public ICollection<OrderId> Ids { get; set; }


        /// <summary>
        /// The state to filter the requested Orders by [default=PENDING] 
        /// </summary>
        [EndpointParameter(Name = "state", Type = ParameterType.QueryString)]
        public OrderStateFilter? State { get; set; }


        /// <summary>
        /// The instrument to filter the requested orders by 
        /// </summary>
        [EndpointParameter(Name = "instrument", Type = ParameterType.QueryString)]
        public InstrumentName? Instrument { get; set; }


        /// <summary>
        /// The maximum number of Orders to return [default=50, maximum=500] 
        /// </summary>
        [EndpointParameter(Name = "count", Type = ParameterType.QueryString)]
        public uint? Count
        {
            get => _count;
            set => _count = (value == null ? null : (uint?)System.Math.Min((uint)value, 500));            
        }


        /// <summary>
        /// The maximum Order ID to return. If not provided the most recent Orders in the Account are returned 
        /// </summary>
        [EndpointParameter(Name = "beforeID", Type = ParameterType.QueryString)]
        public OrderId BeforeOrderId { get; set; }
    }


    /// <summary>
    /// List all pending Orders in an Account
    /// </summary>
    public sealed class GetPendingOrdersEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/pendingOrders";
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
    }


    /// <summary>
    /// Get details for a single Order in an Account
    /// </summary>
    public sealed class GetOrderDetailsEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/orders/{orderSpecifier}";
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
        /// The Order Specifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "orderSpecifier", Type = ParameterType.UrlSegment)]
        public OrderSpecifier? OrderSpecifier { get; set; }
    }


    /// <summary>
    /// Replace an Order in an Account by simultaneously cancelling it and creating a replacement Order
    /// </summary>
    public sealed class ReplaceOrderEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/orders/{orderSpecifier}";
        public override Method Method => Method.PUT;


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
        /// The Order Specifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "orderSpecifier", Type = ParameterType.UrlSegment)]
        public OrderSpecifier? OrderSpecifier { get; set; }


        /// <summary>
        /// Specification of the replacing Order
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public OrderRequest Order { get; set; }
    }


    /// <summary>
    /// Cancel a pending Order in an Account
    /// </summary>
    public sealed class CancelPendingOrderEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/orders/{orderSpecifier}/cancel";
        public override Method Method => Method.PUT;


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
        /// The Order Specifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "orderSpecifier", Type = ParameterType.UrlSegment)]
        public OrderSpecifier? OrderSpecifier { get; set; }
    }


    /// <summary>
    /// Update the Client Extensions for an Order in an Account. Do not set, modify, or delete clientExtensions if your account is associated with MT4.
    /// </summary>
    public sealed class UpdateOrdersClientExtensionsEndpoint : Restv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/orders/{orderSpecifier}/clientExtensions";
        public override Method Method => Method.PUT;


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
        /// The Order Specifier
        /// </summary>
        [Required]
        [EndpointParameter(Name = "orderSpecifier", Type = ParameterType.UrlSegment)]
        public OrderSpecifier? OrderSpecifier { get; set; }


        /// <summary>
        /// The Client Extensions to update for the Order. Do not set, modify, or
        /// delete clientExtensions if your account is associated with MT4.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public ClientExtensions ClientExtensions { get; set; }


        /// <summary>
        /// The Client Extensions to update for the Trade created when the Order is
        /// filled. Do not set, modify, or delete clientExtensions if your account is
        /// associated with MT4.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public ClientExtensions TradeClientExtensions { get; set; }
    }
}
