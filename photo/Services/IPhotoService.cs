using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using photo.Models;

namespace photo.Services
{
    public interface IPhotoService
    {
        /// <summary>
        /// 新增 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        Task<int> AddAsync(Photo blogDto);

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="blogQueryDto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<Photo>> GetAsync(Photo blogQueryDto);

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blogId">Blog Id</param>
        /// <returns></returns>
        Task<int> RemoveAsync(int photoId);

        /// <summary>
        /// 修改 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        Task<int> UpdateAsync(Photo blogDto);
    }
}
