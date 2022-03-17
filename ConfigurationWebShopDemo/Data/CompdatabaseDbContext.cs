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
    }
}
