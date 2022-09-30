using YukselenWebAPI.BL.Repositories.Question;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Question
{
    public class QuestionReadRepository : ReadRepository<EntityLayer.Entities.Question>, IQuestionReadRepository
    {
        public QuestionReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
