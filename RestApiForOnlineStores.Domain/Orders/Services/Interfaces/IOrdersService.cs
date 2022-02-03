using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Orders.Models;

namespace RestApiForOnlineStores.Domain.Orders.Services.Interfaces
{
    public interface IOrderServices
    {
        Task<IResult> CreateOrder(OrderBlank orderBlank);
        Task<IResult> EditOrder(OrderBlank orderBlank);
        Task<IResult<Order>> GetOrderById(int orderId);
        Task<IResult> CancelOrder(int orderId);
    }
}