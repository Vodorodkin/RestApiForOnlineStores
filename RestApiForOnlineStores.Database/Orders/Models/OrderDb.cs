using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RestApiForOnlineStores.Database.Orders.Models
{
    [Table("Orders")]
    public class OrderDb
    {
        [Key]
        public int Id { get; set; }
        public int State { get; set; }
        public List<string> Products { get; set; }
        public decimal Cost { get; set; }
        public string PostamatId { get; set; }
        public string PhoneNumber { get; set; }
        public string RecipientFullName { get; set; }

        public OrderDb(int id, int state, IEnumerable<string> products, decimal cost, string postamatId, string phoneNumber, string recipientFullName)
        {
            Id = id;
            State = state;
            Products = products.ToList();
            Cost = cost;
            PostamatId = postamatId;
            PhoneNumber = phoneNumber;
            RecipientFullName = recipientFullName;
        }

        public OrderDb(){}
    }
}