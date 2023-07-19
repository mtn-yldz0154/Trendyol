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
    public class QuestionsManager : IQuestionsService
    {

        private IQuestionsRepository _questionsRepository;
        public QuestionsManager( IQuestionsRepository questionsRepository) {
        _questionsRepository=questionsRepository;
        }

        public void AddAnswer(string answer, int questionsId, int productId, DateTime date)
        {
            _questionsRepository.AddAnswer(answer, questionsId, productId, date);
        }

        public void AddQuestions(string questions, string userId, int productId, string userName, DateTime date)
        {
            _questionsRepository.AddQuestions(questions, userId, productId,userName,date);
        }

        public List<AnswerQuestions> GetAnswerQuestions(int id)
        {
            return _questionsRepository.GetAnswerQuestions(id);
        }

        public List<Questions> GetQuestions(int id)
        {
            return _questionsRepository.GetQuestions(id);
        }

         
    }
}
