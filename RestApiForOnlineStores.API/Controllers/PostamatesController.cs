using Microsoft.AspNetCore.Mvc;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;

namespace RestApiForOnlineStores.API.Controllers
{
    public class PostamatesController : Controller
    {
        private readonly IPostamatesService _postamatesService;

        public PostamatesController(IPostamatesService postamatesService)
        {
            _postamatesService = postamatesService;
        }
        
        
    }
}