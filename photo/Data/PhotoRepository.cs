using Microsoft.EntityFrameworkCore;
using photo.Dto;
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
        public User GetProfileDesp(int id)
        {
            var userdetail = _context.Users.AsQueryable().Where(x => x.Id == id).FirstOrDefault();
            return userdetail;
        }

        public IQueryable<Photo> GetAllPhotosById(int id)
        {
            //can get with predicate
            return _context.Photos.AsQueryable().Where(x => x.ByUserId == id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }


        public Photo GetPhotoById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddPhotoByUser(PhotoAddRt photoForm)
        {
            Console.Write(photoForm);
            _context.Add(photoForm);
        }
        public void AddPhoto(Photo photo)
        {
            if (photo == null)
                throw new ArgumentNullException(nameof(photo));
            _context.Add(photo);
        }

    }
}
