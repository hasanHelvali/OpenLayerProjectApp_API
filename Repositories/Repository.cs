using BasarSoftProject1_API.Context;
using BasarSoftProject1_API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BasarSoftProject1_API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MapContext _context;

        public Repository(MapContext context)
        {
            this._context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
