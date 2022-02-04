using System.Collections;
using System.Collections.Generic;
using RestApiForOnlineStores.Domain.Orders.Enums;

namespace RestApiForOnlineStores.Domain.Orders.Models
{
    public class Order
    {
        //can use guid type for Id
        public int? Id { get; }
        public OrderState State { get; private set; }
        public IEnumerable<string> Products { get; }
        public decimal Cost { get; }
        public string PostamatId { get; }
        public string PhoneNumber { get; }
        public string RecipientFullName { get; }

        public Order(int? id, OrderState state, IEnumerable<string> products, decimal cost, string postamatId, string phoneNumber, string recipientFullName)
        {
            Id = id;
            State = state;
            Products = products;
            Cost = cost;
            PostamatId = postamatId;
            PhoneNumber = phoneNumber;
            RecipientFullName = recipientFullName;
        }

        public void Cancel()
        {
            State = OrderState.Cancelled;
        }
    }
}