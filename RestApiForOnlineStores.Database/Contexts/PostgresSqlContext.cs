using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Database.Postamates.Models;

namespace RestApiForOnlineStores.Database.Contexts
{
    public sealed class PostgreSqlContext : SqlDbContext
    {
        public PostgreSqlContext(string connectionString) : base(connectionString)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDb>().HasData(
                new OrderDb
                {
                    Id = 1,
                    Cost = new decimal(555.321),
                    PhoneNumber = "+7999-999-99-99",
                    PostamatId = "9999-999",
                    Products = new List<string>{"123","223"},
                    State = 1,
                    RecipientFullName = "Иванов Иван Иваныч"
                },
                new OrderDb
                {
                    Id = 2,
                    Cost = new decimal(555.321),
                    PhoneNumber = "+7999-999-99-91",
                    PostamatId = "9999-991",
                    Products = new List<string>{"123","223"},
                    State = 2,
                    RecipientFullName = "Иванов Иван Иваныч"
                });

            modelBuilder.Entity<PostamatDb>().HasData(
                new PostamatDb
                {
                    Id = "9999-991",
                    Address = "Москва",
                    State = true
                },
                new PostamatDb
                {
                    Id = "9999-999",
                    Address = "Москва-1",
                    State = false
                }
            );
        }
    }
}