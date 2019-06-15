using oanda_dotnet.client;
using oanda_dotnet.model;
using oanda_dotnet.model.account;
using oanda_dotnet.model.position;

namespace oanda_dotnet.api
{
    public class PositionApi : Restv20Api<PositionRestv20EndpointRequest, PositionRestv20EndpointResponse>
    {
        public PositionApi(Restv20Client client) : base(client) { }

        public GetPositionsResponse GetPositions(AccountId accountId)
            => Execute<GetPositionsResponse>(new GetPositionsEndpoint() { AccountId = accountId });

        public GetPositionsResponse GetOpenPositions(AccountId accountId)
            => Execute<GetPositionsResponse>(new GetOpenPositionsEndpoint() { AccountId = accountId });

        public GetPositionResponse GetInstrumentPosition(AccountId accountId, InstrumentName instrument)
            => Execute<GetPositionResponse>(new GetInstrumentPositionEndpoint()
            {
                AccountId = accountId,
                Instrument = instrument
            });
    }
}
