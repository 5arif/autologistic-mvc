using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AutoLogistic.Data.Common
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        IQueryable<T> GetQuery();

        T Single(Expression<Func<T, bool>> where);

        T First(Func<T, bool> where);

        T Find(params object[] keyValues);

        Task<T> FindAsync(params object[] keyValues);

        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAsync();
    }
}
