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
    public class FavoriManager : IFavoriService
    {
        private IFavoriRepository _favoriRepository;

        public FavoriManager(IFavoriRepository favoriRepository)
        {
            _favoriRepository = favoriRepository;
        }

        public void AddToFavori(string userId, int productId, int quantity)
        {
             _favoriRepository.AddToFavori(userId, productId, quantity);
        }

        public void DeleteFromFavori(string userId, int productId)
        {
            _favoriRepository.DeleteFromFavori(userId, productId);
        }

        public Favori GetFavoriByUserId(string userId)
        {
           return  _favoriRepository.GetFavoriByUserId(userId);
        }

        public void InitilazerFavori(string userId)
        {
            _favoriRepository.Create(new Favori { UserId=userId});
        }
    }
}
