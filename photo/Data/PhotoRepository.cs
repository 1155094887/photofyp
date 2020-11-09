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
        private readonly PhotoContext _context;

        public PhotoRepository(PhotoContext context)
        {
            _context = context;
        }
        public Photo GetPhotoById(int id)
        {
            return _context.Photos.AsQueryable().Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<Photo> GetAllPhotos()
        {
            //can get with predicate
            return _context.Photos.AsQueryable();
        }
    }
}
