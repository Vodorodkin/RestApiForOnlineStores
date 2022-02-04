using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jane;
using Microsoft.AspNetCore.Mvc;
using RestApiForOnlineStores.Domain.Postamates.Converters;
using RestApiForOnlineStores.Domain.Postamates.Models;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;

namespace RestApiForOnlineStores.API.Controllers
{
    [Route("Postamates")]
    public class PostamatesController : Controller
    {
        private readonly IPostamatesService _postamatesService;

        public PostamatesController(IPostamatesService postamatesService)
        {
            _postamatesService = postamatesService;
        }
        
        [HttpGet("GetActive")]
        public async Task<ActionResult> GetActivePostamatesAsync()
        {
            try
            {
                IResult<IEnumerable<Postamat>> getOrderByIdResult = await _postamatesService.GetActivePostamates();
                JsonResult jsonResult;
                
                if (getOrderByIdResult.Ok)
                {
                    jsonResult = new JsonResult(Result.Success(getOrderByIdResult.Value.ToPostamatViews()));
                }
                else
                {
                    jsonResult = new JsonResult(Result.Failure(getOrderByIdResult.Reason));
                }
                
                return jsonResult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [HttpGet("GetById")]
        public async Task<ActionResult> GetPostamatByIdAsync([FromQuery]string postamatId)
        {
            try
            {
                IResult<Postamat> getOrderByIdResult = await _postamatesService.GetPostamatById(postamatId);
                JsonResult jsonResult;
                
                if (getOrderByIdResult.Ok)
                {
                    jsonResult = new JsonResult(Result.Success(getOrderByIdResult.Value.ToPostamatView()));
                }
                else
                {
                    jsonResult = new JsonResult(Result.Failure(getOrderByIdResult.Reason));
                }
                
                return jsonResult;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}