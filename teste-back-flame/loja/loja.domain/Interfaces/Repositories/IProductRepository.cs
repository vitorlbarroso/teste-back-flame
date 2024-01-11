using loja.domain.Entities.Enums;
using loja.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Products GetByID(int produtoID);
        IEnumerable<Products> GetAll();
        IEnumerable<Products> GetAll(bool status);
        bool Save(Products produto);
        bool Update(Products produto);

    }
}
