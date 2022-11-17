﻿using Microsoft.EntityFrameworkCore;
using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.InfraStructure.Data.Context;

namespace webAdmin.InfraStructure.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public TEntity Add(TEntity obj)
        {
            _dataContext.Set<TEntity>().AddRange(obj);
            _dataContext.SaveChanges();

            return obj;
        }
        public IQueryable<TEntity> GetAll()
        {
            return _dataContext.Set<TEntity>().AsNoTracking();
        }
        public TEntity? GetById(object id)
        {
            return _dataContext.Set<TEntity>().Find(id);
        }
        public void Remove(TEntity obj)
        {
            _dataContext.Set<TEntity>().Remove(obj);
            _dataContext.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            _dataContext.Entry(obj).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }
        public virtual void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
