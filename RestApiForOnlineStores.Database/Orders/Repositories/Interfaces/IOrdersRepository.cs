using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Orders.Models;

namespace RestApiForOnlineStores.Database.Orders.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        Task CreateOrder(OrderDb orderDb);
        Task EditOrder(OrderDb orderDb);
        Task<OrderDb> GetOrderById(int orderId);
        Task CancelOrder(int orderId);
    }
}