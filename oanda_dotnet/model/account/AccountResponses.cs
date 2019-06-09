using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.model.account
{
    public sealed class GetAccountsResponse : Restv20EndpointResponse
    {
        public ICollection<AccountProperties> Accounts { get; set; }
    }

    public sealed class GetAccountDetailResponse : Restv20EndpointResponse
    {
        public Account Account { get; set; }
    }

    public sealed class GetAccountSummaryResponse : Restv20EndpointResponse
    {
        public AccountSummary Account { get; set; }
    }

    public sealed class GetAccountInstrumentsResponse : Restv20EndpointResponse
    {
        public ICollection<InstrumentName> Instruments { get; set; }
    }

    public sealed class ConfigureAccountResponse : Restv20EndpointResponse
    {
        public ClientConfigureTransaction ClientConfigureTransaction { get; set; }
    }

    public sealed class GetAccountChangesResponse : Restv20EndpointResponse
    {
        public AccountChanges Changes { get; set; }
    }
}
