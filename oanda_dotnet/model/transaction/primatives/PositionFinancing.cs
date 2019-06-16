using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oanda_dotnet.model.transaction
{
    /// <summary>
    /// OpenTradeFinancing is used to pay/collect daily financing charge for a Position within an Account
    /// </summary>
    public class PositionFinancing
    {
        /// <summary>
        /// The instrument of the Position that financing is being paid/collected
        /// for.
        /// </summary>
        public InstrumentName Instrument { get; set; }

        /// <summary>
        /// The amount of financing paid/collected for the Position.
        /// </summary>
        public AccountUnits Financing { get; set; }

        /// <summary>
        /// The financing paid/collecte for each open Trade within the Position.
        /// </summary>
        public ICollection<OpenTradeFinancing> OpenTradeFinancings { get; set; }

    }
}
