using System;
using Microsoft.EntityFrameworkCore;
using photo.Dto;
using photo.Models;

namespace photo.Data
{
    public class PhotoContext : DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> options) : base(options)
        {

        }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
