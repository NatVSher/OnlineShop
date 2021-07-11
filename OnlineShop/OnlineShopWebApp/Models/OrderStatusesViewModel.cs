using System.ComponentModel.DataAnnotations;

namespace OnlineShopWebApp.Models
{
    public enum OrderStatusesViewModel
    {
        [Display (Name ="Создан")]
        Generated,
        [Display(Name = "Обработан")]
        Processed,
        [Display(Name = "В пути")]
        OnTheWay,
        [Display(Name = "Отменен")]
        Canceled,
        [Display(Name = "Доставлен")]
        Delivered
    }    
}
