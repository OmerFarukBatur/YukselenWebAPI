using YukselenWebAPI.BL.Repositories.User;
using YukselenWebAPI.DAL.Context;

namespace YukselenWebAPI.DAL.Repositories.User
{
    public class UserReadRepository : ReadRepository<EntityLayer.Entities.Users>, IUserReadRepository
    {
        public UserReadRepository(YukselenDBContext context) : base(context)
        {
        }
    }
}
