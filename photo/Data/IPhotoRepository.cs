using System;
using System.Collections.Generic;
using photo.Models;

namespace photo.Data
{
    public interface IPhotoRepository
    {
        public IEnumerable<Photo> GetAllPhotos();
        public Photo GetPhotoById(int id);
        
    }
}
