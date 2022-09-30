using YukselenWebAPI.BL.Repositories.Answers;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Answer
{
    public class AnswerWriteRepository : WriteRepository<EntityLayer.Entities.Answer>, IAnswerWriteRepository
    {
        public AnswerWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
