using Microsoft.EntityFrameworkCore;
using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Database.Postamates.Models;

namespace RestApiForOnlineStores.Database.Contexts
{
    public abstract class SqlDbContext : DbContext
    {
        protected readonly string ConnectionString;

        public DbSet<OrderDb> OrderDbs { get; set; }
        public DbSet<PostamatDb> PostamatDbs { get; set; }

        protected SqlDbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}