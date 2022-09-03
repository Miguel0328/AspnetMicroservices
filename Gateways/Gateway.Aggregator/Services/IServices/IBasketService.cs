using Gateway.Aggregator.Models;

namespace Gateway.Aggregator.Services.IServices
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
