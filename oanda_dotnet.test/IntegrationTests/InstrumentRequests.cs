using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using oanda_dotnet.api;
using oanda_dotnet.model;

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

        }


        [TestMethod]
        public void GetInstrumentOrderBookRequest()
        {

        }


        [TestMethod]
        public void GetInstrumentPositionBookRequest()
        {
            GetInstrumentPositionBookRequest request = new GetInstrumentPositionBookRequest()
            {
                Instrument = new InstrumentName()
                {
                    BaseCurrency = Currency.USD,
                    QuoteCurrency = Currency.JPY
                }
            };
        }
    }
}
