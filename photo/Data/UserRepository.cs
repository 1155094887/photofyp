using photo.Dto;
using photo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photo.Data
{
        public class UserRepository : IUserRepository
        {
            private readonly PhotoContext _context;

            public UserRepository(PhotoContext context)
            {
                _context = context;
            }
            public bool SaveChanges()
            {
                return _context.SaveChanges() >= 0;
            }

            public int Register(User user)
            {
                _context.Add(user);
                return 1;
            }

            public int Login(string username, string password)
            {
                return _context.Users.AsQueryable().Where(x => x.Username == username && x.Password == password).Count();
        }

            public UserRt GetUserDetail(int id)
            {
                throw new NotImplementedException();
            }

    }
}
