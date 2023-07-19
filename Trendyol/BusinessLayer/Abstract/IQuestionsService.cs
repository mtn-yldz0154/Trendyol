using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface IQuestionsService
    {
        List<Questions> GetQuestions(int id);

        void AddQuestions(string questions,string userId,int productId,string userName,DateTime date);

        void AddAnswer(string answer, int questionsId, int productId, DateTime date);
        List<AnswerQuestions> GetAnswerQuestions(int id);

        
    }
}
