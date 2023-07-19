using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IFavoriRepository:IGenericRepository<Favori>
    {
       

        Favori GetFavoriByUserId(string userId);

        void AddToFavori(string userId, int productId, int quantity);
        void DeleteFromFavori(string userId, int productId);
    }
}
