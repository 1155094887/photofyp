using System;
using System.Collections.Generic;
using System.Linq;
using photo.Models;

namespace photo.Data
{
    public interface IPhotoRepository
    {
        public IQueryable<Photo> GetAllPhotos();
        public Photo GetPhotoById(int id);
        
    }
}
