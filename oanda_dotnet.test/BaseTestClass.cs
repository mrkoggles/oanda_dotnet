using Microsoft.Extensions.Configuration;
using oanda_dotnet.client;

namespace oanda_dotnet.test
{
    public abstract class BaseTestClass
    {
        private IConfiguration Configuration { get; set; }
        public string ApiKey => Configuration["Oanda:ApiKey"];
        public string AccountId => Configuration["Oanda:AccountId"];

        public Restv20TestingClient Client { get; private set; }


        public BaseTestClass()
        {
            Configuration = new ConfigurationBuilder()
                .AddUserSecrets<BaseTestClass>()
                .Build();

            Client = new Restv20TestingClient(ApiKey);
        }
    }
}
