using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;
using oanda_dotnet.stream.model.transaction;
using oanda_dotnet.stream.client;

namespace oanda_dotnet.stream.api
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
