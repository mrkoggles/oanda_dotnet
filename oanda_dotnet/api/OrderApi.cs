using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public class OrderApi : Restv20Api
    {
        public OrderApi(Restv20Client client) : base(client) { }
    }
}
