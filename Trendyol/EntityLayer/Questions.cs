using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Questions
    {
        public int Id { get; set; }
        public int Prd { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }

        public string TextQuestions { get; set; }
        public DateTime DateQuestions { get; set; }
    }
}
