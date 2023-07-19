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
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddComment(string Comment, string userId, string userName, int productId, DateTime date)
        {
            _commentRepository.AddComment(Comment, userId, userName, productId, date);
        }

        public List<Comment> GetComments(int id)
        {
           return  _commentRepository.GetComment(id);
        }
    }
}
