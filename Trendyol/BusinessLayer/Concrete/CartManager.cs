using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;
        public CartManager(ICartRepository cartRepository) { 
        _cartRepository= cartRepository;
        }
        public void InitilazerCart(string userId)
        {
            _cartRepository.Create(new Cart { UserId = userId });
        }
   

        public void AddToCart(string userId, int productId, int quantity,string size)
        {

            

            var cart = GetCartByUserId(userId);

            var index = cart.CartItems.FindIndex(i => i.ProductId == productId);

            if (index < 0)
            {
                using (var db = new Context())
                {
                    var urun = new CartItem()
                    {
                        CartId = cart.Id,
                        ProductId = productId,
                        Quantity = quantity,
                        Size = size

                    };

                    db.CartItems.Add(urun);
                    db.SaveChanges();
                }


            }

            else
            {
                using (var db=new Context())
                {
                  var prd= db.CartItems.Where(i=>i.ProductId==productId).FirstOrDefault();
                    prd.Quantity += quantity;
                    db.SaveChanges();
                }
              
                
            }

        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cart = GetCartByUserId(userId);

            _cartRepository.DeleteFromCart(cart.Id, productId);
        }

        public Cart GetCartByUserId(string userId)
        {
            return _cartRepository.GetCartByUserId(userId);
        }

        public void ClearCart(int cartId)
        {
           _cartRepository.ClearCart(cartId);
        }

        public void AddAddres(Adress adress)
        {
            _cartRepository.AddAddres(adress);
        }
    }
}
