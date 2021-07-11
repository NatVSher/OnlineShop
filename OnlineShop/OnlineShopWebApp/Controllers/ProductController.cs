using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Controllers
{
    public class ProductController : Controller
    {        
        private readonly IMemoryCache cache;
        private readonly IMapper mapper;
        public ProductController(IMemoryCache cache, IMapper mapper)
        {
            this.cache = cache;
            this.mapper = mapper;
        }
        public IActionResult Index(Guid id)
        {            
            cache.TryGetValue<Product>(id, out var product);
            return View(mapper.Map<ProductViewModel>(product));   
        }
    }
}
