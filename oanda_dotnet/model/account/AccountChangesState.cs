using oanda_dotnet.model.order;
using oanda_dotnet.model.position;
using oanda_dotnet.model.trade;
using System.Collections.Generic;

namespace oanda_dotnet.model.account
{
    /// <summary>
    /// An AccountState Object is used to represent an Account’s current price-dependent state. 
    /// Price-dependent Account state is dependent on OANDA’s current Prices, and includes things like unrealized PL, NAV and Trailing Stop Loss Order state.
    /// </summary>
    public class AccountChangesState
    {
        /// <summary> 
        /// The total unrealized profit/loss for all Trades currently open in the 
        /// Account. 
        /// </summary> 
        public AccountUnits UnrealizedPL { get; set; }

        /// <summary> 
        /// The net asset value of the Account. Equal to Account balance + 
        /// unrealizedPL. 
        /// </summary> 
        public AccountUnits NAV { get; set; }

        /// <summary> 
        /// Margin currently used for the Account. 
        /// </summary> 
        public AccountUnits MarginUsed { get; set; }

        /// <summary> 
        /// Margin available for Account currency. 
        /// </summary> 
        public AccountUnits MarginAvailable { get; set; }

        /// <summary> 
        /// The value of the Account’s open positions represented in the Account’s 
        /// home currency. 
        /// </summary> 
        public AccountUnits PositionValue { get; set; }

        /// <summary> 
        /// The Account’s margin closeout unrealized PL. 
        /// </summary> 
        public AccountUnits MarginCloseoutUnrealizedPL { get; set; }

        /// <summary> 
        /// The Account’s margin closeout NAV. 
        /// </summary> 
        public AccountUnits MarginCloseoutNAV { get; set; }

        /// <summary> 
        /// The Account’s margin closeout margin used. 
        /// </summary> 
        public AccountUnits MarginCloseoutMarginUsed { get; set; }

        /// <summary> 
        /// The Account’s margin closeout percentage. When this value is 1.0 or above 
        /// the Account is in a margin closeout situation. 
        /// </summary> 
        public decimal MarginCloseoutPercent { get; set; }

        /// <summary> 
        /// The value of the Account’s open positions as used for margin closeout 
        /// calculations represented in the Account’s home currency. 
        /// </summary> 
        public decimal MarginCloseoutPositionValue { get; set; }

        /// <summary> 
        /// The current WithdrawalLimit for the account which will be zero or a 
        /// positive value indicating how much can be withdrawn from the account. 
        /// </summary> 
        public AccountUnits WithdrawalLimit { get; set; }

        /// <summary> 
        /// The Account’s margin call margin used. 
        /// </summary> 
        public AccountUnits MarginCallMarginUsed { get; set; }

        /// <summary> 
        /// The Account’s margin call percentage. When this value is 1.0 or above the 
        /// Account is in a margin call situation. 
        /// </summary> 
        public decimal MarginCallPercent { get; set; }

        /// <summary> 
        /// The price-dependent state of each pending Order in the Account. 
        /// </summary> 
        public ICollection<DynamicOrderState> Orders { get; set; }

        /// <summary> 
        /// The price-dependent state for each open Trade in the Account. 
        /// </summary> 
        public ICollection<CalculatedTradeState> Trades { get; set; }

        /// <summary> 
        /// The price-dependent state for each open Position in the Account. 
        /// </summary> 
        public ICollection<CalculatedPositionState> Positions { get; set; }
    }
}
