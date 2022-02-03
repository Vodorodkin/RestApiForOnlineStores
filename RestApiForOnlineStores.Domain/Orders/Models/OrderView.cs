using System.Collections.Generic;

namespace RestApiForOnlineStores.Domain.Orders.Models
{
    public class OrderView
    {
        public int Id { get; set; }
        public int State { get; set; }
        public string StateName { get; set; }
        public IEnumerable<string> Products { get; set; }
        public decimal Cost { get; set; }
        public string PostamatId { get; set; }
        public string PhoneNumber { get; set; }
        public string RecipientFullName { get; set; }

        public OrderView(int id, int state, string stateName, IEnumerable<string> products, decimal cost, string postamatId, string phoneNumber, string recipientFullName)
        {
            Id = id;
            State = state;
            StateName = stateName;
            Products = products;
            Cost = cost;
            PostamatId = postamatId;
            PhoneNumber = phoneNumber;
            RecipientFullName = recipientFullName;
        }
    }
}