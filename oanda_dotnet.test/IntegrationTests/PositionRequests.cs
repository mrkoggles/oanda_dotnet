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
            GetPositionsRequest request = new GetPositionsRequest()
            {
                AccountId = this.AccountId
            };

            GetPositionsResponse response = _api.Execute<GetPositionsResponse>(request);
            Assert.IsTrue(response.LastTransactionId > 0);
        }


        [TestMethod]
        public void GetOpenPositions()
        {
            GetOpenPositionsRequest request = new GetOpenPositionsRequest()
            {
                AccountId = this.AccountId
            };

            GetPositionsResponse response = _api.Execute<GetPositionsResponse>(request);
            Assert.IsTrue(response.LastTransactionId > 0);
        }


        [TestMethod]
        public void GetInstrumentsPositions()
        {
            GetInstrumentPositionRequest request = new GetInstrumentPositionRequest()
            {
                AccountId = this.AccountId,
                Instrument = new InstrumentName
                {
                    BaseCurrency = Currency.EUR,
                    QuoteCurrency = Currency.USD
                }
            };

            GetPositionResponse response = _api.Execute<GetPositionResponse>(request);
            Assert.IsTrue(response.LastTransactionId > 0);
        }



        [TestMethod]
        [Obsolete("Need ability to create positions first")]
        public void CloseOutPosition()
        {
           
        }
    }
}
