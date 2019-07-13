using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace oanda_dotnet.client
{
    public class StreamClient : HttpClient
    {
        public string Url => $"https://{SubDomain}.oanda.com/";
        protected virtual string SubDomain => "stream-fxtrade";

        public StreamClient(string bearerToken) : base()
        {
            this.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerToken}");
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
            this.BaseAddress = new Uri(Url);
        }
    }

    public sealed class StreamTestingClient : StreamClient
    {
        protected override string SubDomain => "stream-fxpractice";

        public StreamTestingClient(string bearerToken) : base(bearerToken) { }
    }
}
