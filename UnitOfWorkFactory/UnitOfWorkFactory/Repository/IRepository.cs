using System;
using System.Linq.Expressions;
using UnitOfWorkFactory.Entities;

namespace UnitOfWorkFactory.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        void Create(T t);
        void Get(int id);
        void Get(T t);
        void GetAll();
        void GetAll(Expression<Func<T, bool>> predicate);
        void Upsert(int id, T t);
        void Upsert(T t);
        void Delete(int id);
        void Delete(T t);
        void Save();
    }
}