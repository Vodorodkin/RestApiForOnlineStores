using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestApiForOnlineStores.Database.Contexts;
using RestApiForOnlineStores.Database.Postamates.Models;
using RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces;

namespace RestApiForOnlineStores.Database.Postamates.Repositories
{
    public class PostamatesRepository : IPostamatesRepository
    {
        private readonly SqlDbContext _context;

        public PostamatesRepository(SqlDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PostamatDb>> GetActivePostamatesAsync()
        {
            IEnumerable<PostamatDb> postamatDbs = await _context.PostamatDbs
                .Where(p => p.State)
                .OrderBy(p => p.Id)
                .ToListAsync();

            return postamatDbs;
        }

        public async Task<PostamatDb> GetPostamatByIdAsync(string postamatId)
        {
            PostamatDb postamatDb = await _context
                .PostamatDbs
                .FirstOrDefaultAsync(p => p.Id == postamatId);

            return postamatDb;
        }
    }
}