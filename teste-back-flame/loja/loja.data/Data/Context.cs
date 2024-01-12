
using loja.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options) { }
       
      
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }

    }
}
