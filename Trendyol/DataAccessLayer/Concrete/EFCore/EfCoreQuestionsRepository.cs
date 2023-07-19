using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EFCore
{
    public class EfCoreQuestionsRepository : EfCoreGenericRepository<Questions, Context>, IQuestionsRepository
    {
        public void AddAnswer(string answer, int questionsId, int productId, DateTime date)
        {
            using (var db=new Context())
            {
                var answera = new AnswerQuestions()
                {
                    Answer=answer,
                    QuestionsId=questionsId,
                    ProductId=productId,
                    Date=date,
                    Name="Larabey"
                };

                db.Answer.Add(answera);
                db.SaveChanges();
            }
        }

        public void AddQuestions(string questions, string userId, int productId, string userName, DateTime date)
        {
            using (var db=new Context())
            {
                var question = new Questions()
                {
                    DateQuestions=date,
                    TextQuestions=questions,
                    UserId=userId,
                   UserName=userName,
                   Prd=productId
                };

                db.Questions.Add(question);
                db.SaveChanges();
            }
        }

        public List<AnswerQuestions> GetAnswerQuestions(int id)
        {
            using (var db=new Context())
            {
                return db.Answer.Where(i => i.ProductId == id).ToList();
            }
        }

        public List<Questions> GetQuestions(int id)
        {
            using (var db = new Context())
            {

                return db.Questions.Where(i=>i.Prd==id).ToList();
            }
        }
    }
}
