using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Domain.Orders.Enums;
using RestApiForOnlineStores.Domain.Orders.Models;
using RestApiForOnlineStores.Tools.Extensions;

namespace RestApiForOnlineStores.Domain.Orders.Converters
{
    public static class OrdersConverter
    {
        public static OrderDb ToOrderDb(this OrderBlank orderBlank)
        {
            OrderDb orderDb = new OrderDb(
                (int)orderBlank.Id,
                orderBlank.State,
                orderBlank.Products,
                orderBlank.Cost,
                orderBlank.PostamatId,
                orderBlank.PhoneNumber,
                orderBlank.RecipientFullName);

            return orderDb;
        }

        public static Order ToOrder(this OrderDb orderDb)
        {
            Order order = new Order(
                orderDb.Id,
                (OrderState)orderDb.State,
                orderDb.Products,
                orderDb.Cost,
                orderDb.PostamatId,
                orderDb.PhoneNumber,
                orderDb.RecipientFullName);

            return order;
        }
        
        public static OrderDb ToOrderDb(this Order order)
        {
            OrderDb orderDb = new OrderDb(
                order.Id,
                (int)order.State,
                order.Products,
                order.Cost,
                order.PostamatId,
                order.PhoneNumber,
                order.RecipientFullName);

            return orderDb;
        }
        
        public static OrderView ToOrderView(this Order order)
        {
            OrderView orderView = new OrderView(
                order.Id,
                (int)order.State,
                order.State.GetDisplayName(),
                order.Products,
                order.Cost,
                order.PostamatId,
                order.PhoneNumber,
                order.RecipientFullName);

            return orderView;
        }
    }
}