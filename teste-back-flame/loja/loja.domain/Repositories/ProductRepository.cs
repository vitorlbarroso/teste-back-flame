using loja.data.Data;
using loja.data.Models;
using loja.data.Models.Enums;
using loja.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IList<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Products> GetAllByStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public Products GetByID(int produtoID)
        {
            throw new NotImplementedException();
        }

        public bool Save(Products produto)
        {
            throw new NotImplementedException();
        }

        public bool Update(Products produto)
        {
            throw new NotImplementedException();
        }
    }
}
