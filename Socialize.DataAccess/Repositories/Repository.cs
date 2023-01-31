using Microsoft.EntityFrameworkCore;
using Socialize.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> dbSet;
        public Repository(DbSet<T> dbSet)
        {
            this.dbSet = dbSet;
        }

        public async Task Add(T entity)
        {
            var result = await dbSet.AddAsync(entity);

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            return await dbSet.Where(filter).FirstOrDefaultAsync();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
