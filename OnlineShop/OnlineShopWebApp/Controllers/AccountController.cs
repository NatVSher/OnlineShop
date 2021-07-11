using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShop.Db.Models;
using System;
using OnlineShop.Db;

namespace OnlineShopWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IBasketsRepository _basketRepository;
        private readonly IFavoritesRepository _favoritesRepository;
        private readonly IProductsComparedRepository _productsComparedRepository;
        private readonly EmailService _emailService;

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            IBasketsRepository basketRepository,
            IFavoritesRepository favoritesRepository,
            IProductsComparedRepository productsComparedRepository,
            EmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _basketRepository = basketRepository;
            _favoritesRepository = favoritesRepository;
            _productsComparedRepository = productsComparedRepository;
            _emailService = emailService;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new Login() { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(login.UserName, login.Password, login.Remember, false).Result;               
                if (result.Succeeded)
                {                     
                    if (Request.Cookies.TryGetValue(Constants.UserId, out var unauthorizedUserId))
                    {
                        var user = _userManager.FindByNameAsync(login.UserName).Result;
                        //Отдать корзину и выбранные товары авторизованному пользователю от еще неавторизованного 
                        _basketRepository.GiveBasket(user.UserName, unauthorizedUserId);
                        _favoritesRepository.GiveFavorites(user.UserName, unauthorizedUserId);
                        _productsComparedRepository.GiveProductsCompared(user.UserName, unauthorizedUserId);
                    }
                    return Redirect(login.ReturnUrl ?? "/Home");
                }
                else
                {
                    ModelState.AddModelError("", "Логин или пароль неверный. Попробуйте еще раз.");
                }
            }
            return View("Login", login);
        }
        public IActionResult Register(string returnUrl)
        {
            return View(new Register() { ReturnUrl = returnUrl });
        }
        [HttpPost]
        public IActionResult Register(Register register)
        {
            if (ModelState.IsValid)
            {
                _emailService.SendMailToRegister(register.UserName);
                User user = new User { Email = register.UserName, UserName = register.UserName };
                // добавляем пользователя
                var result = _userManager.CreateAsync(user, register.Password).Result;
                if (result.Succeeded)
                {
                    // установка куки
                    _signInManager.SignInAsync(user, false).Wait();
                    TryAssignUserRole(user);
                    // Завершение регистрации без Email: return Redirect(register.ReturnUrl ?? "/Home"); 
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("Register", register);
        }

        private void TryAssignUserRole(User user)
        {
            try
            {
                _userManager.AddToRoleAsync(user, Constants.UserRoleName).Wait();
            }
            catch (Exception)
            {                
            }
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }       
    }
}
