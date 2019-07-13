using oanda_dotnet.model.account;
using RestSharp;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.pricing
{
    /// <summary>
    /// Get a stream of Account Prices starting from when the request is made.
    /// This pricing stream does not include every single price created for the Account, but instead will provide at most 4 prices per second(every 250 milliseconds) for each instrument being requested.
    /// If more than one price is created for an instrument during the 250 millisecond window, only the price in effect at the end of the window is sent.
    /// This means that during periods of rapid price movement, subscribers to this stream will not be sent every price.
    /// Pricing windows for different connections to the price stream are not all aligned in the same way (i.e.they are not all aligned to the top of the second).
    /// This means that during periods of rapid price movement, different subscribers may observe different prices depending on their alignment.
    /// </summary>
    public class PricingStreamEndpointRequest : StreamEndpointRequest<Price>
    {
        public override string Endpoint => "/v3/accounts/{accountID}/pricing/stream";
        public override Method Method => Method.GET;


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
        [EndpointParameter(Name = "snapshot", Type = ParameterType.QueryString)]
        public bool? Snapshot { get; set; }
    }
}
