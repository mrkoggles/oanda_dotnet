using oanda_dotnet.client;
using oanda_dotnet.model;
using oanda_dotnet.model.account;
using oanda_dotnet.model.order;
using oanda_dotnet.model.transaction;
using System.Collections.Generic;

namespace oanda_dotnet.api
{
    public class OrderApi : Restv20Api<OrderRestv20EndpointRequest, OrderRestv20EndpointResponse>
    {
        public OrderApi(Restv20Client client) : base(client) { }

        public CreateOrderResponse CreateOrder(AccountId accountId, OrderRequest orderRequest)
            => Execute<CreateOrderResponse>(new CreateOrderEndpoint()
            {
                AccountId = accountId,
                Order = orderRequest
            });

        public GetOrdersResponse GetOrders(AccountId accountId,
            ICollection<OrderId> orderIds = null, OrderStateFilter? orderState = null, InstrumentName? instrument = null, uint? count = null, OrderId? beforeOrderId = null)
                => Execute<GetOrdersResponse>(new GetOrdersEndpoint()
                {
                    AccountId = accountId,
                    Ids = orderIds,
                    State = orderState,
                    Instrument = instrument,
                    Count = count,
                    BeforeOrderId = beforeOrderId
                });

        public GetOrdersResponse GetPendingOrders(AccountId accountId)
            => Execute<GetOrdersResponse>(new GetPendingOrdersEndpoint() { AccountId = accountId });

        public GetOrderDetailsResponse GetOrderDetails(AccountId accountId, OrderSpecifier orderSpecifier)
            => Execute<GetOrderDetailsResponse>(new GetOrderEndpoint()
            {
                AccountId = accountId,
                OrderSpecifier = orderSpecifier
            });

        public ReplaceOrderResponse ReplaceOrder(AccountId accountId, OrderSpecifier orderSpecifier, OrderRequest newOrder)
            => Execute<ReplaceOrderResponse>(new ReplaceOrderEndpoint()
            {
                AccountId = accountId,
                OrderSpecifier = orderSpecifier,
                Order = newOrder
            });

        public CancelPendingOrderResponse CancelOrder(AccountId accountId, OrderSpecifier orderSpecifier)
            => Execute<CancelPendingOrderResponse>(new CancelPendingOrderEndpoint()
            {
                AccountId = accountId,
                OrderSpecifier = orderSpecifier
            });

        public UpdateOrderClientExtensionsResponse UpdateOrderClientExtensions(AccountId accountId, OrderSpecifier orderSpecifier,
            ClientExtensions clientExtensions = null, ClientExtensions tradeClientExtensions = null)
                => Execute<UpdateOrderClientExtensionsResponse>(new UpdateOrderClientExtensionsEndpoint()
                {
                    AccountId = accountId,
                    OrderSpecifier = orderSpecifier,
                    ClientExtensions = clientExtensions,
                    TradeClientExtensions = tradeClientExtensions
                });
    }
}
