using oanda_dotnet.client;
using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.api
{
    public class TransactionApi : Restv20Api<TransactionRestv20EndpointRequest, TransactionRestv20EndpointResponse>
    {
        public TransactionApi(Restv20Client client) : base(client) { }
        


        public GetTransactionResponse GetTransaction(AccountId accountId, TransactionId transactionId)
            => Execute<GetTransactionResponse>(new GetTransactionEndpoint()
            {
                AccountId = accountId,
                TransactionId = transactionId
            });


        public GetTransactionsResponse GetTransactions(AccountId accountId, TransactionId fromId, TransactionId toId, TransactionFilter? filter = null)
            => Execute<GetTransactionsResponse>(new GetTransactionsByIdsEndpoint()
            {
                AccountId = accountId,
                From = fromId,
                To = toId,
                Type = filter
            });


        public GetTransactionsResponse GetTransactions(AccountId accountId, TransactionId sinceId)
            => Execute<GetTransactionsResponse>(new GetTransactionsByIdsEndpoint()
            {
                AccountId = accountId,
                From = sinceId
            });
    }
}
