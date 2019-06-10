using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using oanda_dotnet.model.transaction;
using oanda_dotnet.api;
using System.Text;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class TransactionRequests : BaseTestClass
    {
        private TransactionApi _api;

        public TransactionRequests()
        {
            _api = new TransactionApi(this.Client);
        }

        [TestMethod]
        public void GetTransaction()
        {
            var response = _api.GetTransaction(this.AccountId, 3);
            Assert.IsTrue(response.Transaction != null);

        }

        [TestMethod]
        public void GetTransactionsInRange()
        {
            var response = _api.GetTransactions(this.AccountId, 3);
            Assert.IsTrue(response.Transaction != null);
        }

        [TestMethod]
        public void GetTransactionsSince()
        {
            var response = _api.GetTransactions(this.AccountId, 3, 3);
            Assert.IsTrue(response.Transaction != null);
        }

        [TestMethod]
        public void GetTransactionsSinceWithFilter()
        {
            var response = _api.GetTransactions(this.AccountId, 0, 1500, TransactionFilter.ClientConfigure);
            Assert.IsTrue(response.Transaction != null);
        }
    }
}
