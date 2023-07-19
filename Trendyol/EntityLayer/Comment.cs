using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string CommentText  { get; set; }
        public string UserId  { get; set; }
        public string UserName  { get; set; }
        public string UserSurname  { get; set; }
        public int LikeNumber  { get; set; }
        public DateTime DateComment   { get; set; }


    }
}
