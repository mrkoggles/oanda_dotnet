using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model;
using oanda_dotnet.model.pricing;
using System.Collections.Generic;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class PricingRequests : BaseTestClass
    {
        [TestMethod]
        public void GetPrices()
        {
            GetPricingEndpoint request = new GetPricingEndpoint
            {
                AcceptDateTimeFormat = AcceptDateTimeFormat.RFC3339,
                AccountId = this.AccountId,
                Instruments = new List<InstrumentName>()
                {
                    new InstrumentName
                    {
                        BaseCurrency = Currency.EUR,
                        QuoteCurrency = Currency.USD
                    },
                    new InstrumentName
                    {
                        BaseCurrency = Currency.USD,
                        QuoteCurrency = Currency.CAD
                    }
                },
                IncludeHomeConversions = true,
                Since = System.DateTime.Now.AddDays(-7)
            };

            PricingApi api = new PricingApi(this.Client);
            GetPricingResponse response = api.Execute<GetPricingResponse>(request);
            Assert.AreEqual(response?.Prices?.Count, 2);
        }
    }
}
