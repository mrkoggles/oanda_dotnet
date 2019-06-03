using oanda_dotnet.client;

namespace oanda_dotnet.api
{
    public class InstrumentApi : Restv20Api
    {
        public InstrumentApi(Restv20Client client) : base(client) { }
    }
}
