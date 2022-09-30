using YukselenWebAPI.BL.Repositories.AnswersQuestions;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersQuestions
{
    public class AnswersQuestionsReadRepository : ReadRepository<EntityLayer.Entities.AnswersQuestions>, IAnswersQuestionsReadRepository
    {
        public AnswersQuestionsReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
