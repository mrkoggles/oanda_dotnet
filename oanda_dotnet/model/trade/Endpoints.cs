using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.trade
{
    public abstract class TradeRestv20EndpointRequest : Restv20EndpointRequest { }

    /// <summary>
    /// Get a list of Trades for an Account
    /// </summary>
    public class GetTradesEndpoint : TradeRestv20EndpointRequest
    {
        private uint? _count;


        public override string Endpoint => @"/v3/accounts/{accountID}/trades";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// List of Trade IDs to retrieve. 
        /// </summary>
        [EndpointParameter(Name ="ids", Type = ParameterType.QueryString)]
        public ICollection<TradeId> Ids { get; set; }


        /// <summary>
        /// The state to filter the requested Trades by. [default=OPEN] 
        /// </summary>
        [EndpointParameter(Name ="state", Type = ParameterType.QueryString)]
        public TradeStateFilter? State { get; set; }


        /// <summary>
        /// The instrument to filter the requested Trades by. 
        /// </summary>
        [EndpointParameter(Name ="instrument", Type = ParameterType.QueryString)]
        public InstrumentName? Instrument { get; set; }


        /// <summary>
        /// The maximum number of Trades to return. [default=50, maximum=500] 
        /// </summary>
        [EndpointParameter(Name ="count", Type = ParameterType.QueryString)]
        public uint? Count
        {
            get => _count;
            set => _count = (value == null ? null : (uint?)Math.Min((uint)value, 500));
        }


        /// <summary>
        /// The maximum Trade ID to return. If not provided the most recent Trades in the Account are returned. 
        /// </summary>
        [EndpointParameter(Name ="beforeID", Type = ParameterType.QueryString)]
        public TradeId? BeforeTradeId { get; set; }
    }


    /// <summary>
    /// Get the list of open Trades for an Account
    /// </summary>
    public class GetOpenTradesEndpoint : TradeRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/openTrades";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }
    }


    /// <summary>
    /// Get the details of a specific Trade in an Account
    /// </summary>
    public class GetTradeEndpoint : TradeRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/trades/{tradeSpecifier}";
        public override Method Method => Method.GET;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Specifier for the Trade
        /// </summary>
        [Required]
        [EndpointParameter(Name ="tradeSpecifier", Type = ParameterType.UrlSegment)]
        public TradeSpecifier? TradeSpecifier { get; set; }
    }


    /// <summary>
    /// Close (partially or fully) a specific open Trade in an Account
    /// </summary>
    public class CloseTradeEndpoint : TradeRestv20EndpointRequest
    {
        private bool? _closeAll;
        private decimal? _closeAmount;

        public bool? CloseAll
        {
            get => _closeAll;
            set
            {
                if (!(value ?? false)) { _closeAll = null; }
                else
                {
                    _closeAll = value;
                    _closeAmount = null;
                }
            }
        }

        public decimal? CloseAmount
        {
            get => _closeAmount;
            set
            {
                //if set to something other than null than adjust close all
                _closeAmount = value;
                if (value != null) { _closeAll = null; }
            }
        }


        public override string Endpoint => @"/v3/accounts/{accountID}/trades/{tradeSpecifier}/close";
        public override Method Method => Method.PUT;
        

        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Specifier for the Trade
        /// </summary>
        [Required]
        [EndpointParameter(Name ="tradeSpecifier", Type = ParameterType.UrlSegment)]
        public TradeSpecifier? TradeSpecifier { get; set; }


        /// <summary>
        /// Indication of how much of the Trade to close. Either the string “ALL”
        /// (indicating that all of the Trade should be closed), or a DecimalNumber
        /// representing the number of units of the open Trade to Close using a
        /// TradeClose MarketOrder. The units specified must always be positive, and
        /// the magnitude of the value cannot exceed the magnitude of the Trade’s
        /// open units.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public string Units => (CloseAll == null && CloseAmount == null) ? null :
            CloseAll ?? false ?"ALL" : 
            (CloseAmount ?? 0).ToString(); 
    }


    /// <summary>
    /// Update the Client Extensions for a Trade. Do not add, update, or delete the Client Extensions if your account is associated with MT4.
    /// </summary>
    public class UpdateTradeClientExtensionsEndpoint : TradeRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/trades/{tradeSpecifier}/clientExtensions";
        public override Method Method => Method.PUT;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Specifier for the Trade
        /// </summary>
        [Required]
        [EndpointParameter(Name ="tradeSpecifier", Type = ParameterType.UrlSegment)]
        public TradeSpecifier? TradeSpecifier { get; set; }


        /// <summary>
        /// The Client Extensions to update for the Trade created when the Order is
        /// filled. Do not set, modify, or delete clientExtensions if your account is
        /// associated with MT4.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public ClientExtensions TradeClientExtensions { get; set; }
    }


    /// <summary>
    /// Create, replace and cancel a Trade’s dependent Orders (Take Profit, Stop Loss and Trailing Stop Loss) through the Trade itself
    /// </summary>
    public class SetTradeOrdersEndpoint : TradeRestv20EndpointRequest
    {
        public override string Endpoint => @"/v3/accounts/{accountID}/trades/{tradeSpecifier}/orders";
        public override Method Method => Method.PUT;


        /// <summary>
        /// Account Identifier
        /// </summary>
        [Required]
        [EndpointParameter(Name ="accountID", Type = ParameterType.UrlSegment)]
        public AccountId? AccountId { get; set; }


        /// <summary>
        /// Specifier for the Trade
        /// </summary>
        [Required]
        [EndpointParameter(Name ="tradeSpecifier", Type = ParameterType.UrlSegment)]
        public TradeSpecifier? TradeSpecifier { get; set; }


        /// <summary>
        /// The specification of the Take Profit to create/modify/cancel. If
        /// takeProfit is set to null, the Take Profit Order will be cancelled if it
        /// exists. If takeProfit is not provided, the exisiting Take Profit Order
        /// will not be modified. If a sub-field of takeProfit is not specified, that
        /// field will be set to a default value on create, and be inherited by the
        /// replacing order on modify.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public TakeProfitDetails TakeProfit { get; set; }


        /// <summary>
        /// The specification of the Stop Loss to create/modify/cancel. If stopLoss
        /// is set to null, the Stop Loss Order will be cancelled if it exists. If
        /// stopLoss is not provided, the exisiting Stop Loss Order will not be
        /// modified. If a sub-field of stopLoss is not specified, that field will be
        /// set to a default value on create, and be inherited by the replacing order
        /// on modify.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public StopLossDetails StopLoss { get; set; }


        /// <summary>
        /// The specification of the Trailing Stop Loss to create/modify/cancel. If
        /// trailingStopLoss is set to null, the Trailing Stop Loss Order will be
        /// cancelled if it exists. If trailingStopLoss is not provided, the
        /// exisiting Trailing Stop Loss Order will not be modified. If a sub-field
        /// of trailngStopLoss is not specified, that field will be set to a default
        /// value on create, and be inherited by the replacing order on modify.
        /// </summary>
        [Required]
        [EndpointParameter(Type = ParameterType.RequestBody)]
        public TrailingStopLossDetails TrailingStopLoss { get; set; }
    }
}
