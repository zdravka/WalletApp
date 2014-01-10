using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WalletApp.Controllers
{
    public class LoginModel
    {
        [Required]
        [StringLength(10)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
