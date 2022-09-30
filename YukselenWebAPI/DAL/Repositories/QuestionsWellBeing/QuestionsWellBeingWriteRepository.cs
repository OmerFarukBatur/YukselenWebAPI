using YukselenWebAPI.BL.Repositories.QuestionsWellBeing;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.QuestionsWellBeing
{
    public class QuestionsWellBeingWriteRepository : WriteRepository<EntityLayer.Entities.QuestionsWellBeing>, IQuestionsWellBeingWriteRepository
    {
        public QuestionsWellBeingWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
