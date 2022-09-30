using YukselenWebAPI.BL.Repositories.QuestionsWellBeing;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.QuestionsWellBeing
{
    public class QuestionsWellBeingReadRepository : ReadRepository<EntityLayer.Entities.QuestionsWellBeing>, IQuestionsWellBeingReadRepository
    {
        public QuestionsWellBeingReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
