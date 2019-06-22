using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model.order;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class OrderRequests : BaseTestClass
    {
        private OrderApi _api;

        public OrderRequests() { _api = new OrderApi(this.Client); }


        [TestMethod]
        public void CreateOrder()
        {
            var response = _api.CreateOrder(this.AccountId, new MarketOrderRequest()
            {
                Units = 100,
                Instrument = "EUR_USD",
                TimeInForce = TimeInForce.FOK,
                PositionFill = OrderPositionFill.Default
            });
            Assert.IsTrue(response.OrderCreateTransaction != null);
        }

        [TestMethod]
        public void GetOrders()
        {

        }

        [TestMethod]
        public void GetPendingOrders()
        {

        }

        [TestMethod]
        public void GetOrderDetails()
        {

        }

        [TestMethod]
        public void ReplaceOrder()
        {

        }

        [TestMethod]
        public void CancelPendingOrder()
        {

        }

        [TestMethod]
        public void UpdateClientExtensionsForOrder()
        {

        }
    }
}
