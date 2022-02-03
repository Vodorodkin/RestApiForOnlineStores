using System.Collections.Generic;
using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Postamates.Models;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;

namespace RestApiForOnlineStores.Domain.Postamates.Services
{
    public class PostamatesService : IPostamatesService
    {
        public async Task<IResult<IEnumerable<Postamat>>> GetActivePostamates()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IResult<Postamat>> GetPostamatById(string postamatId)
        {
            throw new System.NotImplementedException();
        }
    }
}