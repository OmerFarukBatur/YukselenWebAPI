using YukselenWebAPI.BL.Repositories.AnswersDetails;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersDetails_
{
    public class AnswersDetails_WriteRepository : WriteRepository<EntityLayer.Entities.AnswersDetails_>, IAnswersDetails_WriteRepository
    {
        public AnswersDetails_WriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
