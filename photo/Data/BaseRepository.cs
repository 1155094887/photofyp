using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using photo.UnitOfWork;
using System.Threading.Tasks;

namespace photo.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaseRepository(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
        public void Add(TEntity entity)
        {
            _unitOfWork.dBContext.Set<TEntity>().Add(entity);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await this._unitOfWork.dBContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await this._unitOfWork.dBContext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public void Remove(TEntity entity)
        {
            //to be implemented
        }

        public void Update(TEntity entity)
        {
            //to be implemented
        }
    }
}
