using System.Collections.Generic;

namespace oanda_dotnet.model.account
{
    /// <summary>
    /// Properties related to an Account.
    /// </summary>
    public class AccountProperties
    {
        /// <summary> 
        /// The Account’s identifier 
        /// </summary> 
        public AccountId Id { get; set; }

        /// <summary> 
        /// The Account’s associated MT4 Account ID. This field will not be present 
        /// if the Account is not an MT4 account. 
        /// </summary> 
        public int Mt4AccountID { get; set; }

        /// <summary> 
        /// The Account’s tags 
        /// </summary> 
        public ICollection<string> Tags { get; set; }
    }
}
