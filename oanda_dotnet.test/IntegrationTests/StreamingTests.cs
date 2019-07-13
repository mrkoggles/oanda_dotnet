using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.IO;

namespace oanda_dotnet.test.IntegrationTests
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class StreamingTests : BaseTestClass
    {
        [TestMethod]
        public void StreamClientExecution()
        {
            using (oanda_dotnet.client.StreamTestingClient client = new oanda_dotnet.client.StreamTestingClient(this.ApiKey))
            {
                try
                {
                    using (System.IO.Stream stream = client.GetStreamAsync($"/v3/accounts/{this.AccountId}/transactions/stream").Result)
                    using (System.IO.StreamReader reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true))
                    {
                        while (!reader.EndOfStream)
                        {
                            var x = reader.ReadLine();
                        }
                    }

                }
                catch (Exception e)
                {

                    throw;
                }
            }                
        }
    }
}
