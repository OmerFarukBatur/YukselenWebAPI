using YukselenWebAPI.BL.Repositories.AnswersQuestions;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersQuestions
{
    public class AnswersQuestionsWriteRepository : WriteRepository<EntityLayer.Entities.AnswersQuestions>, IAnswersQuestionsWriteRepository
    {
        public AnswersQuestionsWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
