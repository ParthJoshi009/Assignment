using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RegistrationAndLogin.Models
{
    public class UserLogin
    {
         [Required]
         public String Email { get; set; }

         [Required]
         public String Password { get; set; }
    }
}