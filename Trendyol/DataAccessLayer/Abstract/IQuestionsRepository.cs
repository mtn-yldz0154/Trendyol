using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IQuestionsRepository
    {
        void AddQuestions(string questions, string userId, int productId, string userName, DateTime date);

        List<AnswerQuestions> GetAnswerQuestions(int id);

        void AddAnswer(string answer, int questionsId, int productId, DateTime date);
        List<Questions> GetQuestions(int id);
    }
}
