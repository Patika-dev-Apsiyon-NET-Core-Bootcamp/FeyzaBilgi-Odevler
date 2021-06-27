using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity: IEntity
    {
        Task<int> Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(int id);
        TEntity GetById(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
