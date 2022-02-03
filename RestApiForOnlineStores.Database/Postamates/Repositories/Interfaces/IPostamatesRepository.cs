using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Postamates.Models;

namespace RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces
{
    public interface IPostamatesRepository
    {
        Task<IEnumerable<PostamatDb>> GetActivePostamates();
        Task<PostamatDb> GetPostamatById(string postamatId);
    }
}