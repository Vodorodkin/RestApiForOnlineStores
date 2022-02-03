using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Postamates.Models;

namespace RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces
{
    public interface IPostamatesRepository
    {
        Task<IEnumerable<PostamatDb>> GetActivePostamatesAsync();
        Task<PostamatDb> GetPostamatByIdAsync(string postamatId);
    }
}