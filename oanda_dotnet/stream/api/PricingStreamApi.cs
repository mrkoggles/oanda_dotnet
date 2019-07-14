using oanda_dotnet.model;
using oanda_dotnet.model.account;
using oanda_dotnet.model.pricing;
using oanda_dotnet.stream.client;
using oanda_dotnet.stream.model.pricing;
using System.Collections.Generic;

namespace oanda_dotnet.stream.api
{
    public class PricingStreamApi : StreamApi<Price>
    {
        private static PricingStreamEndpointRequest request;
        
        public PricingStreamApi(StreamClient client, AccountId accountId, ICollection<InstrumentName> instruments, bool? snapshot = null) : base(client, request)
        {
            request = new PricingStreamEndpointRequest()
            {
                AccountId = accountId,
                Instruments = instruments,
                Snapshot = snapshot
            };
        }
    }
}