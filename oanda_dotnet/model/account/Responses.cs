using oanda_dotnet.model.transaction;
using System.Collections.Generic;

namespace oanda_dotnet.model.account
{
    public abstract class AccountRestv20EndpointResponse : Restv20EndpointResponse { }

    public sealed class GetAccountsResponse : AccountRestv20EndpointResponse
    {
        public ICollection<AccountProperties> Accounts { get; set; }
    }

    public sealed class GetAccountDetailResponse : AccountRestv20EndpointResponse
    {
        public Account Account { get; set; }
    }

    public sealed class GetAccountSummaryResponse : AccountRestv20EndpointResponse
    {
        public AccountSummary Account { get; set; }
    }

    public sealed class GetAccountInstrumentsResponse : AccountRestv20EndpointResponse
    {
        public ICollection<InstrumentName> Instruments { get; set; }
    }

    public sealed class ConfigureAccountResponse : AccountRestv20EndpointResponse
    {
        public ClientConfigureTransaction ClientConfigureTransaction { get; set; }
    }

    public sealed class GetAccountChangesResponse : AccountRestv20EndpointResponse
    {
        public AccountChanges Changes { get; set; }
    }
}
