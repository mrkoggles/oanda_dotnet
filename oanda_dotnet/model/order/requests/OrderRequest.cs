using oanda_dotnet.model.transaction;
using System.ComponentModel.DataAnnotations;

namespace oanda_dotnet.model.order
{
    /// <summary>
    /// The base Order specification used when requesting that an Order be created.
    /// Each specific Order-type extends this definition.
    /// </summary>
    public abstract class OrderRequest
    {
        /// <summary>
        /// The type of the Order.
        /// </summary>
        public abstract OrderType Type { get; }

        /// <summary> 
        /// The time-in-force requested for the Exit Order. 
        /// </summary> 
        [Required]
        public abstract TimeInForce TimeInForce { get; set; }

        /// <summary> 
        /// The client extensions to add to the Order. Do not set, modify, or delete 
        /// clientExtensions if your account is associated with MT4. 
        /// </summary> 
        public ClientExtensions ClientExtensions { get; set; }
    }
}
