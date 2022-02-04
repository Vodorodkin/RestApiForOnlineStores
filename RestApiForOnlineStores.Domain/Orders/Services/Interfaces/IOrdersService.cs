using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Orders.Models;

namespace RestApiForOnlineStores.Domain.Orders.Services.Interfaces
{
    public interface IOrdersService
    {
        Task<IResult> CreateOrderAsync(OrderBlank orderBlank);
        Task<IResult> EditOrderAsync(OrderBlank orderBlank);
        Task<IResult<Order>> GetOrderByIdAsync(int? orderId);
        Task<IResult> CancelOrderAsync(int? orderId);
    }
}