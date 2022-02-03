using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Postamates.Models;

namespace RestApiForOnlineStores.Domain.Postamates.Services.Interfaces
{
    public interface IPostamatesService
    {
        Task<IResult<IEnumerable<Postamat>>> GetActivePostamates();
        Task<IResult<Postamat>> GetPostamatById(string postamatId);
    }
}