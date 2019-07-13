using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model.order;
using System.Linq;

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
            var response = _api.CreateOrder(this.AccountId, new LimitOrderRequest()
            {
                Units = 100,
                Price = 1.13668M,
                Instrument = "EUR_USD",
                TimeInForce = TimeInForce.FOK,
                PositionFill = OrderPositionFill.Default
            });
            Assert.IsTrue(response.OrderCreateTransaction != null);
        }

        [TestMethod]
        public void GetOrders()
        {
            var response = _api.GetOrders(this.AccountId, orderState: OrderStateFilter.Cancelled);
            Assert.IsTrue(response.Orders != null && response.Orders.Count > 0);
        }

        [TestMethod]
        public void GetPendingOrders()
        {
            var response = _api.GetPendingOrders(this.AccountId);
            Assert.IsTrue(response.Orders != null);
        }

        [TestMethod]
        public void GetOrderDetails()
        {
            var getOrders = _api.GetOrders(this.AccountId, orderState: OrderStateFilter.All);
            OrderId orderId = getOrders.Orders.First().Id;
            var response = _api.GetOrderDetails(this.AccountId, orderId.ToString());
            Assert.IsTrue(response.Order.Id.Equals(orderId));
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
