
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentRepository
    {
        List<Comment> GetComment(int id);

        void AddComment(string Comment,string userId,string userName,int productId,DateTime date);
    }
}
