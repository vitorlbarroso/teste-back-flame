using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Update(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
