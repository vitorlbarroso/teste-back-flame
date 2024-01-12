using loja.domain.Entities;
using loja.domain.Entities.Enums;
using loja.domain.Interfaces.Repositories;
using loja.domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Services
{
    public class SalesService : ISalesService
    {
        public ISalesRepository _SalesRepository;
        public SalesService(ISalesRepository SalesRepository)
        {
            _SalesRepository = SalesRepository;
        }
        
        public IEnumerable<Sales> GetAll()
        {
            return _SalesRepository.GetAll();
        }

        public IEnumerable<Sales> GetAll(Status status)
        {
          
            return _SalesRepository.GetAll(status);
        }

        public Sales GetByID(int produtoID)
        {
            return _SalesRepository.GetByID(produtoID);
        }

        public bool Save(Sales produto)
        {
            return _SalesRepository.Save(produto);
        }

        public bool Update(Sales produto)
        {
            return _SalesRepository.Update(produto);
        }     
    }
}
