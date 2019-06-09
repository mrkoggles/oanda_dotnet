using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using oanda_dotnet.api;
using oanda_dotnet.model;
using oanda_dotnet.model.instrument;

namespace oanda_dotnet.test.IntegrationTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
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
            GetInstrumentCandlesEndpoint request = new GetInstrumentCandlesEndpoint()
            {
                Instrument = new InstrumentName()
                {
                    BaseCurrency = Currency.USD,
                    QuoteCurrency = Currency.JPY
                },
                IncludeAskCandles = true,
                IncludeBidCandles = true,
                IncludeMidpointCandles = true,
                CandlestickGranularity = CandlestickGranularity.M10
            };

            GetInstrumentCandlesResponse response = this._api.Execute<GetInstrumentCandlesResponse>(request);
            Assert.IsTrue(response?.Candles != null && response.Candles.Count > 0);
        }


        [TestMethod]
        public void GetInstrumentOrderBookRequest()
        {
            GetInstrumentOrderBookEndpoint request = new GetInstrumentOrderBookEndpoint()
            {
                Instrument = new InstrumentName()
                {
                    BaseCurrency = Currency.USD,
                    QuoteCurrency = Currency.JPY
                }
            };

            GetInstrumentOrderBookResponse response = this._api.Execute<GetInstrumentOrderBookResponse>(request);
            Assert.IsTrue(response?.OrderBook?.Buckets != null);
        }


        [TestMethod]
        public void GetInstrumentPositionBookRequest()
        {
            GetInstrumentPositionBookEndpoint request = new GetInstrumentPositionBookEndpoint()
            {
                Instrument = new InstrumentName()
                {
                    BaseCurrency = Currency.USD,
                    QuoteCurrency = Currency.JPY
                }
            };

            GetInstrumentPositionBookResponse response = this._api.Execute<GetInstrumentPositionBookResponse>(request);
            Assert.IsTrue(response?.PositionBook?.Buckets != null);
        }
    }
}
