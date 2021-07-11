using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Helpers;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopWebApp.Controllers
{
    public class PersonalAccountController : BaseController
    {
        private readonly UserManager<User> _userManager;
        private readonly ImagesProvider _imagesProvider;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMemoryCache cache;
        private readonly IMapper mapper;

        public PersonalAccountController(UserManager<User> userManager,
            ImagesProvider imagesProvider,
            IOrdersRepository ordersRepository,
            IMemoryCache cache,
            IMapper mapper)
        {
            _userManager = userManager;
            _imagesProvider = imagesProvider;
            _ordersRepository = ordersRepository;
            this.cache = cache;
            this.mapper = mapper;
        }

        public IActionResult Index(String userName)
        {           
            var user = _userManager.FindByNameAsync(userName).Result;
            
            return View(mapper.Map<UserViewModel>(user));
        }

        [HttpPost]
        public IActionResult Index(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByIdAsync(userViewModel.Id).Result;
                if (user != null)
                {
                    user.FirstName = userViewModel.FirstName;
                    user.Surname = userViewModel.Surname;
                    user.PhoneNumber = userViewModel.PhoneNumber;
                    if (userViewModel.UploadedFile != null)
                    {
                        var addedImagePath = _imagesProvider.SafeFile(userViewModel.UploadedFile, ImageFolders.Profiles);
                        user.ImagePath = addedImagePath;
                        //если автарка изменилась удаляем старый кэш, чтобы при очередном запросе он обновился
                        cache.Remove(user.UserName);
                    }
                }
                var result = _userManager.UpdateAsync(user).Result;
                if (result.Succeeded)
                {
                    return Redirect("/Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(userViewModel);
        }
        public IActionResult Orders(String userName)
        {
            var orders = _ordersRepository.TryGetByUserId(userName);
            return View(mapper.Map<List<OrderViewModel>>(orders));
        }
        public IActionResult GetOrder(Guid id)
        {
            var order = _ordersRepository.TryGetById(id);
            var items = order.Items;
            return View(mapper.Map<List<BasketItemViewModel>>(items));
        }

        public IActionResult ChangePassword(String userName)
        {
            var changePassword = new ChangePassword()
            {
                UserName = userName
            };
            return View(changePassword);
        }
        [HttpPost]
        public IActionResult ChangePassword(ChangePassword changePassword)
        {
            if (changePassword.ConfirmPassword != changePassword.NewPassword)
                ModelState.AddModelError("", "Пароли не совпадают.");

            if (ModelState.IsValid)
            {
                var user = _userManager.FindByNameAsync(changePassword.UserName).Result;
                if (user != null)
                {
                    _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword).Wait();
                    return RedirectToAction("Index", new { userName = user.UserName });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }
            return View(changePassword);
        }
        public IActionResult DeleteAvatar(String userName)
        {
            var user = _userManager.FindByNameAsync(userName).Result;
            user.ImagePath = null;
            _userManager.UpdateAsync(user).Wait();
            cache.Remove(user.UserName);
            return RedirectToAction("Index", new { userName = user.UserName });
        }
    }
}
