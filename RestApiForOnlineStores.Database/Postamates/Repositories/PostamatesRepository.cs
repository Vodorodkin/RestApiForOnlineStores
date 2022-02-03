using System.Collections.Generic;
using System.Threading.Tasks;
using RestApiForOnlineStores.Database.Postamates.Models;
using RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces;

namespace RestApiForOnlineStores.Database.Postamates.Repositories
{
    public class PostamatesRepository : IPostamatesRepository
    {
        public Task<IEnumerable<PostamatDb>> GetActivePostamates()
        {
            throw new System.NotImplementedException();
        }

        public Task<PostamatDb> GetPostamatById(string postamatId)
        {
            throw new System.NotImplementedException();
        }
    }
}