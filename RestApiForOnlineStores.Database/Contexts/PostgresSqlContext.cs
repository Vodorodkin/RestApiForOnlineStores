using Microsoft.EntityFrameworkCore;

namespace RestApiForOnlineStores.Database.Contexts
{
    public class PostgreSqlContext : SqlDbContext
    {
        public PostgreSqlContext(string connectionString) : base(connectionString){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}