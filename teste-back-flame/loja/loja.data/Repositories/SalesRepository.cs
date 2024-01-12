
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
            return _context.Sales.Include(p => p.Produto);
        }
        public IEnumerable<Sales> GetAll(Status status)
        {
         
            return _context.Sales.Include(p => p.Produto).Where(p => p.Status.Equals(status));
         
           
        }

        public Sales GetByID(int salesID)
        {
           return  _context.Sales.Include(p => p.Produto).Where(p => p.Id.Equals(salesID)).FirstOrDefault();
           
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
