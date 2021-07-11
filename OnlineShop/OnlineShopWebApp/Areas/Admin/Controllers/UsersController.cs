using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class UsersController : Controller
    {       
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper mapper;
        public UsersController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(mapper.Map<List<UserViewModel>>(users));
        }
        public IActionResult ViewUser(String id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            var userRoles = _userManager.GetRolesAsync(user).Result.ToList();
            ViewBag.UserRoles = userRoles;
            return View(mapper.Map<UserViewModel>(user));
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(CreateUserViewModel createUserViewModel)
        {           
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(createUserViewModel);
                var result = _userManager.CreateAsync(user, createUserViewModel.Password).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View("AddUser", createUserViewModel);
        }
        public IActionResult RemoveUser(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user != null)
            {
                _userManager.DeleteAsync(user).Wait();
            }
            return RedirectToAction("Index");
        }
        public IActionResult EditUser(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }
            return View(mapper.Map<UserViewModel>(user));
        }
        [HttpPost]
        public IActionResult EditUser(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByIdAsync(userViewModel.Id).Result;
                if (user != null)
                {                    
                    user.FirstName = userViewModel.FirstName;
                    user.Surname = userViewModel.Surname;
                    user.PhoneNumber = userViewModel.PhoneNumber;
                    var result = _userManager.UpdateAsync(user).Result;
                    if (result.Succeeded)
                    {
                        return RedirectToAction("ViewUser", user);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            }
            return View(userViewModel);            
        }
        public IActionResult ChangePassword(string id)
        {
            var user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                return NotFound();
            }            
            return View(mapper.Map<UserViewModel>(user));
        }
        [HttpPost]
        public IActionResult ChangePassword(UserViewModel userViewModel, string repeatNewPassword)
        {
            if (repeatNewPassword != userViewModel.Password || repeatNewPassword==null)
                ModelState.AddModelError("", "Пароли не совпадают.");

            if (ModelState.IsValid)
            {
                var user = _userManager.FindByIdAsync(userViewModel.Id).Result;
                if (user != null)
                {
                    var newHashPassword = _userManager.PasswordHasher.HashPassword(user, repeatNewPassword);
                    user.PasswordHash = newHashPassword;
                    _userManager.UpdateAsync(user).Wait();
                    return RedirectToAction("Index");                    
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Пользователь не найден");
                }
            }
            return View(userViewModel);
        }
        public IActionResult ChangeRole(string userId)
        {
            User user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                // получем список ролей пользователя
                var userRoles = _userManager.GetRolesAsync(user).Result.ToList();
                var allRoles = _roleManager.Roles.Select(x=>x.Name).ToList();
                RoleViewModel roleViewModel = new RoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };
                return View(roleViewModel);
            }
            return NotFound();            
        }
        [HttpPost]
        public IActionResult ChangeRole(string userId, List<string> roles)
        {
            // получаем пользователя
            var user = _userManager.FindByIdAsync(userId).Result;
            if (user != null)
            {
                // получем список ролей пользователя
                var userRoles = _userManager.GetRolesAsync(user).Result;
                // получаем все роли
                var allRoles = _roleManager.Roles.Select(x => x.Name).ToList();
                // получаем список ролей, которые были добавлены
                var addedRoles = roles.Except(userRoles);
                // получаем роли, которые были удалены
                var removedRoles = userRoles.Except(roles);

               _userManager.AddToRolesAsync(user, addedRoles).Wait();

                _userManager.RemoveFromRolesAsync(user, removedRoles).Wait();

                return RedirectToAction("ViewUser", mapper.Map<UserViewModel>(user));
            }

            return NotFound();
        }
    }
}
