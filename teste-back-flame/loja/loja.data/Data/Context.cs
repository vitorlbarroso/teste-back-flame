using loja.data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Data
{
    public class Context:DbContext
    {
        string conectionStringMySql = "Server=localhost;Port=3306;initial catalog=lojaflame;uid=root;pwd=007987Pq";
       

        public Context(DbContextOptions options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(conectionStringMySql, ServerVersion.Parse("8.2.0 - MySQL Community Server"));
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }

    }
}
