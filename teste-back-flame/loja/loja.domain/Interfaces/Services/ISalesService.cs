using loja.domain.Entities;
using loja.domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces.Services
{
    public interface ISalesService
    {
        IEnumerable<Sales> GetAll();
        Sales GetByID(int salesID);
        IEnumerable<Sales> GetAll(Status status);
        bool Save(Sales sales);
        bool Update(Sales sales);
    }
}
