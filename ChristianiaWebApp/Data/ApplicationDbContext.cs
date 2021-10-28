using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ChristianWebApp.Models;

namespace ChristianWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ChristianWebApp.Models.Assignment> Assignment { get; set; }
        public DbSet<ChristianWebApp.Models.Animal> Animal { get; set; }
    }
}
