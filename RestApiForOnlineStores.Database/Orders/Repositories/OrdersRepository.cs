using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApiForOnlineStores.Database.Contexts;
using RestApiForOnlineStores.Database.Orders.Models;
using RestApiForOnlineStores.Database.Orders.Repositories.Interfaces;

namespace RestApiForOnlineStores.Database.Orders.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly SqlDbContext _context;
        
        public OrdersRepository(SqlDbContext context)
        {
            _context = context;
        }
        
        public async Task CreateOrderAsync(OrderDb orderDb)
        {
            await _context.OrderDbs.AddAsync(orderDb);
            await _context.SaveChangesAsync();
        }

        public async Task EditOrderAsync(OrderDb orderDb)
        {
            _context.Entry(await _context.OrderDbs.FirstOrDefaultAsync(o => o.Id == orderDb.Id))
                .CurrentValues.SetValues(orderDb);
            await _context.SaveChangesAsync();
        }

        public async Task<OrderDb> GetOrderByIdAsync(int orderId)
        {
            OrderDb orderDb = await _context.OrderDbs
                .FirstOrDefaultAsync(o => o.Id == orderId);

            return orderDb;
        }
    }
}