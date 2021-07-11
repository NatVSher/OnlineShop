using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using System.Linq;

namespace OnlineShopWebApp.Areas.Admin.Controllers
{
    [Area(Constants.AdminRoleName)]
    [Authorize(Roles = Constants.AdminRoleName)]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;        

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;            
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles.Select(x=>x.Name).ToList());
        }
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRole(string name)
        {
            if (_roleManager.FindByNameAsync(name).Result != null)
            {
                ModelState.AddModelError("", "Такая роль уже существует");
            }
            if (!string.IsNullOrEmpty(name))
            {
                IdentityResult result = _roleManager.CreateAsync(new IdentityRole(name)).Result;
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
            return View(name);            
        }
        public IActionResult RemoveRole(string name)
        {
            IdentityRole role = _roleManager.FindByNameAsync(name).Result;
            if (role != null)
            {
                _roleManager.DeleteAsync(role).Wait();
            }
            return RedirectToAction("Index");
        }
    }
}
