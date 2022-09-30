using YukselenWebAPI.BL.Repositories.User;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.User
{
    public class UserWriteRepository : WriteRepository<EntityLayer.Entities.Users>, IUserWriteRepository
    {
        public UserWriteRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
