using Microsoft.EntityFrameworkCore;
using YukselenWebAPI.BL.Repositories;
using YukselenWebAPI.DAL.Context;
using YukselenWebAPI.EntityLayer.Entities.Common;

namespace YukselenWebAPI.DAL.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly YukselenDBContext _context;

        public WriteRepository(YukselenDBContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T model)
        {
            await _context.AddAsync(model);
            _context.SaveChanges();
        }

        public async Task AddRangeAsync(List<T> datas)
        {
            await _context.AddRangeAsync(datas);
            _context.SaveChanges();
        }

        public void Remove(T model)
        {
            _context.Remove(model);
            _context.SaveChanges();
        }
        public void RemoveRange(List<T> datas)
        {
            _context.RemoveRange(datas);
            _context.SaveChanges();
        }

        public void Update(T model)
        {
            _context.Update(model);
            _context.SaveChanges();
        }
    }
}
