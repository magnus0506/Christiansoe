using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Christiansoe.Models;

namespace Christiansoe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Christiansoe.Models.Assignment> Assignment { get; set; }
        public DbSet<Christiansoe.Models.Animal> Animal { get; set; }
        public DbSet<Christiansoe.Models.History> History { get; set; }
        public DbSet<Christiansoe.Models.Route> Route { get; set; }
    }
}
