using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void Create(Product entity);
      
        void Delete(int id);
        void Update(Product entity);
        Product GetById(int id);
        Product GetByIds(int id);
        List<Product> GetAll();
        List<Product> GetAlls();
    
    }
}
