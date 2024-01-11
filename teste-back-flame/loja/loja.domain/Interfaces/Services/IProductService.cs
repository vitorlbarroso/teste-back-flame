using loja.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces.Services
{
    public interface IProductService
    {
        IEnumerable<Products> GetAll();
        Products GetByID(int produtoID);
        IEnumerable<Products> GetAll(bool? status);
        bool Save(Products produto);
        bool Update(Products produto);
    }
}
