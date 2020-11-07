using photo.Data;
using System;
using System.Collections;
using System.Data.Entity;

namespace photo.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        private bool disposed;
        private Hashtable repositories;
        public UnitOfWork() 
        {

    }

        public IBaseRepository<T> BaseRepository<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
