using RestSharp;

namespace oanda_dotnet.model
{
    public abstract class Restv20Request
    {
        public abstract string Endpoint { get; }
        public abstract Method Method { get; }

        public bool IsValid()
        {
            return true;
        }

        public IRestRequest GenerateRestRequest()
        {
            return new RestRequest();
        }
    }
}
