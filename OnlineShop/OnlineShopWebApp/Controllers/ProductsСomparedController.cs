using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp.Controllers
{
    public class ProductsComparedController : BaseController
    {
        private readonly IProductsComparedRepository productsComparedRepository;
        private readonly IProductsRepository productsRepository;
        private readonly IMapper mapper;
        public ProductsComparedController(IProductsComparedRepository productsComparedRepository, IProductsRepository productsRepository = null, IMapper mapper = null)
        {
            this.productsComparedRepository = productsComparedRepository;
            this.productsRepository = productsRepository;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var productsCompared = productsComparedRepository.GetAll(GetUserId());            
            return View(mapper.Map<List<ProductViewModel>>(productsCompared));
        }
        public IActionResult Add(Guid productId)
        {
            var product = productsRepository.TryGetById(productId);            
            productsComparedRepository.Add(product, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid productId)
        {
            productsComparedRepository.Remove(productId, GetUserId());

            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            productsComparedRepository.Clear(GetUserId());

            return RedirectToAction("Index");
        }
    }
}
