using oanda_dotnet.client;
using oanda_dotnet.model;
using RestSharp;
using System;
using System.Collections.Generic;

namespace oanda_dotnet.api
{
    public abstract class Restv20Api<T, U>
        where T : Restv20EndpointRequest
        where U : Restv20EndpointResponse
    {
        public Restv20Client Client { get; private set; }

        public Restv20Api(Restv20Client client)
        {
            Client = client;
        }

        [Obsolete("Unfinished method. Needs error handling")]
        protected V Execute<V>(T request)
            where V : U, new() 
        {
            if (!request.IsValid()) { /*throw custom exception*/ }
            IRestRequest restRequest = request.GenerateRestRequest();
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse<V> restResponse = this.Client.Execute<V>(restRequest);

            if (restResponse.ErrorException != null) { /*error handling*/ }
            return restResponse.Data;
        }

        [Obsolete("Belongs somewhere else")]
        protected static ICollection<T> GenerateCollection<T>(T t)
            where T : new()
        {
            return new List<T>() { t };
        }
    }
}
