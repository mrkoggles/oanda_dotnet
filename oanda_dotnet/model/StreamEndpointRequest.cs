using RestSharp;

namespace oanda_dotnet.model
{
    public abstract class StreamEndpointRequest<T>
    {
        public abstract string Endpoint { get; }
        public abstract Method Method { get; }
    }
}
