using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public class AccountApi : Restv20Api
    {
        public AccountApi(Restv20Client client) : base(client) { }
    }
}
