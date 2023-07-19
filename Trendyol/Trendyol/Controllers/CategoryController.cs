using DataAccessLayer.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Trendyol.Controllers
{
    public class CategoryController : Controller
    {

        public CategoryController() { 
        
        
        }
        public IActionResult Reyon(int id)
        {

            using (var db=new Context())
            {
               var products= db.Products.Where(i => i.CategoryId == id).ToList();

                ViewBag.id=db.Categories.Where(i=>i.Id==id).Select(i=>i.CategoryName).FirstOrDefault();
                var prd = db.Products.Where(i => i.CategoryId == id && i.ProductName == "Gömlek").Select(i=>i.ProductName).FirstOrDefault();
                ViewBag.name = prd;

               
                return View(products);
            }

            
        }
    }
}
