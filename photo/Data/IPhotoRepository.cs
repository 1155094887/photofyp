using System;
using System.Collections.Generic;
using System.Linq;
using photo.Dto;
using photo.Models;

namespace photo.Data
{
    public interface IPhotoRepository
    {
        bool SaveChanges();
        public IQueryable<Photo> GetAllPhotosById(int id);
        public User GetProfileDesp(int id);
        public Photo GetPhotoById(int id);

        public void AddPhoto(Photo photo);
        public void AddPhotoByUser(PhotoAddRt photo);
    }
}
