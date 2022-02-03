using System.ComponentModel.DataAnnotations;

namespace RestApiForOnlineStores.Domain.Orders.Enums
{
    public enum OrderState
    {
        [Display(Name = "Зарегистрирован")]
        Registered = 1,
        
        [Display(Name = "Принят на складе")]
        AcceptedInStock = 2,
        
        [Display(Name = "Выдан курьеру")]
        IssuedToCourier = 3,
        
        [Display(Name = "Доставлен в постамат")]
        DeliveredToPostamat = 4,
        
        [Display(Name = "Доставлен получателю")]
        DeliveredToRecipient = 5,
        
        [Display(Name = "Отменен")]
        Cancelled = 6,
    }
}