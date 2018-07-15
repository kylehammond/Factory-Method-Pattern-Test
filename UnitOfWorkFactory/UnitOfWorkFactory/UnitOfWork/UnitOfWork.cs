using System;
using UnitOfWorkFactory.Connections;
using UnitOfWorkFactory.Entities;
using UnitOfWorkFactory.EntityFramework;
using UnitOfWorkFactory.Repository;

namespace UnitOfWorkFactory.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        public UnitOfWork(IConnection connection)
        {
            AppDbContext = new AppDbContext(connection.ConnectionString);

            BananaRepository = new Repository<Banana>(AppDbContext);
            BookRepository = new Repository<Book>(AppDbContext);
        }

        public AppDbContext AppDbContext { get; set; }

        public Repository<Banana> BananaRepository { get; set; }
        public Repository<Book> BookRepository { get; set; }

        public void Dispose()
        {
            AppDbContext.Dispose();
        }
    }
}