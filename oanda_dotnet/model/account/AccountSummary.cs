using System;
using oanda_dotnet.model.transaction;

namespace oanda_dotnet.model.account
{
    /// <summary>
    /// A summary representation of a client’s Account. The AccountSummary does not provIde to full specification of pending Orders, open Trades and Positions.
    /// </summary>
    public class AccountSummary
    {
        /// <summary>
        /// The Account’s Identifier
        /// </summary>
        public AccountId Id { get; set; }

        /// <summary>
        /// Client-assigned alias for the Account. Only provIded if the Account has
        /// an alias set
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// The home currency of the Account
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// The current balance of the Account.
        /// </summary>
        public AccountUnits Balance { get; set; }

        /// <summary>
        /// Id of the user that created the Account.
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// The date/time when the Account was created.
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// The current guaranteed Stop Loss Order mode of the Account.
        /// </summary>
        public GuaranteedStopLossOrderMode GuaranteedStopLossOrderMode { get; set; }

        /// <summary>
        /// The total profit/loss realized over the lifetime of the Account.
        /// </summary>
        public AccountUnits Pl { get; set; }

        /// <summary>
        /// The total realized profit/loss for the Account since it was last reset by
        /// the client.
        /// </summary>
        public AccountUnits ResettablePL { get; set; }

        /// <summary>
        /// The date/time that the Account’s resettablePL was last reset.
        /// </summary>
        public DateTime ResettablePLTime { get; set; }

        /// <summary>
        /// The total amount of financing paId/collected over the lifetime of the
        /// Account.
        /// </summary>
        public AccountUnits Financing { get; set; }

        /// <summary>
        /// The total amount of commission paId over the lifetime of the Account.
        /// </summary>
        public AccountUnits Commission { get; set; }

        /// <summary>
        /// The total amount of fees charged over the lifetime of the Account for the
        /// execution of guaranteed Stop Loss Orders.
        /// </summary>
        public AccountUnits GuaranteedExecutionFees { get; set; }

        /// <summary>
        /// Client-provIded margin rate overrIde for the Account. The effective
        /// margin rate of the Account is the lesser of this value and the OANDA
        /// margin rate for the Account’s division. This value is only provIded if a
        /// margin rate overrIde exists for the Account.
        /// </summary>
        public decimal MarginRate { get; set; }

        /// <summary>
        /// The date/time when the Account entered a margin call state. Only provIded
        /// if the Account is in a margin call.
        /// </summary>
        public DateTime MarginCallEnterTime { get; set; }

        /// <summary>
        /// The number of times that the Account’s current margin call was extended.
        /// </summary>
        public int MarginCallExtensionCount { get; set; }

        /// <summary>
        /// The date/time of the Account’s last margin call extension.
        /// </summary>
        public DateTime LastMarginCallExtensionTime { get; set; }

        /// <summary>
        /// The number of Trades currently open in the Account.
        /// </summary>
        public int OpenTradeCount { get; set; }

        /// <summary>
        /// The number of Positions currently open in the Account.
        /// </summary>
        public int OpenPositionCount { get; set; }

        /// <summary>
        /// The number of Orders currently pending in the Account.
        /// </summary>
        public int PendingOrderCount { get; set; }

        /// <summary>
        /// Flag indicating that the Account has hedging enabled.
        /// </summary>
        public bool HedgingEnabled { get; set; }

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
        /// The Id of the last Transaction created for the Account.
        /// </summary>
        public TransactionId LastTransactionId { get; set; }
    }
}
