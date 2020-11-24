using System;
using System.Collections.Generic;
using System.Linq;
using photo.Dto;
using photo.Models;

namespace photo.Data
{
    public interface IUserRepository
    {
        bool SaveChanges();
        public int Register(User user);
        public int Login(string username, string password);
        public UserRt GetUserDetail(int id);

    }
}
