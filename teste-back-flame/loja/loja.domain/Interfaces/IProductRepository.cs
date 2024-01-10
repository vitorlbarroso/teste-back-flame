using loja.data.Models.Enums;
using loja.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces
{
    public interface IProductRepository 
    {
        Products GetByID(int produtoID);
        IList<Products> GetAll();
        IList<Products> GetAllByStatus(Status status);
        bool Save(Products produto);
        bool Update(Products produto);

    }
}
