using HotelResrvation.Models;
using HotelResrvation.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelResrvation.Data
{
    public class ReservationDBContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ReservationDBContext(DbContextOptions options)
            : base(options)
        {
            
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
         public DbSet<ApplicationRole> ApplicationRoles { get; set; }


    }
}
