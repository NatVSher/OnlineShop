using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;

namespace OnlineShopWebApp.Views.Shared.Components.Basket
{
    public class BasketViewComponent : ViewComponent
    {
        private readonly IBasketsRepository basketsRepository;
        private readonly IMapper mapper;
        public BasketViewComponent(IBasketsRepository basketsRepository, IMapper mapper)
        {
            this.basketsRepository = basketsRepository;
            this.mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var userId = User.Identity.Name ?? Request.Cookies[Constants.UserId];
            if (userId != null)
            {
                var basket = basketsRepository.TryGetByUserId(userId);
                var basketViewModel = mapper.Map<BasketViewModel>(basket);
                var numberProductsInBasket = basketViewModel?.CountProducts ?? 0;
                return View("Basket", numberProductsInBasket);
            }
            return View("Basket", 0);
        }
    }
}
