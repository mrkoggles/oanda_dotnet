using oanda_dotnet.client;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.api
{
    public class TransactionApi : Restv20Api<TransactionRestv20EndpointRequest, TransactionRestv20EndpointResponse>
    {
        public TransactionApi(Restv20Client client) : base(client) { }
    }
}
