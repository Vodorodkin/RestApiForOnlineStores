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
    }
}