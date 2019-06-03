using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public sealed class PricingApi : Restv20Api
    {
        public PricingApi(Restv20Client client) : base(client) { }
    }
}
