
using System.Linq.Expressions;

namespace GuanaBlog.Core.UseCases.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// List all the entities already exist in the datasource
        /// </summary>
        /// <returns> a List of entities of requered type </returns>
        public Task<IList<T>> ListAllAsync();
     
        /// <summary>
        /// Get a instance of a entity filter by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        
        public Task<T> GetByIdAsync(int id);
        /// <summary>
        /// Get all the elements that match on the filter<Qery> </Qery>
        /// Also provide the ordered entry set, and include properties to include join on queries are allowed.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="OrderBy"></param>
        /// <param name="IncludeProperties"></param>
        /// <returns></returns>
        public Task<IList<T>> ListAsync(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null, string IncludeProperties = "");
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="CancelationToken"></param>
        public void AddAsync(T entity, string CancelationToken = null);  
        public void AddRange(IList<T> entities);
        public void Update(T entity);   
        public void Delete(T entity);
        public void DeleteAll();    
    }
}
