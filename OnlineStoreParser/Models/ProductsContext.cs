using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineStoreParser.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("ProductsContext") {            
        }

        virtual public DbSet<Product> Products { get; set; }
        virtual public DbSet<Photo> Photos { get; set; }
        virtual public DbSet<HistoryEntry> History { get; set; }
    }
}