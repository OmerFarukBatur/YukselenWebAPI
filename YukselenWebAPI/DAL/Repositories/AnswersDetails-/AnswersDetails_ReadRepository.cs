using YukselenWebAPI.BL.Repositories.AnswersDetails;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.AnswersDetails_
{
    public class AnswersDetails_ReadRepository : ReadRepository<EntityLayer.Entities.AnswersDetails_>, IAnswersDetails_ReadRepository
    {
        public AnswersDetails_ReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
