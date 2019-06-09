using oanda_dotnet.client;
using oanda_dotnet.model.position;

namespace oanda_dotnet.api
{
    public class PositionApi : Restv20Api<PositionRestv20EndpointRequest, PositionRestv20EndpointResponse>
    {
        public PositionApi(Restv20Client client) : base(client) { }
    }
}
