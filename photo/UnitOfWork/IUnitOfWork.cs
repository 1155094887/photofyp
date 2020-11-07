using System;
using System.Data.Entity;
using System.Threading.Tasks;
using photo.Data;

namespace photo.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext dBContext { get; }
        Task<int> save(); 
    }
}
