using oanda_dotnet.client;
using oanda_dotnet.model.instrument;

namespace oanda_dotnet.api
{
    public class InstrumentApi : Restv20Api<InstrumentRestv20EndpointRequest, InstrumentRestv20EndpointResponse>
    {
        public InstrumentApi(Restv20Client client) : base(client) { }
    }
}
