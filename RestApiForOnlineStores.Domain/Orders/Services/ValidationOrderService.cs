using System.Linq;
using System.Threading.Tasks;
using Jane;
using RestApiForOnlineStores.Domain.Orders.Models;
using RestApiForOnlineStores.Domain.Postamates.Models;
using RestApiForOnlineStores.Domain.Postamates.Services.Interfaces;
using RestApiForOnlineStores.Tools.FormatValidators;

namespace RestApiForOnlineStores.Domain.Orders.Services
{
    public class ValidationOrderService
    {
        private readonly IPostamatesService _postamatesService;

        public ValidationOrderService(IPostamatesService postamatesService)
        {
            _postamatesService = postamatesService;
        }

        public async Task<IResult> ValidationOrderAsync(OrderBlank orderBlank, Order existingOrder = null)
        {
            if (orderBlank.Products.Count() > 10)
                return Result.Failure($"ошибка запроса");

            if (orderBlank.PostamatId == null)
                return Result.Failure($"{nameof(orderBlank.PostamatId)} is null");

            IResult<Postamat> postamatResult = await _postamatesService.GetPostamatById(orderBlank.PostamatId);

            if (postamatResult.Ok == false)
                return postamatResult;

            Postamat postamat = postamatResult.Value;
            
            if (postamat.State == false)
                return Result.Failure($"запрещено");

            IResult isCorrectPhoneNumber = FormatValidator.IsCorrectPhoneNumber(orderBlank.PhoneNumber);
            if (isCorrectPhoneNumber.Ok == false)
                return isCorrectPhoneNumber;

            IResult isCorrectPostamatId = FormatValidator.IsCorrectPostamatId(orderBlank.PostamatId);
            if (isCorrectPostamatId.Ok == false)
                return isCorrectPostamatId;
            
            if (existingOrder != null)
            {
                if (orderBlank.State != (int) existingOrder.State)
                    return Result.Failure($"нельзя изменить статус заказа");
                
                if (orderBlank.PostamatId != existingOrder.PostamatId)
                    return Result.Failure($"нельзя изменить постамат заказа");
            }
            
            return Result.Success();
        }
    }
}