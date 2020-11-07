using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using photo.UnitOfWork;

namespace photo.Data
{
    class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaseRepository(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }



    }
}
