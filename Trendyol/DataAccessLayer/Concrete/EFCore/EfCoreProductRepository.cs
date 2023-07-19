using DataAccessLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EFCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, Context>, IProductRepository
    {
        public List<Product> GetAlls()
        {
            using (var db = new Context())
            {
               var prd=  db.Products.Include(i=>i.Category).ToList();
                return prd;

            }
        }

        public Product GetByIds(int id)
        {
            using (var db = new Context())
            {
                var prd = db.Products.Include(i => i.Category).Where(i=>i.Id==id).FirstOrDefault();
                return prd;

            }
        }
    }
}
