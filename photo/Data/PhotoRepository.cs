using Microsoft.EntityFrameworkCore;
using photo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Data
{
    public class PhotoRepository : IPhotoRepository
    {
        public Photo GetPhotoById(int id)
        {
            return new Photo { Id = 1,Name = "aaa", Description = "sss",Url = "alpa" };
        }

        public IEnumerable<Photo> GetAllPhotos()
        {
            var photo = new List<Photo>
            {
                new Photo{Id = 1,Name = "d",Description = "vdv",Url = "url"},
                new Photo{Id = 2,Name = "e",Description = "aaa",Url = "aaa"},
                new Photo{Id = 3,Name = "z",Description = "assa",Url = "asa"}
            };
            return photo;
        }
    }
}
