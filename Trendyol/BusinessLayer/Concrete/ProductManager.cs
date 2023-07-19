using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }


        public void Create(Product entity)
        {
           

               
           _productRepository.Create(entity);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public List<Product> GetAll()
        {
          return  _productRepository.GetAll();
        }

        public List<Product> GetAlls()
        {
          return  _productRepository.GetAlls();
        }

        public Product GetById(int id)
        {
          return     _productRepository.GetById(id);
        }

        public Product GetByIds(int id)
        {
            return _productRepository.GetByIds(id);
        }

      

        public void Update(Product entity)
        {
           _productRepository.Update(entity);
        }
    }
}
