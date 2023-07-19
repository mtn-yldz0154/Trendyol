using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetAlls();
        Product GetByIds(int id);
       
    }
}
