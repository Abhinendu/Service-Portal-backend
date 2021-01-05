using LaptopServicePortal_2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopServicePortal_2.Models
{
    public class NewContext : IdentityDbContext
    {
        public NewContext(DbContextOptions<NewContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }

   

}