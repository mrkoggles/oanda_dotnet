using oanda_dotnet.client;
using oanda_dotnet.model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.api
{
    public abstract class Restv20Api
    {
        public Restv20Client Client { get; private set; }

        public Restv20Api(Restv20Client client)
        {
            Client = client;
        }

        [Obsolete("Unfinished method. Needs error handling")]
        public T Execute<T>(Restv20Request request)
            where T : Restv20Response, new()
        {
            if (!request.IsValid()) { /*throw custom exception*/ }
            IRestRequest restRequest = request.GenerateRestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse<T> restResponse = this.Client.Execute<T>(restRequest);

            if (restResponse.ErrorException != null) { /*error handling*/ }
            return restResponse.Data;
        }


        protected static ICollection<T> GenerateCollection<T>(T t)
            where T : new()
        {
            return new List<T>() { t };
        }
    }
}
