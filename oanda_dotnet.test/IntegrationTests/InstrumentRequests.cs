using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model;
using oanda_dotnet.model.instrument;
using System;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class InstrumentRequests : BaseTestClass
    {
        private InstrumentApi _api;

        public InstrumentRequests()
        {
            _api = new InstrumentApi(this.Client);
        }

        [TestMethod]
        public void GetInstrumentCandlesRequest()
        {
            GetInstrumentCandlesResponse response = this._api.GetCandles("EUR_USD");
            Assert.IsTrue(response?.Candles != null && response.Candles.Count > 0);
        }


        [TestMethod]
        public void GetInstrumentOrderBookRequest()
        {
            GetInstrumentOrderBookResponse response = _api.GetOrderBook("USD_JPY");
            Assert.IsTrue(response.OrderBook.Buckets.Count > 0);
        }


        [TestMethod]
        public void GetInstrumentOrderBookSnapshotRequest()
        {
            GetInstrumentOrderBookResponse response = _api.GetOrderBook("USD_JPY", DateTime.Now.AddYears(-1));
            Assert.IsTrue(response.OrderBook.Buckets.Count > 0);  //need to fix date time serialization into the request
        }


        [TestMethod]
        public void GetInstrumentPositionBookRequest()
        {
            GetInstrumentPositionBookResponse response = _api.GetPositionBook("USD_JPY");
            Assert.IsTrue(response.PositionBook.Buckets.Count > 0);
        }


        [TestMethod]
        public void GetInstrumentPositionBookSnapshotRequest()
        {
            GetInstrumentPositionBookResponse response = _api.GetPositionBook("USD_JPY", DateTime.Now.AddYears(-1));
            Assert.IsTrue(response.PositionBook.Buckets.Count > 0);  //need to fix date time serialization into the request
        }
    }
}
