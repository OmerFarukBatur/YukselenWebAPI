using YukselenWebAPI.BL.Repositories.Formlar;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Formlar
{
    public class FormlarReadRepository : ReadRepository<EntityLayer.Entities.Formlar>, IFormlarReadRepository
    {
        public FormlarReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
