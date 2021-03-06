﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using oanda_dotnet.api;
using oanda_dotnet.model.account;
using System;
using System.Collections.Generic;
using System.Text;
using oanda_dotnet.model;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.test.IntegrationTests
{
    [TestClass]
    public class AccountRequests : BaseTestClass
    {
        private AccountApi _api;

        public AccountRequests()
        {
            _api = new AccountApi(this.Client);
        }


        [TestMethod]
        public void GetAccounts()
        {
            GetAccountsResponse response = _api.GetAccounts();
            Assert.IsTrue(response?.Accounts != null);
        }


        [TestMethod]
        public void GetAccount()
        {
            GetAccountResponse response = _api.GetAccount(this.AccountId);
            Assert.IsTrue(response.Account != null);
        }


        [TestMethod]
        public void GetAccountSummary()
        {
            GetAccountSummaryResponse response = _api.GetAccountSummary(this.AccountId);
            Assert.IsTrue(response.Account != null);
        }


        [TestMethod]
        public void GetAccountInstruments()
        {
            GetAccountInstrumentsResponse response = _api.GetAccountInstruments(this.AccountId);
            Assert.IsTrue(response.Instruments.Count > 0);
        }


        [TestMethod]
        public void GetSelectAccountInstruments()
        {
            GetAccountInstrumentsResponse response = _api.GetAccountInstruments(this.AccountId, new List<InstrumentName>() { "EUR_USD" });
            Assert.IsTrue(response.Instruments.Count == 1);
        }


        [TestMethod]
        public void ConfigureAccount()
        {
            string newAlias = "NewAlias";
            string oldAlias = "OldAlias";
            string aliasTouse = newAlias;
            AccountSummary accountSummary = _api.GetAccountSummary(this.AccountId).Account;
            if (accountSummary.Alias == newAlias) { aliasTouse = oldAlias; }

            ConfigureAccountResponse response = _api.ConfigureAccount(this.AccountId, aliasTouse, 0.1M);
            Assert.IsTrue(response.ClientConfigureTransaction.Alias == aliasTouse);
        }


        [TestMethod]
        public void GetAccountChangesSince()
        {
            GetAccountChangesResponse response = _api.GetAccountChanges(this.AccountId, 3);
            Assert.IsTrue(response.Changes != null);
        }

    }
}
