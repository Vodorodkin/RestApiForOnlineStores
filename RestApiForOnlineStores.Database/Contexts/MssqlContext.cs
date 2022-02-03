using Microsoft.EntityFrameworkCore;

namespace RestApiForOnlineStores.Database.Contexts
{
    public class MssqlContext : SqlDbContext
    {
        public MssqlContext(string connectionString) : base(connectionString){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}