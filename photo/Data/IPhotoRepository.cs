using System;
using System.Collections.Generic;
using System.Linq;
using photo.Models;

namespace photo.Data
{
    public interface IPhotoRepository
    {
        bool SaveChanges();
        public IQueryable<Photo> GetAllPhotos();
        public IQueryable<Photo> GetAllPhotosByUserId();
        public Photo GetPhotoById(int id);

        public void AddPhoto(Photo photo);
    }
}
