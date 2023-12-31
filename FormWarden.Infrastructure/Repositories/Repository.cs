﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FormWarden.Infrastructure.Repositories
{
    public class Repository<TEntity, TKey>
        where TEntity : class
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
            => _dbContext.Set<TEntity>();

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> predicate)
            => _dbContext.Set<TEntity>().Where(predicate);

        public TEntity? FindFirst(Expression<Func<TEntity, bool>> predicate)
            => _dbContext.Set<TEntity>().FirstOrDefault(predicate);

        public async Task<TEntity?> GetByIdAsync(TKey id)
            => await _dbContext.Set<TEntity>().FindAsync(id);

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entityEntry = await _dbContext.Set<TEntity>().AddAsync(entity);
            return entityEntry.Entity;
        }

        public TEntity Update(TEntity entity)
        {
            var entityEntry = _dbContext.Set<TEntity>().Update(entity);
            return entityEntry.Entity;
        }

        public TEntity Remove(TKey id)
        {
            var entity = GetByIdAsync(id).Result;
            var entityEntry = _dbContext.Set<TEntity>().Remove(entity!);
            return entityEntry.Entity;
        }
    }
}
