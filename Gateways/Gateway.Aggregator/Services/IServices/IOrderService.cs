using Gateway.Aggregator.Models;

namespace Gateway.Aggregator.Services.IServices
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}
