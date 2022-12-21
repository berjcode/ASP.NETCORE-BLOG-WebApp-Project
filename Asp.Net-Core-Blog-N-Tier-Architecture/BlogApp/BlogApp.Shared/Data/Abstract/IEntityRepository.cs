using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        // T bir class olmalı ve newlenebilir olmalı. IEntityden implemente olması gerekir.
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties); //bir makale getir. filtreleme yap.

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate =null, params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);


        Task<int> CountAsync(Expression<Func<T, bool>> predicate);



    }
}
