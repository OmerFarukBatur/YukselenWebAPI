using Microsoft.EntityFrameworkCore;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.BL.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        public DbSet<T> Table { get; }
    }
}
