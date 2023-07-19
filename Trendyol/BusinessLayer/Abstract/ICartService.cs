using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICartService
    {
        void ClearCart(int cartId);
        void InitilazerCart(string userId);

        Cart GetCartByUserId(string userId);

        void AddToCart(string userId, int productId, int quantity,string size);
        void DeleteFromCart(string userId, int productId);

        void AddAddres(Adress adress);
    }
}
