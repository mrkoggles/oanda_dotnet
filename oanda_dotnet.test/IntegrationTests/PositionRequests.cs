using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model;
using oanda_dotnet.model.position;
using System;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class PositionRequests : BaseTestClass
    {
        private PositionApi _api;

        public PositionRequests() { _api = new PositionApi(this.Client); }

        [TestMethod]
        public void GetPositions()
        {
            GetPositionsResponse response = _api.GetPositions(this.AccountId);;
            Assert.IsTrue(response.LastTransactionId > 0);
        }


        [TestMethod]
        public void GetOpenPositions()
        {
            GetPositionsResponse response = _api.GetOpenPositions(this.AccountId);
            Assert.IsTrue(response.LastTransactionId > 0);
        }


        [TestMethod]
        public void GetInstrumentsPositions()
        {
            GetPositionResponse response = _api.GetInstrumentPosition(this.AccountId, "EUR_USD");
            Assert.IsTrue(response.LastTransactionId > 0);
        }



        [TestMethod]
        [Obsolete("Need ability to create positions first")]
        public void CloseOutPosition()
        {
           
        }
    }
}
