using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationWebShopDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationWebShopDemo.Data
{
    public class CompdatabaseDbContext : DbContext
    {
        public CompdatabaseDbContext(DbContextOptions<CompdatabaseDbContext> options) : base(options)
        {

        }
        public DbSet<Configurations> Configurations { get; set; }

        public DbSet<CPUs> CPUs { get; set; }

        public DbSet<GPUs> GPUs { get; set; }

        public DbSet<HDDs> HDDs { get; set; }

        public DbSet<Mother_Boards> Mother_Boards { get; set; }

        public DbSet<RAMs> RAMs { get; set; }

        public DbSet<SSDs> SSDs { get; set; }
<<<<<<< Updated upstream
=======

        public DbSet<Product> Products { get; set; }
>>>>>>> Stashed changes
    }
}
