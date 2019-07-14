using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelResrvation.Models.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
