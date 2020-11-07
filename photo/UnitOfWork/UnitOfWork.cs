using photo.Data;
using System;
using System.Collections;
using System.Data.Entity;
using System.Threading.Tasks;

namespace photo.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        public UnitOfWork(DbContext dBContext) 
        {
            this.dBContext = dBContext;
        }

        public DbContext dBContext { get; private set; }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<int> save()  
        {
            return await this.dBContext.SaveChangesAsync();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dBContext.Dispose();
                    this.dBContext = null;
                }
            }
            this.disposed = true;
        }
    }
}
