using YukselenWebAPI.BL.Repositories.AnswersDetails;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersDetails
{
    public class AnswersDetailsReadRepository : ReadRepository<EntityLayer.Entities.AnswersDetails>, IAnswersDetailsReadRepository
    {
        public AnswersDetailsReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
