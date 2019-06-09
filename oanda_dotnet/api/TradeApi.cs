using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public class TradeApi : Restv20Api
    {
        public TradeApi(Restv20Client client) : base(client) { }
    }
}
