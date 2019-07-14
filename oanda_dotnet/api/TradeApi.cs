using oanda_dotnet.client;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.account;
using oanda_dotnet.model;
using System.Collections.Generic;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.api
{
    public class TradeApi : Restv20Api<TradeRestv20EndpointRequest, TradeRestv20EndpointResponse>
    {
        public TradeApi(Restv20Client client) : base(client) { }

        public GetTradesResponse GetTrades(AccountId accountId, ICollection<TradeId> tradeIds, TradeStateFilter filter, InstrumentName instrument, uint count, TradeId beforeTradeId)
                => Execute<GetTradesResponse>(new GetTradesEndpoint()
                {
                    AccountId = accountId,
                    Ids = tradeIds,
                    State = filter,
                    Instrument = instrument,
                    Count = count,
                    BeforeTradeId = beforeTradeId
                });


        public GetTradesResponse GetOpenTrades(AccountId accountId)
            => Execute<GetTradesResponse>(new GetOpenTradesEndpoint() { AccountId = accountId });


        public GetTradeResponse GetTrade(AccountId accountId, TradeSpecifier tradeSpecifier)
            => Execute<GetTradeResponse>(new GetTradeEndpoint()
            {
                AccountId = accountId,
                TradeSpecifier = tradeSpecifier
            });


        public CloseTradeResponse CloseTradeByAmount(AccountId accountId, TradeSpecifier tradeSpecifier, decimal units)
            => Execute<CloseTradeResponse>(new CloseTradeEndpoint()
            {
                AccountId = accountId,
                TradeSpecifier = tradeSpecifier,
                CloseAmount = units
            });


        public CloseTradeResponse CloseTradeAllUnits(AccountId accountId, TradeSpecifier tradeSpecifier)
            => Execute<CloseTradeResponse>(new CloseTradeEndpoint()
            {
                AccountId = accountId,
                TradeSpecifier = tradeSpecifier,
                CloseAll = true
            });


        public UpdateTradeClientExtensionsResponse UpdateTradeClientExtensions(AccountId accountId, TradeSpecifier tradeSpecifier, ClientExtensions newExtensions)
            => Execute<UpdateTradeClientExtensionsResponse>(new UpdateTradeClientExtensionsEndpoint()
            {
                AccountId = accountId,
                TradeSpecifier = tradeSpecifier,
                TradeClientExtensions = newExtensions
            });


        public SetTradeOrdersResponse UpdateTradeOrder(AccountId accountId, TradeSpecifier tradeSpecifier, IExitOrderDetail exitOrderDetail)
        {
            SetTradeOrdersEndpoint endpoint = new SetTradeOrdersEndpoint()
            {
                AccountId = accountId,
                TradeSpecifier = tradeSpecifier
            };

            if (exitOrderDetail is StopLossDetails) { endpoint.StopLoss = (StopLossDetails)exitOrderDetail; }
            else if (exitOrderDetail is TakeProfitDetails) { endpoint.TakeProfit = (TakeProfitDetails)exitOrderDetail; }
            else if (exitOrderDetail is TrailingStopLossDetails) { endpoint.TrailingStopLoss = (TrailingStopLossDetails)exitOrderDetail; }

            return Execute<SetTradeOrdersResponse>(endpoint);
        }
    }
}
