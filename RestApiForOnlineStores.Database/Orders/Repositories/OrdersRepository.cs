using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Database.Orders.Repositories.Interfaces;

namespace RestApiForOnlineStores.Database.Orders.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        public Task CreateOrder(OrderDb orderDb)
        {
            throw new System.NotImplementedException();
        }

        public Task EditOrder(OrderDb orderDb)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderDb> GetOrderById(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task CancelOrder(int orderId)
        {
            throw new System.NotImplementedException();
        }
    }
}