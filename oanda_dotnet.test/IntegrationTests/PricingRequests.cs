using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model;
using oanda_dotnet.model.pricing;
using System.Collections.Generic;
using System;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class PricingRequests : BaseTestClass
    {
        [TestMethod]
        public void GetPrices()
        {
            PricingApi api = new PricingApi(this.Client);
            GetPricingResponse response = api.GetPricing(this.AccountId, new List<InstrumentName>() { "EUR_USD", "USD_CAD" }, DateTime.Now.AddMonths(-1), true);
            Assert.AreEqual(response?.Prices?.Count, 2);
        }
    }
}
