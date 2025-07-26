using AdcData.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AdcData.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AdcDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(AdcDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
