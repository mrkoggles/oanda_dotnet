using oanda_dotnet.client;
using oanda_dotnet.model.trade;
using oanda_dotnet.model.account;
using oanda_dotnet.model;
using System.Collections.Generic;

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

    }
}
