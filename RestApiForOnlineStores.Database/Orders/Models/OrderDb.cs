using System.Collections.Generic;

namespace RestApiForOnlineStores.Database.Orders.Models
{
    public class OrderDb
    {
        public int Id { get; set; }
        public int State { get; set; }
        public IEnumerable<string> Products { get; set; }
        public decimal Cost { get; set; }
        public string PostamatId { get; set; }
        public string PhoneNumber { get; set; }
        public string RecipientFullName { get; set; }
    }
}