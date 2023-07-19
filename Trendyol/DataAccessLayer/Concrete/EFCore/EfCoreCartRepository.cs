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
    public class EfCoreCartRepository:EfCoreGenericRepository<Cart,Context>,ICartRepository
    {
        public override void Update(Cart entity)
        {
            using (var context = new Context())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }

        public Cart GetCartByUserId(string userId)
        {
            using (var context = new Context())
            {
                return context.Carts.Include(i => i.CartItems).ThenInclude(i => i.Product).FirstOrDefault(i => i.UserId == userId);
            }
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var db=new Context())
            {
                var cartItem=db.CartItems.Where(i=>i.CartId==cartId&& i.ProductId==productId).FirstOrDefault();
cartItem.StatusVisibilty=true;
                db.SaveChanges();
            }
        }

       public void ClearCart(int cartId)
        {
            using (var db=new Context())
            {
                var cmd = @"delete from CartItems where CartId=@p0";
                db.Database.ExecuteSqlRaw(cmd, cartId);
            }
          
        }

        public void AddAddres(Adress adress)
        {
            using (var db=new Context())
            {
                db.Adresses.Add(adress);
                db.SaveChanges();

            }
        }
    }
}
