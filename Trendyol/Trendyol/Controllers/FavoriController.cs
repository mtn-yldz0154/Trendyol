using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Trendyol.Identity;

namespace Trendyol.Controllers
{
    [Authorize]
    public class FavoriController : Controller
    {
        private IFavoriService _favoriService;
        private UserManager<User> _userManager;
        private IProductService productService;
        public FavoriController(IFavoriService favoriService, UserManager<User> userManager, IProductService productService)
        {
            _userManager = userManager;
            _favoriService = favoriService;
            this.productService = productService;
        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var favori=_favoriService.GetFavoriByUserId(userId);
            return View(favori);
        }

        public IActionResult AddToFavoris(int productId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _favoriService.AddToFavori(userId, productId, quantity);
            return RedirectToAction("Index");
        }
    }
}
