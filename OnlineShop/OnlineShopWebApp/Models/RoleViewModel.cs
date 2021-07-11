using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class RoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<string> AllRoles { get; set; }
        public List<string> UserRoles { get; set; }
        public RoleViewModel()
        {
            AllRoles = new List<string>();
            UserRoles = new List<string>();
        }
    }
}
