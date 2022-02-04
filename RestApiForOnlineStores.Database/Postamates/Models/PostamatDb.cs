using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiForOnlineStores.Database.Postamates.Models
{
    [Table("Postamates")]
    public class PostamatDb
    {
        [Key]
        public string Id { get; set; }
        public string Address { get; set; }
        public bool State { get; set; }
    }
}