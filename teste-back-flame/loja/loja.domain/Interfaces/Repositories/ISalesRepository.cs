using loja.domain.Entities;
using loja.domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces.Repositories
{
    public interface ISalesRepository
    {
        Sales GetByID(int salesID);
        IEnumerable<Sales> GetAll();
        IEnumerable<Sales> GetAll(Status status);
        bool Save(Sales sales);
        bool Update(Sales sales);

    }
}
