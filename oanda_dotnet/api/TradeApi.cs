using oanda_dotnet.client;
using oanda_dotnet.model.trade;

namespace oanda_dotnet.api
{
    public class TradeApi : Restv20Api<TradeRestv20EndpointRequest, TradeRestv20EndpointResponse>
    {
        public TradeApi(Restv20Client client) : base(client) { }
    }
}
