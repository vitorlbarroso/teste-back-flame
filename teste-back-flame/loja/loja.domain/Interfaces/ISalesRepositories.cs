using loja.data.Models;
using loja.data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces
{
    public interface IsalesRepository
    {
        Products GetByID(int produtoID);
        IList<Products> GetAll();
        IList<Products> GetAllByStatus(Status status);
        bool Save(Products produto);
        bool Update(Products produto);
              
    }
}
