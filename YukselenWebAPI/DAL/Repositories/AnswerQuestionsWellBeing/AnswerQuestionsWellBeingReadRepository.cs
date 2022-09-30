using YukselenWebAPI.BL.Repositories.AnswerQuestionsWellBeing;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswerQuestionsWellBeing
{
    public class AnswerQuestionsWellBeingReadRepository : ReadRepository<EntityLayer.Entities.AnswerQuestionsWellBeing>, IAnswerQuestionsWellBeingReadRepository
    {
        public AnswerQuestionsWellBeingReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
