using oanda_dotnet.client;
using oanda_dotnet.model.account;

namespace oanda_dotnet.api
{
    public class AccountApi : Restv20Api<AccountRestv20EndpointRequest, AccountRestv20EndpointResponse>
    {
        public AccountApi(Restv20Client client) : base(client) { }
    }
}
