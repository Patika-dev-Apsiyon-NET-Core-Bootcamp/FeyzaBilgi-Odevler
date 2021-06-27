using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext _context;
        protected DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        public async Task<int> Add(TEntity entity)
        {

            _entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public int Delete(int id)
        {
            TEntity entity = _entities.FirstOrDefault(x => x.Id == id);
            if (entity == default) return -1;
            _entities.Remove(entity);
            return _context.SaveChanges();
        }

        //public List<TEntity> GetAll()
        //{
        //    return _entities.ToList();
        //}

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _entities.ToList()
                                  : _entities.Where(filter).ToList();
        }

        //public TEntity GetById(int id)
        //{
        //    return _entities.FirstOrDefault(x => x.Id == id);

        //}

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            return _entities.SingleOrDefault(filter);
        }

        public int Update(TEntity entity)
        {
            return _context.SaveChanges();
        }
    }
}
