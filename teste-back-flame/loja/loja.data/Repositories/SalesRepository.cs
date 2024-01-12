
using loja.data.Data;
using loja.domain.Entities;
using loja.domain.Entities.Enums;
using loja.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        public Context _context;
        public SalesRepository(Context context)
        {
            _context = context;
        }
        
        public IEnumerable<Sales> GetAll()
        {
            return _context.Sales;
        }
        public IEnumerable<Sales> GetAll(Status status)
        {
            var retorno= _context.Sales.Include(p => p.Produto).Where(p => p.Status.Equals(status));
         
            return retorno;
        }

        public Sales GetByID(int salesID)
        {
           var retorno=  _context.Sales.Where(p => p.Id.Equals(salesID)).FirstOrDefault();
           if(retorno is not null)
              _context.Entry(retorno).Reference(p => p.Produto).Load();
            return retorno;

        }

        public bool Save(Sales sales)
        {

             _context.Sales.Add(sales);
            return _context.SaveChanges() == 1 ? true : false;
        }

        public bool Update(Sales sales)
        {
           _context.Sales.Update(sales);
            return _context.SaveChanges() == 1 ? true : false;
        }
    }
}
