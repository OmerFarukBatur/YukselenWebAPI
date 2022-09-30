using YukselenWebAPI.BL.Repositories.Answers;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Answer
{
    public class AnswerReadRepository : ReadRepository<EntityLayer.Entities.Answer>, IAnswerReadRepository
    {
        public AnswerReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
