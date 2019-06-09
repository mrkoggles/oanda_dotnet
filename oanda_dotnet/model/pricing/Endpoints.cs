using oanda_dotnet.model.account;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.pricing
{
    public abstract class PricingRestv20EndpointRequest : Restv20EndpointRequest { }

    /// <summary>
    /// Get pricing information for a specified list of Instruments within an Account.
    /// </summary>
    public sealed class GetPricingEndpoint : PricingRestv20EndpointRequest
    {
        public override string Endpoint => "/v3/accounts/{accountID}/pricing";
        public override Method Method => Method.GET;


        /// <summary>
        ///  Format of DateTime fields in the request and response. 
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
        /// List of Instruments to get pricing for.
        /// </summary>
        [Required]
        [EndpointParameter(Name = "instruments", Type = ParameterType.QueryString)]
        public ICollection<InstrumentName> Instruments { get; set; }

        /// <summary>
        /// Date/Time filter to apply to the response. Only prices and home conversions 
        /// (if requested) with a time later than this filter (i.e. the price has changed after the since time) 
        /// will be provided, and are filtered independently. 
        /// </summary>
        [EndpointParameter(Name = "since", Type = ParameterType.QueryString)]
        public System.DateTime? Since { get; set; }


        /// <summary>
        /// Flag that enables the inclusion of the unitsAvailable field in the returned Price objects.
        /// <para> [default=True] </para>
        /// </summary>
        [Obsolete("Deprecated: Will be removed in a future API update.", false)]
        [EndpointParameter(Name = "includeUnitsAvailable", Type = ParameterType.QueryString)]
        public bool? IncludeUnitsAvailable { get; set; }


        /// <summary>
        /// Flag that enables the inclusion of the homeConversions field in the returned response. 
        /// An entry will be returned for each currency in the set of all base and quote currencies present in the requested instruments list. 
        /// <para> [default=False] </para> 
        /// </summary>
        [EndpointParameter(Name = "includeHomeConversions", Type = ParameterType.QueryString)]
        public bool? IncludeHomeConversions { get; set; }
    }
}
