using oanda_dotnet.model;
using RestSharp;

namespace oanda_dotnet.stream.model
{
    public abstract class StreamEndpointRequest<T> : EndpointRequest
    {
        public override Method Method => Method.GET;
    }
}
