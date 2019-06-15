using oanda_dotnet.client;
using oanda_dotnet.model;
using oanda_dotnet.model.account;
using oanda_dotnet.model.pricing;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.api
{
    public sealed class PricingApi : Restv20Api<PricingRestv20EndpointRequest, PricingRestv20EndpointResponse>
    {
        public PricingApi(Restv20Client client) : base(client) { }

        public GetPricingResponse GetPricing(AccountId accountId, ICollection<InstrumentName> instruments, DateTime? since = null, bool? includeHomeConversions = null, bool? includeUnitsAvailable = null)
        {
            return Execute<GetPricingResponse>(new GetPricingEndpoint()
            {
                AccountId = accountId,
                Instruments = instruments,
                Since = since,
                IncludeHomeConversions = includeHomeConversions,
                IncludeUnitsAvailable = includeUnitsAvailable
            });
        }

        public GetPricingResponse GetPricing(AccountId accountId, ICollection<InstrumentName> instruments, bool? includeHomeConversions = null, DateTime? since = null, bool? includeUnitsAvailable = null)
            => GetPricing(accountId, instruments, since, includeHomeConversions, includeUnitsAvailable);
    }
}
