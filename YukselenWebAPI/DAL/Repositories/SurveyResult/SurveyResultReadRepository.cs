using YukselenWebAPI.BL.Repositories.SurveyResult;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.SurveyResult
{
    public class SurveyResultReadRepository : ReadRepository<EntityLayer.Entities.SurveyResult>, ISurveyResultReadRepository
    {
        public SurveyResultReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
