using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Database.Orders.Repositories.Interfaces;
using RestApiForOnlineStores.Domain.Orders.Converters;
using RestApiForOnlineStores.Domain.Orders.Models;
using RestApiForOnlineStores.Domain.Orders.Services.Interfaces;

namespace RestApiForOnlineStores.Domain.Orders.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ValidationOrderService _validationOrderService;

        public OrdersService(IOrdersRepository ordersRepository, ValidationOrderService validationOrderService)
        {
            _ordersRepository = ordersRepository;
            _validationOrderService = validationOrderService;
        }

        public async Task<IResult> CreateOrder(OrderBlank orderBlank)
        {
            if (orderBlank == null)
                return Result.Failure($"{nameof(orderBlank)} is null");
            
            IResult validationResult = await _validationOrderService.ValidationOrderAsync(orderBlank);

            if (!validationResult.Ok)
                return validationResult;

            await _ordersRepository.CreateOrderAsync(orderBlank.ToOrderDb());
            
            return Result.Success();
        }

        public async Task<IResult> EditOrder(OrderBlank orderBlank)
        {
            if (orderBlank == null)
                return Result.Failure($"{nameof(orderBlank)} is null");
            
            if (orderBlank.Id == null)
                return Result.Failure($"{nameof(orderBlank.Id)} is null");
            
            IResult validationResult = await _validationOrderService.ValidationOrderAsync(orderBlank);

            if (!validationResult.Ok)
                return validationResult;

            IResult<Order> exitingOrderResult = await GetOrderById(orderBlank.Id);
            
            if (!exitingOrderResult.Ok)
                return exitingOrderResult;

            await _ordersRepository.EditOrderAsync(orderBlank.ToOrderDb());
            
            return Result.Success();
        }

        public async Task<IResult<Order>> GetOrderById(int? orderId)
        {
            if (orderId == null)
                return Result.Failure<Order>($"{nameof(orderId)} is null");

            OrderDb orderDb = await _ordersRepository.GetOrderByIdAsync((int)orderId);

            if (orderDb == null)
                return Result.Failure<Order>($"не найден");

            return Result.Success(orderDb.ToOrder());
        }

        public async Task<IResult> CancelOrder(int? orderId)
        {
            IResult<Order> exitingOrderResult = await GetOrderById(orderId);
            
            if (!exitingOrderResult.Ok)
                return exitingOrderResult;

            Order order = exitingOrderResult.Value;

            order.Cancel();

            await _ordersRepository.EditOrderAsync(order.ToOrderDb());
            
            return Result.Success();
        }
    }
}