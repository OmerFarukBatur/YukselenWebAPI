using YukselenWebAPI.BL.Repositories.Question;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Question
{
    public class QuestionWriteRepository : WriteRepository<EntityLayer.Entities.Question>, IQuestionWriteRepository
    {
        public QuestionWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
