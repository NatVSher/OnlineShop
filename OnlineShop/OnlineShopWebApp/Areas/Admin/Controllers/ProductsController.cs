using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class ProductsController : Controller
    {
        private readonly IProductsRepository productsRepository;        
        private readonly ImagesProvider imagesProvider;
        private readonly IMapper mapper;
        public ProductsController(IProductsRepository productsRepository, ImagesProvider imagesProvider, IMapper mapper)
        {
            this.productsRepository = productsRepository;
            this.imagesProvider = imagesProvider;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var products = productsRepository.GetAll();
            return View(mapper.Map<List<ProductViewModel>>(products));
        }
        public IActionResult ViewDetails(Guid productId)
        {
            var product = productsRepository.TryGetById(productId);
            return View(mapper.Map<ProductViewModel>(product));
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProduct(CreateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = mapper.Map<Product>(model);
                if (model.UploadedFiles != null)
                {
                    var imagesPaths = imagesProvider.SafeFiles(model.UploadedFiles, ImageFolders.Products);
                    product.Images = imagesPaths.Select(x => new ImageProduct { ImagePath = x }).ToList();                    
                }                
                productsRepository.Add(product);                                
                return RedirectToAction(nameof(Index));
            }
            return View("AddProduct", model);
        }
        public IActionResult RemoveProduct(Guid productId)
        {
            productsRepository.Remove(productId);            
            return RedirectToAction("Index");
        }
        public IActionResult EditProduct(Guid productId)
        {
            var product = productsRepository.TryGetById(productId);
            return View(mapper.Map<EditProductViewModel>(product));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProduct(EditProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model.UploadedFiles != null)
            {
                var addedImagesPaths = imagesProvider.SafeFiles(model.UploadedFiles, ImageFolders.Products);
                model.PathsToImages = addedImagesPaths;
            }
            productsRepository.Edit(mapper.Map<Product>(model));            
            return RedirectToAction(nameof(Index));
        }        
    }
}
