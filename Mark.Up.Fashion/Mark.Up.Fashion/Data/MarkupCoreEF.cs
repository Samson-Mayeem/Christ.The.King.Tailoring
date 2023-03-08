using Mark.Up.Fashion.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark.Up.Fashion.Data
{
    public class MarkupCoreEF
    {
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Cart> Cart { get; set; }
            public DbSet<Category> Categories { set; get; }
            public DbSet<Products> Products { set; get; }
            public DbSet<Purchases> Purchases { get; set; }
        }
    }
}
