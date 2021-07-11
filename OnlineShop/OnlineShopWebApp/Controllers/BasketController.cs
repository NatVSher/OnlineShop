using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using System;

namespace OnlineShopWebApp.Controllers
{
    public class BasketController : BaseController
    {
        private readonly IProductsRepository productRepository;
        private readonly IBasketsRepository basketsRepository;
        private readonly IMapper mapper;
        public BasketController(IProductsRepository productRepository, IBasketsRepository basketsRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.basketsRepository = basketsRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var basket = basketsRepository.TryGetByUserId(GetUserId()); 
            
            return View(mapper.Map<BasketViewModel>(basket));
        }
        public IActionResult Add(Guid productId)
        {
            var product = productRepository.TryGetById(productId);
            
            basketsRepository.Add(product, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid productId)
        {            
            basketsRepository.Remove(productId, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            basketsRepository.Clear(GetUserId());

            return RedirectToAction("Index");
        }

    }
}
