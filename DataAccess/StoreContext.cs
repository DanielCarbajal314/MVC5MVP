using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StoreContext:DbContext
    {
        public StoreContext() : base("StoreDB"){

        }

        public DbSet<Product> Products { get; set; }
    }
}
