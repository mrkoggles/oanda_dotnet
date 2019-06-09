using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.model.account
{
    public sealed class GetAccountsResponse : Restv20Response
    {
        public ICollection<AccountProperties> Accounts { get; set; }
    }

    public sealed class GetAccountDetailResponse : Restv20Response
    {
        public Account Account { get; set; }
    }

    public sealed class GetAccountSummaryResponse : Restv20Response
    {
        public AccountSummary Account { get; set; }
    }

    public sealed class GetAccountInstrumentsResponse : Restv20Response
    {
        public ICollection<InstrumentName> Instruments { get; set; }
    }

    public sealed class ConfigureAccountResponse : Restv20Response
    {
        public ClientConfigureTransaction ClientConfigureTransaction { get; set; }
    }

    public sealed class GetAccountChangesResponse : Restv20Response
    {
        public AccountChanges Changes { get; set; }
    }
}
