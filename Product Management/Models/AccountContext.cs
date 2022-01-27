using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_Management.Models
{
    public class AccountContext:DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options) { }
        public DbSet<UserViewModel> User { get; set; }
        public DbSet<ProductViewModel> Product { get; set; }
        public DbSet<CategoryViewModel> Category { get; set; }

    }
}
