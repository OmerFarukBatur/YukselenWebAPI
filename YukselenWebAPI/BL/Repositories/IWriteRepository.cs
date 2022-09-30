using System.Collections.Generic;
using System.Threading.Tasks;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.BL.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task AddAsync(T model);
        Task AddRangeAsync(List<T> datas);
        void Remove(T model);
        void RemoveRange(List<T> datas);
        //Task<bool> RemoveAsync(int id);
        void Update(T model);
        //Task<int> SaveAsync();
    }
}
