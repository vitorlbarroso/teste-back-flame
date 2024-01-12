
using loja.data.Data;
using loja.domain.Entities;
using loja.domain.Entities.Enums;
using loja.domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        
        public IEnumerable<Products> GetAll()
        {
            return _context.Products;
        }

        public IEnumerable<Products> GetAll(bool status)
        {
            return _context.Products.Where(p=>p.IsBlocked.Equals(status));
        }

        
        public Products GetByID(int produtoID)
        {
            return _context.Products.Where(p => p.Id.Equals(produtoID)).FirstOrDefault();
        }

        public bool Save(Products produto)
        {

             _context.Products.Add(produto);
            return _context.SaveChanges() == 1 ? true : false;
        }

        public bool Update(Products produto)
        {
           _context.Products.Update(produto);
            return _context.SaveChanges() == 1 ? true : false;
        }
    }
}
