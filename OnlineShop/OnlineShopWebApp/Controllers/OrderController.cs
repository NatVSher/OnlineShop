using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    [Authorize]
    public class OrderController : BaseController
        
    {
        private readonly IBasketsRepository basketsRepository;
        private readonly IOrdersRepository ordersRepository;
        private readonly IMapper mapper;
        public OrderController(IBasketsRepository basketsRepository, IOrdersRepository ordersRepository, IMapper mapper)
        {
            this.basketsRepository = basketsRepository;
            this.ordersRepository = ordersRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {            
            return View();
        }
        [HttpPost]
        public IActionResult Buy(ContactDetailsViewModel contactDetails)
        {
            if (ModelState.IsValid)
            {
                var existingBasket = basketsRepository.TryGetByUserId(GetUserId());                
                var order = new Order
                {
                    ContactData = mapper.Map<ContactDetails>(contactDetails),
                    Items = existingBasket.Items,
                    UserId = existingBasket.UserId
                };
                ordersRepository.Add(order);
                basketsRepository.Clear(GetUserId());
                return View();
            }
            return View("Index", contactDetails);
        }
    }
}
