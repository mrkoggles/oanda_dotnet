using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;

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
