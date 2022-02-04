using Microsoft.AspNetCore.Mvc;
using RestApiForOnlineStores.Domain.Orders.Services.Interfaces;

namespace RestApiForOnlineStores.API.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
    }
}