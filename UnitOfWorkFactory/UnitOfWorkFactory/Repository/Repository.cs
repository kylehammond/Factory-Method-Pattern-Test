using System;
using System.Linq.Expressions;
using UnitOfWorkFactory.Entities;
using UnitOfWorkFactory.EntityFramework;

namespace UnitOfWorkFactory.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T : IEntity
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Dispose()
        {
            _appDbContext?.Dispose();
        }

        public void Create(T t)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Get(T t)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetAll(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Upsert(int id, T t)
        {
            throw new NotImplementedException();
        }

        public void Upsert(T t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T t)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}