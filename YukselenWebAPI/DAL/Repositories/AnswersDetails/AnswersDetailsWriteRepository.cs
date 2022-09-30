using YukselenWebAPI.BL.Repositories.AnswersDetails;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersDetails
{
    public class AnswersDetailsWriteRepository : WriteRepository<EntityLayer.Entities.AnswersDetails>, IAnswersDetailsWriteRepository
    {
        public AnswersDetailsWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
