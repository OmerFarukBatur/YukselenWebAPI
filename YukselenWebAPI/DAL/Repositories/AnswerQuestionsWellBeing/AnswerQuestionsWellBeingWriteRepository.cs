using YukselenWebAPI.BL.Repositories.AnswerQuestionsWellBeing;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswerQuestionsWellBeing
{
    public class AnswerQuestionsWellBeingWriteRepository : WriteRepository<EntityLayer.Entities.AnswerQuestionsWellBeing>, IAnswerQuestionsWellBeingWriteRepository
    {
        public AnswerQuestionsWellBeingWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
