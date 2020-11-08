using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using photo.Data;
using photo.Models;
using photo.UnitOfWork;

namespace photo.Services
{
    public class PhotoService
    {
        private IBaseRepository<Photo> _photoRepository;
        private IMapper _mapper;
        private IUnitOfWork _unitofwork;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogService"/> class.
        /// </summary>
        public PhotoService(
            IUnitOfWork unitofwork,
            IBaseRepository<Photo> photoRepository,
            IMapper mapper)
        {
            this._unitofwork = unitofwork;
            this._photoRepository = photoRepository;
            this._mapper = mapper;
        }

        /// <summary>
        /// 新增 Photo
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<int> AddAsync(Photo blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Photo>(blogDto);

            this._photoRepository.Add(blog);
            return await this._unitofwork.dBContext.SaveChangesAsync();
        }

        /// <summary>
        /// 取得 Blog
        /// </summary>
        /// <param name="blogQueryDto">查詢條件</param>
        /// <returns></returns>
        public async Task<IEnumerable<Photo>> GetAsync(Photo blogQueryDto)
        {
            var blogs = await this._photoRepository.GetAllAsync();

            // Convert Blog to BlogDto
            var photo = this._mapper.Map<IEnumerable<Photo>>(blogs);

            return photo;
        }

        /// <summary>
        /// 刪除 Blog
        /// </summary>
        /// <param name="blogId">Blog Id</param>
        /// <returns></returns>
        public async Task<int> RemoveAsync(int photoId)
        {
            var blog = await this._photoRepository.GetAsync(x => x.Id == photoId);

            this._photoRepository.Remove(blog);
            return await this._unitofwork.save();
        }

        /// <summary>
        /// 修改 Blog
        /// </summary>
        /// <param name="blogDto">Blog Dto</param>
        /// <returns></returns>
        public async Task<int> UpdateAsync(Photo blogDto)
        {
            // Convert BlogDto to Blog
            var blog = this._mapper.Map<Photo>(blogDto);

            this._photoRepository.Update(blog);
            return await this._unitofwork.save();
        }
    
}
}
