using oanda_dotnet.client;
using oanda_dotnet.model.account;
using oanda_dotnet.model.transaction;
using System;

namespace oanda_dotnet.api
{
    public class TransactionApi : Restv20Api<TransactionRestv20EndpointRequest, TransactionRestv20EndpointResponse>
    {
        public TransactionApi(Restv20Client client) : base(client) { }

        [Obsolete("Needs overloads")]
        public GetTransactionPagesResponse GetTransactionPages(AccountId accountId,
            DateTime? from = null, DateTime? to= null, uint? pageSize = null, TransactionFilter? typeFilter = null)
            => Execute<GetTransactionPagesResponse>(new GetTransactionPagesEndpoint()
            {
                AccountId = accountId,
                From = from,
                To = to,
                PageSize = pageSize,
                Type = typeFilter
            });


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
            => Execute<GetTransactionsResponse>(new GetTransactionsSinceIdEndpoint()
            {
                AccountId = accountId,
                SinceId = sinceId
            });
    }
}
