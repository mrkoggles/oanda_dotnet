using System;
using RestSharp;
using RestSharp.Authenticators;

namespace oanda_dotnet.client
{
    public class Restv20Client : RestClient
    {
        public string Url => $"https://{SubDomain}.oanda.com/";
        protected virtual string SubDomain => "api-fxtrade";

        public Restv20Client(string bearerToken)
        {
            this.BaseUrl = new Uri(Url);
            this.Authenticator = new JwtAuthenticator(bearerToken);
        }
    }

    public sealed class Restv20TestingClient : Restv20Client
    {
        protected override string SubDomain => "api-fxpractice";
        public Restv20TestingClient(string bearerToken) : base(bearerToken) { }
    }
}
