using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly IMemoryCache cache;
        private readonly IMapper mapper;

        public HomeController(IProductsRepository productsRepository, IMemoryCache cache, IMapper mapper)
        {
            this.productsRepository = productsRepository;
            this.cache = cache;
            this.mapper = mapper;
        }
        //[ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)] - страница не кэшируется,
        //заголовки автоматически меняются на 'no-cache, no-store',
        //т.к. любой ответ, в котором используется защита от подделки, не должен кэшироваться.
        public IActionResult Index()
        {
            cache.TryGetValue<List<Product>>(Constants.KeyCacheAllProducts, out var products);             
            return View(mapper.Map<List<ProductViewModel>>(products));
        }
        
        [HttpPost]
        public IActionResult Search(string searchName)
        {
            if (searchName==null) 
                return RedirectToAction("Index");

            var products = productsRepository.SearchByName(searchName);            
            return View(mapper.Map<List<ProductViewModel>>(products));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
