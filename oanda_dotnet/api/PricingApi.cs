using oanda_dotnet.client;
using oanda_dotnet.model.pricing;

namespace oanda_dotnet.api
{
    public sealed class PricingApi : Restv20Api
    {
        public PricingApi(Restv20Client client) : base(client) { }

        //public T Execute<T>(PricingRequest request)
        //    where T : PricingResponse, new() => this.Execute<T>(request);
    }
}
