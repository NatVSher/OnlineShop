using OnlineShopWebApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace OnlineShopWebApp.Extension
{
    public static class OrderStatusesExtension
    {
        public static string GetDisplayName(this OrderStatusesViewModel enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
    }
}
