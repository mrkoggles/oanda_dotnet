using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public class TransactionApi : Restv20Api
    {
        public TransactionApi(Restv20Client client) : base(client) { }
    }
}
