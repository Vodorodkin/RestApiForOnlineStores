using System;
using System.Threading.Tasks;
using Jane;
using Microsoft.AspNetCore.Mvc;
using RestApiForOnlineStores.Domain.Orders.Converters;
using RestApiForOnlineStores.Domain.Orders.Models;
using RestApiForOnlineStores.Domain.Orders.Services.Interfaces;

namespace RestApiForOnlineStores.API.Controllers
{
    [Route("Orders")]
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> CreateOrderAsync([FromBody]OrderBlank orderBlank)
        {
            try
            {
                IResult createOrderResult = await _ordersService.CreateOrderAsync(orderBlank);

                return new JsonResult(createOrderResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [HttpPost("Edit")]
        public async Task<ActionResult> EditOrderAsync([FromBody]OrderBlank orderBlank)
        {
            try
            {
                IResult editOrderResult = await _ordersService.EditOrderAsync(orderBlank);

                return new JsonResult(editOrderResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("GetById")]
        public async Task<ActionResult> GetOrderByIdAsync([FromQuery]int? orderId)
        {
            try
            {
                IResult<Order> getOrderByIdResult = await _ordersService.GetOrderByIdAsync(orderId);
                JsonResult jsonResult;
                
                if (getOrderByIdResult.Ok)
                {
                    jsonResult = new JsonResult(Result.Success(getOrderByIdResult.Value.ToOrderView()));
                }
                else
                {
                    jsonResult = new JsonResult(Result.Failure(getOrderByIdResult.Reason));
                }
                
                return jsonResult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("Cancel")]
        public async Task<ActionResult> CancelOrderAsync([FromBody]OrderBlank orderBlank)
        {
            try
            {
                IResult cancelOrderResult = await _ordersService.CancelOrderAsync(orderBlank.Id);

                return new JsonResult(cancelOrderResult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}