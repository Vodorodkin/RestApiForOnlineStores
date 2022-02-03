using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Orders.Models;

namespace RestApiForOnlineStores.Database.Orders.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        Task CreateOrderAsync(OrderDb orderDb);
        Task EditOrderAsync(OrderDb orderDb);
        Task<OrderDb> GetOrderByIdAsync(int orderId);
    }
}