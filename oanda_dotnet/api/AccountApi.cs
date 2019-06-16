using oanda_dotnet.client;
using oanda_dotnet.model.account;
using System.Collections.Generic;
using oanda_dotnet.model;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.api
{
    public class AccountApi : Restv20Api<AccountRestv20EndpointRequest, AccountRestv20EndpointResponse>
    {
        public AccountApi(Restv20Client client) : base(client) { }

        public GetAccountsResponse GetAccounts() 
            => Execute<GetAccountsResponse>(new GetAccountsEndpoint());

        public GetAccountResponse GetAccount(AccountId accountId) 
            => Execute<GetAccountResponse>(new GetAccountEndpoint() { AccountId = accountId });

        public GetAccountSummaryResponse GetAccountSummary(AccountId accountId) 
            => Execute<GetAccountSummaryResponse>(new GetAccountSummaryEndpoint() { AccountId = accountId });

        public GetAccountInstrumentsResponse GetAccountInstruments(AccountId accountId, ICollection<InstrumentName> instruments = null)
            => Execute<GetAccountInstrumentsResponse>(
                    new GetAccountInstrumentsEndpoint()
                    {
                        AccountId = accountId,
                        Instruments = instruments
                    });

        public ConfigureAccountResponse ConfigureAccount(AccountId accountId, string newAlias, decimal newMarginRate)
            => Execute<ConfigureAccountResponse>(new ConfigureAccountEndpoint()
            {
                AccountId = accountId,
                Alias = newAlias,
                MarginRate = newMarginRate
            });
        
        public GetAccountChangesResponse GetAccountChanges(AccountId accountId, TransactionId sinceTransactionId)
            => Execute<GetAccountChangesResponse>(new GetAccountChangesEndpoint()
            {
                AccountId = accountId,
                SinceTransactionId = sinceTransactionId
            });
    }
}
