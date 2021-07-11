using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp.Controllers
{
    public class FavoritesController : BaseController
    {
        private readonly IProductsRepository productsRepository;        
        private readonly IFavoritesRepository favoritesRepository;
        private readonly IMapper mapper;
        public FavoritesController(IProductsRepository productsRepository, IFavoritesRepository favoritesRepository, IMapper mapper)
        {
            this.productsRepository = productsRepository;
            this.favoritesRepository = favoritesRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var favorites = favoritesRepository.GetAll(GetUserId());            
            return View(mapper.Map<List<ProductViewModel>>(favorites));
        }
        public IActionResult Add(Guid productId)
        {
            var product = productsRepository.TryGetById(productId);           
            favoritesRepository.Add(product, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid productId)
        {            
            favoritesRepository.Remove(productId, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            favoritesRepository.Clear(GetUserId());

            return RedirectToAction("Index");
        }
    }
}
