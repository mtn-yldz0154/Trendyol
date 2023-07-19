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
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order, Context>, IOrderRepository
    {
        public List<Order> GetOrders(string userId)
        {
            using (var db=new Context())
            {
            var orders= db.Orders.Include(i=>i.OrderItems).ThenInclude(i=>i.Product).Where(i=>i.UserId == userId).ToList();
                return orders;
            }
        }
    }
}
