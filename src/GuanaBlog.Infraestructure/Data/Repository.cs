using GuanaBlog.Core.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GuanaBlog.Infraestructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void AddAsync(T entity, string CancelationToken = null)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IList<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> ListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null, string IncludeProperties = "")
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}
