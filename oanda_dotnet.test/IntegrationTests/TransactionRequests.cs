using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model.transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
        public void GetTransactionPage()
        {
            var response = _api.GetTransactionPages(this.AccountId);
            Assert.IsTrue(response.Pages.Count > 0);
        }


        [TestMethod]
        public void GetTransaction()
        {
            var response = _api.GetTransaction(this.AccountId, 3);
            Assert.IsTrue(response.Transaction != null);
        }

        [TestMethod]
        public void GetTransactionsSince()
        {
            var response = _api.GetTransactions(this.AccountId, 3);
            Assert.IsTrue(response.Transactions.Count > 0);
        }

        [TestMethod]
        public void GetTransactionsInRange()
        {
            var getTransaction = _api.GetTransaction(this.AccountId, 3);
            var response = _api.GetTransactions(this.AccountId, 3, getTransaction.LastTransactionId);
            Assert.IsTrue(response.Transactions.Count > 0);
        }

        [TestMethod]
        public void GetTransactionsSinceWithFilter()
        {
            var getTransaction = _api.GetTransaction(this.AccountId, 3);
            var response = _api.GetTransactions(this.AccountId, 3, getTransaction.LastTransactionId, TransactionFilter.ClientConfigure);
            Assert.IsTrue(response.Transactions.Count > 0);
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
