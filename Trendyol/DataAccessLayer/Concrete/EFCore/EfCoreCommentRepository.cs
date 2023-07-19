using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EFCore
{
    public class EfCoreCommentRepository :EfCoreGenericRepository<Comment,Context>, ICommentRepository
    {
        public void AddComment(string Comment, string userId, string userName, int productId, DateTime date)
        {
            using (var db=new Context())
            {
                var comment = new Comment
                {
                    CommentText = Comment,
                    UserId = userId,
                    UserName = userName,
                    ProductId = productId,
                    DateComment = date,
                };

                db.Comment.Add(comment);
                db.SaveChanges();
            }
        }

        public List<Comment> GetComment(int id)
        {
            using (var db=new Context())
            {
                var comments= db.Comment.Where(i=>i.ProductId==id).ToList();
                return comments;
            }
        }
    }
}
