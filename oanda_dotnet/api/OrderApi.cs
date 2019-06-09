using oanda_dotnet.client;
using oanda_dotnet.model.order;

namespace oanda_dotnet.api
{
    public class OrderApi : Restv20Api<OrderRestv20EndpointRequest, OrderRestv20EndpointResponse>
    {
        public OrderApi(Restv20Client client) : base(client) { }
    }
}
