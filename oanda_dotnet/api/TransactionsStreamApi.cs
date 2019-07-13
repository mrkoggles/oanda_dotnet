using oanda_dotnet.client;
using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.api
{
    public class TransactionsStreamApi : StreamApi<Transaction>
    {
        private static TransactionStreamEndpointRequest request;

        public TransactionsStreamApi(StreamClient client, AccountId accountId) : base(client, request)
        {
            request = new TransactionStreamEndpointRequest()
            {
                AccountId = accountId
            };
        }
    }
}
