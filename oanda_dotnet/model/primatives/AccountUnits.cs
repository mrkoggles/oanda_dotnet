using System;

namespace oanda_dotnet.model
{
    /// <summary>
    /// The string representation of a quantity of an Account’s home currency.
    /// </summary>
    public class AccountUnits
    {
        private decimal _accountUnits;

        public static implicit operator AccountUnits(string accountUnits) => new AccountUnits { _accountUnits = Convert.ToDecimal(accountUnits) };
        public static implicit operator string(AccountUnits accountUnits) => accountUnits._accountUnits.ToString();
    }
}
