using Microsoft.Extensions.Configuration;

namespace oanda_dotnet.test
{
    public abstract class BaseTestClass
    {
        private IConfiguration Configuration { get; set; }
        public string ApiKey => Configuration["Oanda:ApiKey"];

        public BaseTestClass()
        {
            Configuration = new ConfigurationBuilder()
                .AddUserSecrets<BaseTestClass>()
                .Build();
        }
    }
}
