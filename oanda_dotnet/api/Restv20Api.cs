using oanda_dotnet.client;
using oanda_dotnet.model;
using RestSharp;
using oanda_dotnet.model.pricing;

namespace oanda_dotnet.api
{
    public abstract class Restv20Api
    {
        public Restv20Client Client { get; private set; }

        public Restv20Api(Restv20Client client)
        {
            Client = client;
        }

        protected T Execute<T>(Restv20Request request)
            where T : Restv20Response, new()
        {
            if (!request.IsValid()) { /*throw custom exception*/ }
            IRestRequest restRequest = request.GenerateRestRequest();
            IRestResponse<T> restResponse = this.Client.Execute<T>(restRequest);
            
            if (restResponse.ErrorException != null) { /*error handling*/ }
            return restResponse.Data;
        }
    }



    public sealed class PricingApi : Restv20Api
    {
        public PricingApi(Restv20Client client) : base(client) { }

        public T Execute<T>(PricingRequest request)
            where T : PricingResponse, new() => this.Execute<T>(request);
    }
}
