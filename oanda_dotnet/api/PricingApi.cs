using oanda_dotnet.client;
using oanda_dotnet.model.pricing;

namespace oanda_dotnet.api
{
    public sealed class PricingApi : Restv20Api<PricingRestv20EndpointRequest, PricingRestv20EndpointResponse>
    {
        public PricingApi(Restv20Client client) : base(client) { }
    }
}
