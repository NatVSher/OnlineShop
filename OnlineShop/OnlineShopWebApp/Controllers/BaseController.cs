using Microsoft.AspNetCore.Mvc;
using OnlineShop.Db;
using System;

namespace OnlineShopWebApp.Controllers
{
    public class BaseController : Controller
    {        
        protected string GetUserId()
        {
            if (!User.Identity.IsAuthenticated)
            {
                if (!Request.Cookies.ContainsKey(Constants.UserId))
                {
                    var unauthorizedUserId = Guid.NewGuid().ToString();
                    Response.Cookies.Append(Constants.UserId, unauthorizedUserId);
                    return unauthorizedUserId;
                }
                return Request.Cookies[Constants.UserId];
            }
            return User.Identity.Name;
        }
    }
}
