using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.Service
{
    public abstract class CommonService<TEntity> : ICommonService<TEntity> where TEntity : class
    {
        protected readonly IGenericRepository<TEntity> _repository;

        public CommonService()
        {
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _repository.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
        }
    }
}
