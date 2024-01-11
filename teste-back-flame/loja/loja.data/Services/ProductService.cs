using loja.domain.Entities;
using loja.domain.Interfaces.Repositories;
using loja.domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.data.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public IEnumerable<Products> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Products> GetAll(bool? status)
        {
            if (status is null) return _productRepository.GetAll();
            return _productRepository.GetAll((bool)status);
        }

        public Products GetByID(int produtoID)
        {
            return _productRepository.GetByID(produtoID);
        }

        public bool Save(Products produto)
        {
            return _productRepository.Save(produto);
        }

        public bool Update(Products produto)
        {
            return _productRepository.Update(produto);
        }
    }
}
