﻿using System;
using System.Linq;

namespace oanda_dotnet.model.account
{
    public struct AccountId
    {
        public string SiteId { get; set; }
        public string DivisionId { get; set; }
        public string UserId { get; set; }
        public string AccountNumber { get; set; }

        [Obsolete("Needs error handling")]
        public static implicit operator AccountId(string accountId)
        {
            string[] ids = accountId.Split('-');
            if (ids.Length != 4) { throw new Exception(); } //custom exception
            if (!ids.All(id => id.All(char.IsDigit))) { throw new Exception(); } //custom exception
            return new AccountId()
            {
                SiteId = ids[0],
                DivisionId = ids[1],
                UserId = ids[2],
                AccountNumber = ids[3]
            };
        }

        public static implicit operator string(AccountId accountId) => accountId.ToString();

        public override string ToString() 
            => string.Format(@"{0}-{1}-{2}-{3}", this.SiteId, this.DivisionId, this.UserId, this.AccountNumber);
    }
}