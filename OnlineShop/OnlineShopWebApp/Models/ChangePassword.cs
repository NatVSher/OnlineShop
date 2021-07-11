using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class ChangePassword
    {
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4)]
        public string NewPassword { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 4)]      
        public string ConfirmPassword { get; set; }
    }
}
