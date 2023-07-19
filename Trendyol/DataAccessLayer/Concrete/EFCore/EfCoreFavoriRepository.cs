using DataAccessLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EFCore
{
    public class EfCoreFavoriRepository : EfCoreGenericRepository<Favori, Context>, IFavoriRepository
    {
        public void AddToFavori(string userId, int productId, int quantity)
        {
           

                var favori = GetFavoriByUserId(userId);

                var index = favori.FavoriItems.FindIndex(i => i.ProductId == productId);

                if (index < 0)
                {
                    using (var db = new Context())
                    {
                        var urun = new FavoriItem()
                        {
                            FavoriId = favori.Id,
                            ProductId = productId,
                            Quantity = quantity,
                         

                        };

                        db.FavoriItems.Add(urun);
                        db.SaveChanges();
                    }


                }
            else
            {
                using (var db = new Context())
                {
                    var prd = db.FavoriItems.Where(i => i.ProductId == productId).FirstOrDefault();
                    prd.Quantity += quantity;
                    db.SaveChanges();
                }


            }
        }

        public void DeleteFromFavori(string userId, int productId)
        {
            throw new NotImplementedException();
        }

        public Favori GetFavoriByUserId(string userId)
        {
            using (var db=new Context())
            {
                using (var context = new Context())
                {
                    return context.Favoris.Include(i => i.FavoriItems).ThenInclude(i => i.Product).FirstOrDefault(i => i.UserId == userId);
                }
            }
        }

       
    }
}
