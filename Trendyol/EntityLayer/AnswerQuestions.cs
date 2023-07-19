using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnswerQuestions
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string Name { get; set; }
        public int QuestionsId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
    }
}
