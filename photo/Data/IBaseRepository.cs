using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using photo.UnitOfWork;

namespace photo.Data
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">實體</param>
        public void Add(TEntity entity);

        /// <summary>
        /// 取得全部
        /// </summary>
        /// <returns></returns>
        public Task<ICollection<TEntity>> GetAllAsync();

        /// <summary>
        /// 取得單筆
        /// </summary>
        /// <param name="predicate">查詢條件</param>
        /// <returns></returns>
        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="entity">實體</param>
        public void Remove(TEntity entity);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">實體</param>
        public void Update(TEntity entity);
    }
}
