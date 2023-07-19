using DataAccessLayer.Concrete.EFCore;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Trendyol.Identity;

namespace Trendyol.Controllers
{
    public class CommentController : Controller
    {
        private UserManager<User> _userManager;
        public CommentController(UserManager<User> userManager) {
        _userManager= userManager;

        }

        public IActionResult Comment(int id)
        {
            using (var db=new Context())
            {
            var comment= db.Comment.Where(i=>i.ProductId== id);
                return View(comment);
            }

            
        }

        [HttpPost]
        public IActionResult LikeComment(int id,int commentId)
        {
            using (var db=new Context())
            {
                var userId = _userManager.GetUserId(User);
                var commenLike = new CommentLike()
                {
                    CommentId= commentId,
                    UserId= userId,
                    ProductId=id,
                    MyProperty=1
                };

                db.CommentLikes.Add(commenLike);
                db.SaveChanges();

            }

            return Redirect("/product/details/" + id);
        }
    }
}
