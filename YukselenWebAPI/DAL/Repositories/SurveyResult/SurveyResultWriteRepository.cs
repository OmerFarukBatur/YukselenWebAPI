using YukselenWebAPI.BL.Repositories.SurveyResult;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.SurveyResult
{
    public class SurveyResultWriteRepository : WriteRepository<EntityLayer.Entities.SurveyResult>, ISurveyResultWriteRepository
    {
        public SurveyResultWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
