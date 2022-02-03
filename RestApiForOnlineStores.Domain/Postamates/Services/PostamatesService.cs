using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Database.Postamates.Models;
using RestApiForOnlineStores.Database.Postamates.Repositories.Interfaces;
using RestApiForOnlineStores.Domain.Postamates.Converters;
using RestApiForOnlineStores.Domain.Postamates.Models;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;
using RestApiForOnlineStores.Tools.FormatValidators;

namespace RestApiForOnlineStores.Domain.Postamates.Services
{
    public class PostamatesService : IPostamatesService
    {
        private readonly IPostamatesRepository _postamatesRepository;

        public PostamatesService(IPostamatesRepository postamatesRepository)
        {
            _postamatesRepository = postamatesRepository;
        }

        public async Task<IResult<IEnumerable<Postamat>>> GetActivePostamates()
        {
            IEnumerable<PostamatDb> postamatDbs = await _postamatesRepository.GetActivePostamatesAsync();

            return Result.Success(postamatDbs.ToPostamates());
        }

        public async Task<IResult<Postamat>> GetPostamatById(string postamatId)
        {
            if (String.IsNullOrEmpty(postamatId))
                return Result.Failure<Postamat>($"{nameof(postamatId)} is null or empty");

            IResult validatePostamatResult = FormatValidator.IsCorrectPostamatId(postamatId);
            
            if (validatePostamatResult.Ok == false)
                return (IResult<Postamat>)validatePostamatResult;
            
            PostamatDb postamatDb = await _postamatesRepository.GetPostamatByIdAsync(postamatId);
            
            return Result.Success(postamatDb.ToPostamat());
        }
    }
}