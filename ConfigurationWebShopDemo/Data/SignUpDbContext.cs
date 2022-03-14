using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationWebShopDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationWebShopDemo.Data
{
    public class SignUpDbContext :DbContext
    {
        public SignUpDbContext(DbContextOptions<SignUpDbContext> options) : base(options)
        {

        }
        public DbSet<SignUp> SignUp { get; set; }
    }
}
