﻿using System;
using System.Data.Entity;
using photo.Data;

namespace photo.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void save(); 
        IBaseRepository<T> BaseRepository<T>() where T : class;
    }
}
