using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Orders.Models;
using RestApiForOnlineStores.Domain.Orders.Services.Interfaces;

namespace RestApiForOnlineStores.Domain.Orders.Services
{
    public class OrderService : IOrderServices
    {
        public async Task<IResult> CreateOrder(OrderBlank orderBlank)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IResult> EditOrder(OrderBlank orderBlank)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IResult<Order>> GetOrderById(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IResult> CancelOrder(int orderId)
        {
            throw new System.NotImplementedException();
        }
    }
}