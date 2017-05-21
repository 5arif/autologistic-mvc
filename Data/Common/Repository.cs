using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoLogistic.Models.History;

namespace AutoLogistic.Data.Common
{
    public class Repository<T> : IRepository<T> where T : RowHistory
    {
        private readonly DbSet<T> _dbSet;

        public readonly ApplicationDbContext Context;
        
        public Repository(ApplicationDbContext context)
        {
            Context = context;
            _dbSet = Context.Set<T>();
        }
        
        public virtual void Create(T entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.IsDelete = false;
            entity.ModifyCount = 0;

            _dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Added;
        }

        public virtual void Update(T entity)
        {
            entity.ModifyDate = DateTime.Now;
            entity.IsDelete = false;
            entity.ModifyCount = entity.ModifyCount ++;

            _dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            //soft delete
            entity.DeleteDate = DateTime.Now;
            entity.ModifyDate = DateTime.Now;
            entity.IsDelete = true; 
            entity.ModifyCount = entity.ModifyCount++;

            _dbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GetQuery()
        {
            return _dbSet;
        }

        public T Single(Expression<Func<T, bool>> where)
        {
            return _dbSet.FirstOrDefault(where);
        }

        public T First(Func<T, bool> where)
        {
            return _dbSet.FirstOrDefault(where);
        }

        public virtual T Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }

        public virtual async Task<T> FindAsync(params object[] keyValues)
        {
            return await _dbSet.FindAsync(keyValues);
        }

        public IEnumerable<T> GetAll()
        {
            return GetQuery().ToList();
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await GetQuery().ToListAsync();
        }
    }
}
