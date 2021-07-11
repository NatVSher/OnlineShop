using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Db.Models;
using OnlineShopWebApp.Models;
using System;

namespace OnlineShopWebApp.Views.Shared.Components.Profile
{
    public class IconUserAvatarViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;
        private readonly IMemoryCache cache;
        private readonly IMapper mapper;

        public IconUserAvatarViewComponent(UserManager<User> userManager, IMemoryCache cache, IMapper mapper)
        {
            _userManager = userManager;
            this.cache = cache;
            this.mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            if (userName != null)
            {
                UserAvatarViewModel userAvatar = null;
                //если в кэше объект с ключем userName не существует
                if (!cache.TryGetValue(userName, out userAvatar))
                {
                    //получаем его из базы данных и конвертируем в UserAvatarViewModel
                    var user = _userManager.FindByNameAsync(userName).Result;
                    userAvatar = mapper.Map<UserAvatarViewModel>(user);
                    if (userAvatar != null)
                    {
                        //добавляем в кэш на 30 мин
                        cache.Set(userName, userAvatar,
                            new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
                    }
                }
                //Если ключ в кэше был найден, то в объект userAvatar передается извлекаемое из кэша значение
                return View("IconUserAvatar", userAvatar);
            }
            return null;
        }
    }
}
