using oanda_dotnet.client;
using oanda_dotnet.model;
using RestSharp;

namespace oanda_dotnet.api
{
    public abstract class Restv20Api
    {
        public Restv20Client Client { get; private set; }

        public Restv20Api(Restv20Client client)
        {
            Client = client;
        }

        public T Execute<T>(Restv20Request request)
            where T : Restv20Response, new()
        {
            IRestRequest restRequest = request.GenerateRestRequest();
            IRestResponse<T> restResponse = this.Client.Execute<T>(restRequest);
            
            if (restResponse.ErrorException != null)
            {
                //error handling
            }

            return restResponse.Data;
        }
    }
}
