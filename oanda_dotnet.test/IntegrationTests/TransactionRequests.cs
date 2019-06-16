using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model.transaction;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using oanda_dotnet.model.transaction;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

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
            Assert.IsTrue(response.LastTransactionId > 0);
        }

        [TestMethod]
        public void GetTransactionsSince()
        {
            var response = _api.GetTransactions(this.AccountId, 3, 3);
            Assert.IsTrue(response.LastTransactionId > 0);
        }

        [TestMethod]
        public void GetTransactionsSinceWithFilter()
        {
            var response = _api.GetTransactions(this.AccountId, 0, 1500, TransactionFilter.ClientConfigure);
            Assert.IsTrue(response.LastTransactionId > 0);
        }

        [TestMethod]
        public void AllTransactionsAreDefined()
        {
            ICollection<TransactionType> transactionTypesNotDefined = 
                Enum.GetValues(typeof(TransactionType)).Cast<TransactionType>()
                .Where(type =>
                    Assembly.GetAssembly(typeof(Transaction)).GetTypes()
                        .Where(objectType => typeof(Transaction).IsAssignableFrom(objectType) && !objectType.IsAbstract)
                        .FirstOrDefault(objectType => 
                            (TransactionType)objectType
                                .GetProperty("Type")
                                .GetValue((Transaction)Activator.CreateInstance(objectType)) == type) == null).ToList();

            Assert.AreEqual(0, transactionTypesNotDefined.Count());
        }
    }
}
