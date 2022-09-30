using YukselenWebAPI.BL.Repositories.Formlar;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.Formlar
{
    public class FormlarWriteRepository : WriteRepository<EntityLayer.Entities.Formlar>, IFormlarWriteRepository
    {
        public FormlarWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
