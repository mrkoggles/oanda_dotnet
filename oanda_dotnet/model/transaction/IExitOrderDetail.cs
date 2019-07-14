using oanda_dotnet.model.order;

namespace oanda_dotnet.model.transaction
{
    public interface IExitOrderDetail
    { 
        TimeInForce TimeInForce { get; set; }         
        System.DateTime GtdTime { get; set; }
        ClientExtensions ClientExtensions { get; set; }
    }
}
