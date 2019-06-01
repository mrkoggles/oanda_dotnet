using RestSharp;
using RestSharp.Authenticators;

namespace oanda_dotnet.client
{
    public class Restv20Client : RestClient
    {
        public Restv20Client(string bearerToken)
        {
            this.Authenticator = new JwtAuthenticator(bearerToken);
        }
    }
}
